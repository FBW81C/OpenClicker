using OpenClicker.Exceptions;
using OpenClicker.Lib;
using OpenClicker.Models;

namespace OpenClicker.Forms.Main;

// dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
public partial class Main : Form
{
    private CancellationTokenSource _cts;
    private ClickPattern _pattern = new ClickPattern();
    private bool LoadedFromFile = false;

    public Main(string? filePath = null)
    {
        InitializeComponent();
        SetClickTypes();
        SetMouseButtons();

        if (!string.IsNullOrEmpty(filePath))
        {
            LoadProfile(filePath);
        }
    }

    private void Main_Load(object sender, EventArgs e)
    {
        btn_stop.Enabled = false;

        // Disable duration becasue clickType default is single not holding
        var isClickTypeHolding = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single) == ClickTypes.Hold;
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
        cb_clickType.DataSource = Enum.GetValues<ClickTypes>();
        cb_clickType.SelectedIndex = 0;
    }
    private void SetMouseButtons()
    {
        cb_mouseButton.DataSource = Enum.GetValues<OCMouseButtons>();
        cb_mouseButton.SelectedIndex = 0;
    }

    private async void btn_start_Click(object sender, EventArgs e)
    {
        if (!LoadedFromFile)
        {
            try
            {
                _pattern = ParseClicksFromUI();
                if (_pattern.Clicks.Count == 0) throw new InvalidClickPatternException("Pattern is empty");
            }
            catch (InvalidClickPatternException ex)
            {
                MessageBox.Show(ex.Message);
                ResetUi();
                return;
            }
        }
        LoadedFromFile = false;

        // Checks and sets to ensure integrity 
        btn_start.Enabled = false;
        btn_stop.Enabled = true;

        cb_mouseButton.Enabled = false;
        cb_clickType.Enabled = false;

        //if (_selectedClickType.Type != ClickTypes.Hold)
        //{
        //    cb_clickType.Items.Remove(_clickTypeHold); // Prohibit user from changing to hold while active
        //}

        // Actual code

        _cts = new CancellationTokenSource();
        try
        {
            if (tabControl.SelectedIndex == 0 && _pattern.Clicks[0].ClickType == ClickTypes.Hold)
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
        catch (OperationCanceledException)
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

        pb_progress.Style = ProgressBarStyle.Continuous;
        pb_progress.Value = 0;
        pb_progress.Value = 0;

        cb_mouseButton.Enabled = true;
        cb_clickType.Enabled = true;

        btn_start.Enabled = true;
        btn_stop.Enabled = false;
    }

    private void nup_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void cb_clickType_SelectionChangeCommitted(object sender, EventArgs e)
    {
        //if (cb_clickType.SelectedItem is not ClickType clickType) return;
        var clickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single);

        if (clickType == ClickTypes.Hold)
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
        nup_interval_ms.Enabled = enable;
        nup_interval_sec.Enabled = enable;
        nup_interval_min.Enabled = enable;
        nup_interval_h.Enabled = enable;
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
        var clickControl = new ClickControl(flowLayoutPanel);
        flowLayoutPanel.Controls.Add(clickControl);
    }

    private void cb_multiple_currentPosition_CheckedChanged(object sender, EventArgs e)
    {
        foreach (ClickControl cc in flowLayoutPanel.Controls)
        {
            cc.PickLocationEnabled = !cb_multiple_currentPosition.Checked;
        }
    }
}