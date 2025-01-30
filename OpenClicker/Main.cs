using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using OpenClicker.Core.models;
using Timer = System.Windows.Forms.Timer;

namespace OpenClicker;

// Ideas:
// Add starting delay
public partial class Main : Form
{
    private Timer _timer = new() { Interval = 1000 };
    private bool _isClicking = false;
    private int _clickCount = 0;
    private MouseButtonItem _selectedMouseButton = new();
    private ClickType _selectedClickType = new(ClickTypes.Single);
    
    private readonly ClickType _clickTypeHold = new(ClickTypes.Hold);
    
    public Main()
    {
        InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
        rb_infinite.Checked = true;
        
        cb_clickType.Items.Clear();
        cb_mouseButton.Items.Clear();
        
        /*
         * Goofy code. I can't really access ALL buttons on a mouse with example 10 buttons.
         * I can only access Left,Right,Middle,X1,X2
         * makes therefore no sense to make it dynamically
         * If you want to add dynamic support: here is my approach, good luck!
      
            var buttons = Enum.GetValues(typeof(MouseButtons)) //
                .Cast<MouseButtons>()
                .Where(b => b != MouseButtons.None) // Removes None
                .Select(b => new MouseButtonItem
                {
                    Value = b,
                    DisplayName = b.ToString()
                })
                .ToArray();   
            */

        // Clicktypes
        // Unnessesary complex but dynammic
        // var clickTypes = Enum.GetValues(typeof(ClickTypes))
        //     .Cast<ClickTypes>()
        //     .Select(c => new ClickType(c))
        //     .ToArray();
        var clickTypes = new[]
        {
            new ClickType(ClickTypes.Single),
            new ClickType(ClickTypes.Double),
            _clickTypeHold
        };
        cb_clickType.Items.AddRange(clickTypes);
        cb_clickType.DisplayMember = "DisplayName";
        cb_clickType.SelectedIndex = 0;
        
        // Disable duration becasue clickType default is single not holding
        var value = cb_clickType.SelectedItem == _clickTypeHold;
        nup_duration_h.Enabled = value;
        nup_duration_min.Enabled = value;
        nup_duration_sec.Enabled = value;
        nup_duration_mili.Enabled = value;
        
        // Mouse buttons
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
        // Checks and sets to ensure integrity 
        if (_timer.Enabled || _isClicking)
        {
            return;
        }
        btn_start.Enabled = false;
        if (_selectedClickType.Type != ClickTypes.Hold)
        {
            cb_clickType.Items.Remove(_clickTypeHold); // Prohibit user from changing to hold while active
        }
        _clickCount = 0;
        _isClicking = true;

        // Actual code
        var delay = (int)nup_delay_mili.Value +
                    (int)nup_delay_sec.Value * 1000 +
                    (int)nup_min.Value * 60 * 1000 +
                    (int)nup_delay_h.Value * 60 * 60 * 1000;
        if (delay < 0)
        {
            MessageBox.Show("Delay cannot be negative.");
            btn_start.Enabled = true;
            _isClicking = false;
            return;
        }
        
        // TODO: holding and releasing, time (countdown, maybe another groupbox with h,min,sec,mili)
        if (_selectedClickType.Type == ClickTypes.Hold)
        {
            StartHolding(delay);
            return;
        }
        
        // Progress bar
        pb_progress.Minimum = 0;
        pb_progress.Maximum = rb_times.Checked ? (int)nup_times.Value : 10000;
        pb_progress.Value = rb_times.Checked? 0 : 9999;
        
        var interval = (int)nup_mili.Value +
                       (int)nup_sec.Value * 1000 +
                       (int)nup_min.Value * 60 * 1000 +
                       (int)nup_hours.Value * 60 * 60 * 1000;
        if (interval <= 0)
        {
            MessageBox.Show("Interval must be greater than 0");
            btn_start.Enabled = true;
            _isClicking = false;
            return;
        }
        
        _timer.Interval = interval;
        _timer.Tick -= Timer_Tick;
        _timer.Tick += Timer_Tick;
     
        StartTimerWithDelay(delay);
    }

    private async void StartTimerWithDelay(int delay)
    {
        await Task.Delay(delay);
        Timer_Tick(this, EventArgs.Empty); // invoking now, because it will wait "interval" before starting timer
        _timer.Start();
    }
    
    private void Timer_Tick(object? sender, EventArgs e)
    {
        if (!_isClicking) return;

        if (rb_times.Checked)
        {
            _clickCount++;
            pb_progress.Value += pb_progress.Value < pb_progress.Maximum ? 1 : 0; // Progressbar
            if (_clickCount > (int)nup_times.Value)
            {
                StopTimer();
                return; // I have the fear that the code won't do the right thing
            }
        }
        
        switch (_selectedMouseButton.Value) // Clicking
        {
            case MouseButtons.Left:
                Program.LeftClick();
                if (_selectedClickType.Type == ClickTypes.Double)
                {
                    Program.LeftClick();
                }
                break;
            case MouseButtons.Right:
                Program.RightClick();
                if (_selectedClickType.Type == ClickTypes.Double)
                {
                    Program.RightClick();
                }
                break;
            case MouseButtons.Middle:
                Program.MiddleClick();
                if (_selectedClickType.Type == ClickTypes.Double)
                {
                    Program.MiddleClick();
                }
                break;
            default:
                return;
        }
    }

    private async void StartHolding(int delay)
    {
        var duration = (int)nup_duration_mili.Value +
                       (int)nup_duration_sec.Value * 1000 +
                       (int)nup_duration_min.Value * 60 * 1000 +
                       (int)nup_duration_h.Value * 60 * 60 * 1000;
        if (duration <= 0)
        {
            MessageBox.Show("Duration must be greater than 0");
            btn_start.Enabled = true;
            _isClicking = false;
            return;
        }
        
        await Task.Delay(delay);
        switch (_selectedMouseButton.Value)
        {
            case MouseButtons.Left:
                Program.LeftDown();
                break;
            case MouseButtons.Right:
                Program.RightDown();
                break;
            case MouseButtons.Middle:
                Program.MiddleDown();
                break;
            default:
                return;
        }
        
        await Task.Delay(duration);
        StopHolding();
    }

    private void StopHolding()
    {
        _isClicking = false;
        btn_start.Enabled = true;
        pb_progress.Value = 0;
        switch (_selectedMouseButton.Value)
        {
            case MouseButtons.Left:
                Program.LeftUp();
                break;
            case MouseButtons.Right:
                Program.RightUp();
                break;
            case MouseButtons.Middle:
                Program.MiddleUp();
                break;
            default:
                return;
        }
    }

    private void btn_stop_Click(object sender, EventArgs e)
    {
        if (_selectedClickType.Type == ClickTypes.Hold)
        {
            StopHolding();
        }
        else
        {
            StopTimer();
        }
    }

    private void StopTimer()
    {
        _isClicking = false;
        _timer.Stop();
        btn_start.Enabled = true;
        pb_progress.Value = 0;
        cb_clickType.Items.Add(_clickTypeHold);
    }

    private void nup_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void cb_KeyPress(object sender, KeyPressEventArgs e)
    {
        // e.Handled = false; I don't know why this doesn't work... it works on nup_KeyPress(...) 
        e.KeyChar = (char)Keys.None; // Don't allow changes to text
    }

    private void cb_clickType_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cb_clickType.SelectedItem is not ClickType clickType) return;
        
        if (clickType.Type == ClickTypes.Hold)
        {
            // Interval
            nup_mili.Enabled = false;
            nup_sec.Enabled = false;
            nup_min.Enabled = false;
            nup_hours.Enabled = false;
            // Radiobuttons
            rb_times.Enabled = false;
            nup_times.Enabled = false;
            rb_infinite.Enabled = false;
            // Duration
            nup_duration_h.Enabled = true;
            nup_duration_min.Enabled = true;
            nup_duration_sec.Enabled = true;
            nup_duration_mili.Enabled = true;
        }
        else
        {
            // Interval
            nup_mili.Enabled = true;
            nup_sec.Enabled = true;
            nup_min.Enabled = true;
            nup_hours.Enabled = true;
            // Radiobuttons
            rb_times.Enabled = true;
            nup_times.Enabled = true;
            rb_infinite.Enabled = true;
            // Duration
            nup_duration_h.Enabled = false;
            nup_duration_min.Enabled = false;
            nup_duration_sec.Enabled = false;
            nup_duration_mili.Enabled = false;
        }
    }

    private void cb_mouseButton_SelectedIndexChanged(object sender, EventArgs e)
    {
        var button = cb_mouseButton.SelectedItem;
        if (button is MouseButtonItem buttonItem)
        {
            _selectedMouseButton = buttonItem;
        }
        else{ _selectedMouseButton = new MouseButtonItem();}
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
}