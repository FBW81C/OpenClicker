using OpenClicker.Exceptions;
using OpenClicker.Forms.ClickEditor;
using OpenClicker.Forms.Hotkeys;
using OpenClicker.Lib;
using OpenClicker.Lib.NativeAPI;
using OpenClicker.models.Click;
using OpenClicker.Models;

namespace OpenClicker.Forms.Main;

// dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
public partial class Main : Form
{
    private CancellationTokenSource _cts;
    private bool _isRunning => _cts != null;
    private readonly ClickPattern _pattern = new();
    private bool LoadedFromFile = false;
    private HotkeyManager _hotkeyManager;
    private ActionRecorder _clickRecorder;

    public Main(HotkeyManager hotkeyManager, string? filePath = null)
    {
        InitializeComponent();

        _hotkeyManager = hotkeyManager;

        SetClickTypes();
        SetMouseButtons();
        RegsiterHotkeysHandler(_hotkeyManager);

        clickBindingSource.DataSource = _pattern.Clicks;

        nup_duration_h.Enabled = false;
        nup_duration_min.Enabled = false;
        nup_duration_sec.Enabled = false;
        nup_duration_mili.Enabled = false;

        rb_infinite.Checked = true;
        rb_currentPos.Checked = true;
        btn_stop.Enabled = false;

        if (!string.IsNullOrEmpty(filePath))
        {
            LoadProfile(filePath);
        }
        else
        {
            if (File.Exists(Constants.DEFAULTPROFILE_PATH))
            {
                LoadProfile(Constants.DEFAULTPROFILE_PATH);
            }
        }
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
        ClickPattern pattern;
        if (LoadedFromFile)
        {
            pattern = _pattern;
        }
        else
        {
            try
            {
                pattern = ParseClicksFromUI();
                if (pattern.Clicks.Count == 0) throw new InvalidClickPatternException("Pattern is empty");
            }
            catch (InvalidClickPatternException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Pattern", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        // Actual code
        _cts = new CancellationTokenSource();
        try
        {
            if (tabControl.SelectedIndex == 0 && pattern.Clicks.Count > 0 && pattern.Clicks[0].ClickType == ClickTypes.Hold)
                await StartHolding(_cts.Token, pattern);
            else
                await StartClicking(_cts.Token, pattern);
        }
        catch (OperationCanceledException)
        {
            // ignore on purpose
        } 
        finally
        {
            ResetUi();
        }
    }

    private async Task StartClicking(CancellationToken token, ClickPattern pattern)
    {
        await Task.Delay(pattern.StartingDelay, token);

        if (pattern.Repeat == null)
        {
            pb_progress.Style = ProgressBarStyle.Marquee;
        }
        else
        {
            pb_progress.Style = ProgressBarStyle.Continuous;
            pb_progress.Maximum = pattern.Repeat.Value;
            pb_progress.Value = 0;
        }

        var clickCount = 0;

        while (pattern.Repeat == null || clickCount < pattern.Repeat)
        {
            token.ThrowIfCancellationRequested();

            await PlayPattern(pattern.Clicks.ToList(), token);
            clickCount++;
            if (pattern.Repeat != null) pb_progress.Value = clickCount;
        }
    }

    private async Task PlayPattern(List<InputAction> actions, CancellationToken token)
    {
        if (actions == null || actions.Count == 0)
        {
            await Task.Delay(100, token); // prevents 100% CPU usage
            return;
        }

        foreach (var action in actions)
        {
            if (action.Type == InputType.Mouse)
            {
                if (action.MouseButton.HasValue && action.ClickType.HasValue)
                {
                    if (action.ClickType == ClickTypes.Hold && action.HoldingDuration.HasValue)
                    {
                        Input.Hold(action.MouseButton.Value);
                        await Task.Delay(action.HoldingDuration.Value, token);
                        Input.Release(action.MouseButton.Value);

                    }
                    else
                        Input.Click(action.ClickType.Value, action.MouseButton.Value, action.Position);
                }
            }
            else if (action.Type == InputType.Keyboard && action.Key.HasValue)
            {
                if (action.KeyDown.HasValue)
                {
                    if (action.KeyDown.Value)
                        Input.KeyDown(action.Key.Value);
                    else
                        Input.KeyUp(action.Key.Value);
                } 
                else
                    Input.KeyPress(action.Key.Value);
            }

            if (action.Delay > TimeSpan.Zero)
                await Task.Delay(action.Delay, token);
        }
    }

    private async Task StartHolding(CancellationToken token, ClickPattern pattern)
    {
        // Integrity
        var click = pattern.Clicks[0];

        if (!click.MouseButton.HasValue || click.HoldingDuration.HasValue)
        {
            return;
        }

        cb_clickType.Enabled = false;
        pb_progress.Style = ProgressBarStyle.Marquee;

        await Task.Delay(pattern.StartingDelay, token);
        await Hold(token, click);
    }

    private async Task Hold(CancellationToken token, InputAction click)
    {
        try
        {
            Input.Hold(click.MouseButton.Value);
            await Task.Delay(click.HoldingDuration.Value, token);
        }
        catch (OperationCanceledException)
        {
            // Ignore cancellation
        }
        finally
        {
            Input.Release(click.MouseButton.Value);
        }
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
        nud_times.Enabled = enable;
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
        var editor = new ClickEditorForm();
        if (editor.ShowDialog() == DialogResult.OK)
        {
            clickBindingSource.Add(editor.Click);
        }
    }

    private void btn_multiple_EditClick_Click(object sender, EventArgs e)
    {
        if (clickBindingSource.Current is InputAction selected)
        {
            var editor = new ClickEditorForm(selected);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Refresh();
            }
        }
    }

    private void btn_multiple_delete_Click(object sender, EventArgs e)
    {
        if (clickBindingSource.Current is InputAction selected)
        {
            clickBindingSource.Remove(selected);
            dataGridView.Refresh();
        }
    }

    private void btn_deleteAll_Click(object sender, EventArgs e)
    {
        clickBindingSource.Clear();
        dataGridView.Refresh();
    }

    private void btn_record_Click(object sender, EventArgs e)
    {
        btn_record.Enabled = false;

        if (_clickRecorder == null)
        {
            // start recording
            btn_record.Text = "Stop Recording";
            btn_start.Enabled = false;
            _clickRecorder = new ActionRecorder();
            _clickRecorder.Start();
        }
        else
        {
            btn_record.Text = "Record";
            // is recording = stop
            var clicks = _clickRecorder.Stop();

            // remove last click, last click is clicking Stop button
            if (clicks.Count > 0)
            {
                clicks.RemoveAt(clicks.Count - 1);
            }

            foreach (var click in clicks)
            {
                _pattern.Clicks.Add(click);
            }
            dataGridView.Refresh();

            _clickRecorder.Dispose();
            _clickRecorder = null;

            btn_start.Enabled = true;
        }

        btn_record.Enabled = true;
    }
}