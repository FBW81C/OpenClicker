using OpenClicker.Exceptions;
using OpenClicker.Lib;
using OpenClicker.Models;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OpenClicker;

// dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
public partial class Main : Form
{
    private CancellationTokenSource _cts;
    private ClickPattern _pattern = new ClickPattern();

    private MouseButtonItem _selectedMouseButton = new();
    private ClickType _selectedClickType = new(ClickTypes.Single);

    private readonly ClickType _clickTypeHold = new(ClickTypes.Hold);

    public Main()
    {
        InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        btn_stop.Enabled = false;

        SetClickTypes();
        SetMouseButtons();

        // Disable duration becasue clickType default is single not holding
        var isClickTypeHolding = cb_clickType.SelectedItem == _clickTypeHold;
        nup_duration_h.Enabled = isClickTypeHolding;
        nup_duration_min.Enabled = isClickTypeHolding;
        nup_duration_sec.Enabled = isClickTypeHolding;
        nup_duration_mili.Enabled = isClickTypeHolding;

        rb_infinite.Checked = true;
        rb_currentPos.Checked = true;

        rb_multiple_infinite.Checked = true;
    }

    private void SetClickTypes()
    {
        cb_clickType.Items.Clear();
        var clickTypes = new[]
        {
            new ClickType(ClickTypes.Single),
            new ClickType(ClickTypes.Double),
            _clickTypeHold
        };
        cb_clickType.Items.AddRange(clickTypes);
        cb_clickType.DisplayMember = "DisplayName";
        cb_clickType.SelectedIndex = 0;
    }
    private void SetMouseButtons()
    {
        cb_mouseButton.Items.Clear();
        var buttons = new[]
        {
            new MouseButtonItem {Value = MouseButtons.Left, DisplayName = "Left"},
            new MouseButtonItem {Value = MouseButtons.Right, DisplayName = "Right"},
            new MouseButtonItem {Value = MouseButtons.Middle, DisplayName = "Middle"}
        };

        cb_mouseButton.Items.AddRange(buttons);
        cb_mouseButton.DisplayMember = "DisplayName";
        cb_mouseButton.SelectedIndex = 0;
    }

    private async void btn_start_Click(object sender, EventArgs e)
    {
        try
        {
            _pattern = ParseClicks();
            if (_pattern.Clicks.Count == 0) throw new InvalidClickPatternException("Pattern is empty");
        }
        catch (InvalidClickPatternException ex)
        {
            MessageBox.Show(ex.Message);
            ResetUi();
            return;
        }

        // Checks and sets to ensure integrity 
        btn_start.Enabled = false;
        btn_stop.Enabled = true;

        if (_selectedClickType.Type != ClickTypes.Hold)
        {
            cb_clickType.Items.Remove(_clickTypeHold); // Prohibit user from changing to hold while active
        }

        // Actual code

        _cts = new CancellationTokenSource();
        try
        {
            if (tabControl.SelectedIndex == 0 && _selectedClickType.Type == ClickTypes.Hold)
                await StartHolding(_cts.Token);
            else
                await StartClicking(_cts.Token);
        } 
        catch (OperationCanceledException)
        {
            // ignore on purpose
        }
    }

    private async Task StartClicking(CancellationToken token)
    {
        await Task.Delay(_pattern.StartingDelay, token);

        if (_pattern.Repeat == null)
        {
            pb_progress.Style = ProgressBarStyle.Marquee;
        }
        else
        {
            pb_progress.Style = ProgressBarStyle.Continuous;
            pb_progress.Maximum = _pattern.Repeat.Value;
            pb_progress.Value = 0;
        }

        var clickCount = 0;

        try
        {
            while (_pattern.Repeat == null || clickCount < _pattern.Repeat)
            {
                token.ThrowIfCancellationRequested();

                await PlayPattern(_pattern.Clicks, token);
                clickCount++;
                if (_pattern.Repeat != null) pb_progress.Value = clickCount;
            }
        }
        finally
        {
            ResetUi();
        }
    }

    private async Task PlayPattern(List<Click> clicks, CancellationToken token)
    {
        if (clicks == null || clicks.Count == 0)
        {
            await Task.Delay(100, token); // prevents 100% CPU usage
            return;
        }

        foreach (var click in clicks)
        {
            token.ThrowIfCancellationRequested();
            Program.Click(click.ClickType, click.MouseButton, click.Position, click.ClickType == ClickTypes.Double);
            await Task.Delay(click.Delay, token);
        }
    }

    private async Task StartHolding(CancellationToken token)
    {
        cb_clickType.Enabled = false;
        pb_progress.Style = ProgressBarStyle.Marquee;
        var click = _pattern.Clicks[0];

        try
        {
            await Task.Delay(_pattern.StartingDelay, token);
            Program.ToggleMouseButton(click.MouseButton, true);
            await Task.Delay(click.HoldingDuration, token);
        } 
        catch(OperationCanceledException)
        {
            // Ignore cancellation
        } 
        finally
        {
            Program.ToggleMouseButton(click.MouseButton, false);
        }

        ResetUi();
    }

    private void btn_stop_Click(object sender, EventArgs e)
    {
        ResetUi();
    }

    private void ResetUi()
    {
        _cts?.Cancel();
        _cts?.Dispose();
        _cts = null;

        if (!cb_clickType.Items.Contains(_clickTypeHold))
            cb_clickType.Items.Add(_clickTypeHold);

        pb_progress.Style = ProgressBarStyle.Continuous;
        pb_progress.Value = 0;
        cb_clickType.Enabled = true;
        pb_progress.Value = 0;
        btn_start.Enabled = true;
        btn_stop.Enabled = false;
    }

    private void nup_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void cb_clickType_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cb_clickType.SelectedItem is not ClickType clickType) return;

        if (clickType.Type == ClickTypes.Hold)
        {
            EnableInterval(false);
            EnableClickRepeat(false);
            EnableDuration(true);
            EnableClickingPostition(false);
        }
        else
        {
            EnableInterval(true);
            EnableClickRepeat(true);
            EnableDuration(false);
            EnableClickingPostition(true);
        }
    }

    private void EnableInterval(bool enable)
    {
        nup_mili.Enabled = enable;
        nup_sec.Enabled = enable;
        nup_min.Enabled = enable;
        nup_hours.Enabled = enable;
    }
    private void EnableClickRepeat(bool enable)
    {
        rb_times.Enabled = enable;
        nup_times.Enabled = enable;
        rb_infinite.Enabled = enable;
    }
    private void EnableDuration(bool enable)
    {
        nup_duration_h.Enabled = enable;
        nup_duration_min.Enabled = enable;
        nup_duration_sec.Enabled = enable;
        nup_duration_mili.Enabled = enable;
    }

    private void EnableClickingPostition(bool enable)
    {
        rb_XY.Enabled = enable;
        btn_pickLocation.Enabled = enable;
        nup_clickingPos_X.Enabled = enable;
        nup_clickingPos_Y.Enabled = enable;

        if (!enable)
        {
            rb_currentPos.Checked = true;
        }
    }

    private void cb_mouseButton_SelectedIndexChanged(object sender, EventArgs e)
    {
        var button = cb_mouseButton.SelectedItem;
        if (button is MouseButtonItem buttonItem)
        {
            _selectedMouseButton = buttonItem;
        }
        else { _selectedMouseButton = new MouseButtonItem(); }
    }

    private void cb_clickType_SelectedIndexChanged(object sender, EventArgs e)
    {
        var clickType = cb_clickType.SelectedItem;
        if (clickType is ClickType clickType1)
        {
            _selectedClickType = clickType1;
        }
        else { _selectedClickType = new ClickType(ClickTypes.Single); }
    }

    private void btn_pickLocation_Click(object sender, EventArgs e)
    {
        var location = PickLocation.GetLocation();
        if (location != null)
        {
            nup_clickingPos_X.Value = location.Value.X;
            nup_clickingPos_Y.Value = location.Value.Y;
            rb_XY.Checked = true;
        }
    }

    // Multiple Clicks
    private void btn_multiple_addClick_Click(object sender, EventArgs e)
    {
        var clickControl = new ClickControl(flowLayoutPanel1);
        flowLayoutPanel1.Controls.Add(clickControl);
    }

    private ClickPattern ParseClicks()
    {
        var list = new List<Click>();
        int? repeat;

        if (tabControl.SelectedIndex == 0)
        { // Single
            var click = new Click
            {
                Position = rb_currentPos.Checked ? 
                            null : 
                            new Point((int)nup_clickingPos_X.Value, (int)nup_clickingPos_Y.Value),
                ClickType = _selectedClickType.Type,
                MouseButton = _selectedMouseButton.Value,
            };

            if (click.ClickType == ClickTypes.Hold)
            {
                click.HoldingDuration = new TimeSpan(0,
                    (int)nup_duration_h.Value,
                    (int)nup_duration_min.Value,
                    (int)nup_duration_sec.Value,
                    (int)nup_duration_mili.Value);
            } else
            {
                click.Delay = new TimeSpan(0,
                    (int)nup_hours.Value,
                    (int)nup_min.Value,
                    (int)nup_sec.Value,
                    (int)nup_mili.Value);
            }

                list.Add(click);

            repeat = rb_infinite.Checked ? null : (int)nup_times.Value;
        }
        else
        { // Multiple
            foreach (ClickControl cc in flowLayoutPanel1.Controls)
            {
                var click = new Click
                {
                    Position = cc.Position,
                    ClickType = cc.ClickType.Type,
                    MouseButton = cc.MouseButton.Value,
                    Delay = cc.Delay
                };

                if (cb_multiple_currentPosition.Checked)
                {
                    click.Position = null;
                }

                list.Add(click);
            }

            repeat = rb_multiple_infinite.Checked ? null : (int)nud_multiple_times.Value;
        }

        var pattern = new ClickPattern
        {
            Clicks = list,
            StartingDelay = new TimeSpan(0,
                    (int)nup_delay_h.Value,
                    (int)nup_delay_min.Value,
                    (int)nup_delay_sec.Value,
                    (int)nup_delay_mili.Value),
            Repeat = repeat
        };

        AssertValidClickPattern(pattern);

        return pattern;
    }

    private void AssertValidClickPattern(ClickPattern pattern)
    {
        if (pattern.StartingDelay < TimeSpan.Zero)
        {
            throw new InvalidClickPatternException("Starting delay can't be negative");
        }

        if (pattern.Repeat != null && pattern.Repeat < 1)
        {
            throw new InvalidClickPatternException("Repeat must be greater 0 if not infinite");
        }

        foreach (var click in pattern.Clicks)
        {
            if (click.ClickType == ClickTypes.Hold)
            {
                if (click.HoldingDuration <= TimeSpan.Zero)
                {
                    throw new InvalidClickPatternException("Holding duration must be greater 0");
                }
            } 
            else
            {
                if (click.Delay <= TimeSpan.Zero)
                {
                    throw new InvalidClickPatternException("All intervals must be greater 0");
                }
            }
        }
    }

    private void cb_multiple_currentPosition_CheckedChanged(object sender, EventArgs e)
    {
        foreach (ClickControl cc in flowLayoutPanel1.Controls)
        {
            cc.PickLocationEnabled = !cb_multiple_currentPosition.Checked;
        }
    }
}