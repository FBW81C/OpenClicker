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

    private MouseButtonItem _selectedMouseButton = new();
    private ClickType _selectedClickType = new(ClickTypes.Single);

    private ClickPattern _pattern = new ClickPattern();

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

    private void btn_start_Click(object sender, EventArgs e)
    {
        try
        {
            _pattern = ParseClicks();
        }
        catch (InvalidClickPatternException ex)
        {
            MessageBox.Show(ex.Message);
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

        //if (_selectedClickType.Type == ClickTypes.Hold)
        //{
        //    StartHolding();
        //    return;
        //}

        _cts = new CancellationTokenSource();
        _ = StartClicking(_cts.Token);
    }

    private async Task StartClicking(CancellationToken token)
    {
        pb_progress.Maximum = _pattern.Repeat ?? 1000;
        pb_progress.Value = _pattern.Repeat.HasValue ? 0 : 999;

        await Task.Delay(_pattern.StartingDelay, token);

        var clickCount = 0;

        while ((clickCount < _pattern.Repeat || _pattern.Repeat == null) && !token.IsCancellationRequested)
        {
            await PlayPattern(_pattern.Clicks, token);
            
            clickCount++;
            if (_pattern.Repeat != null) pb_progress.Value = clickCount;
        }

        Reset();
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
            Program.Click(click.ClickType, click.MouseButton, click.Position, click.ClickType == ClickTypes.Double);
            await Task.Delay(click.Delay, token);
        }
    }

    //private async void StartHolding(int delay)
    //{
    //    var duration = (int)nup_duration_mili.Value +
    //                   (int)nup_duration_sec.Value * 1000 +
    //                   (int)nup_duration_min.Value * 60 * 1000 +
    //                   (int)nup_duration_h.Value * 60 * 60 * 1000;
    //    if (duration <= 0)
    //    {
    //        MessageBox.Show("Duration must be greater than 0!");
    //        Reset();
    //        return;
    //    }

    //    cb_clickType.Enabled = false;

    //    await Task.Delay(delay);
    //    if (!_isClicking) return; // check for safty, user could have stopped
    //    StartProgressAsync(duration);
    //    switch (_selectedMouseButton.Value)
    //    {
    //        case MouseButtons.Left:
    //            Program.LeftDown();
    //            break;
    //        case MouseButtons.Right:
    //            Program.RightDown();
    //            break;
    //        case MouseButtons.Middle:
    //            Program.MiddleDown();
    //            break;
    //        default:
    //            return;
    //    }

    //    await Task.Delay(duration);
    //    StopHolding();
    //}

    private async void StartProgressAsync(int duration)
    {
        pb_progress.Minimum = 0;
        pb_progress.Maximum = duration;
        pb_progress.Value = 0;

        const int step = 50; // refresh every 50ms
        for (int elapsed = 0; elapsed < duration; elapsed += step)
        {
            pb_progress.Value = elapsed;
            await Task.Delay(step);
        }
    }

    //private void StopHolding()
    //{
    //    switch (_selectedMouseButton.Value)
    //    {
    //        case MouseButtons.Left:
    //            Program.LeftUp();
    //            break;
    //        case MouseButtons.Right:
    //            Program.RightUp();
    //            break;
    //        case MouseButtons.Middle:
    //            Program.MiddleUp();
    //            break;
    //        default:
    //            break;
    //    }

    //    cb_clickType.Enabled = true;
    //    Reset();
    //}

    private void btn_stop_Click(object sender, EventArgs e)
    {
        //if (_selectedClickType.Type == ClickTypes.Hold)
            //StopHolding();
        Reset();
    }

    private void Reset()
    {
        _cts?.Cancel();

        pb_progress.Value = 0;

        if (!cb_clickType.Items.Contains(_clickTypeHold))
        {
            cb_clickType.Items.Add(_clickTypeHold);
        }

        btn_start.Enabled = true;
        btn_stop.Enabled = false;

        _cts = null;
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
        }
        else
        {
            EnableInterval(true);
            EnableClickRepeat(true);
            EnableDuration(false);
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
            throw new InvalidClickPatternException("Starting delay can't be negative!");
        }

        if (pattern.Repeat != null && pattern.Repeat < 1)
        {
            throw new InvalidClickPatternException("Repeat must be greater 0 if not infinite");
        }

        foreach (var click in pattern.Clicks)
        {
            if (click.Delay <= TimeSpan.Zero)
            {
                throw new InvalidClickPatternException("All intervals must be greater 0!");
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