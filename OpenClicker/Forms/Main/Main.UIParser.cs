using OpenClicker.Lib;
using OpenClicker.Models;

namespace OpenClicker.Forms.Main;
public partial class Main
{
    private void ParseClicksFromUI()
    {
        Clicker.AssertValidClickPattern(_pattern);

        // Starting Delay
        _pattern.StartingDelay = new TimeSpan(0,
            (int)nup_delay_h.Value,
            (int)nup_delay_min.Value,
            (int)nup_delay_sec.Value,
            (int)nup_delay_ms.Value);
        // Click Repeat
        _pattern.Repeat = rb_infinite.Checked ? null : (int?)nud_times.Value;

        if (tabControl.SelectedIndex == 0)
        {
            _pattern.Clicks.Clear();
            var click = new Click
            {
                Delay = new TimeSpan(0,
                    (int)nup_interval_h.Value,
                    (int)nup_interval_min.Value,
                    (int)nup_interval_sec.Value,
                    (int)nup_interval_ms.Value),
                ClickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single),
                MouseButton = (OCMouseButtons)(cb_mouseButton.SelectedItem ?? OCMouseButtons.Left),
                Position = rb_currentPos.Checked ? null : new Point((int)nup_clickingPos_X.Value, (int)nup_clickingPos_Y.Value)
            };
            _pattern.Clicks.Add(click);
        }
    }

    public void PraseClicksToUI(ClickPattern pattern)
    {
        Clicker.AssertValidClickPattern(pattern);

        // Click Repeat
        rb_infinite.Checked = pattern.Repeat == null;
        rb_times.Checked = pattern.Repeat != null;
        nud_times.Value = pattern.Repeat ?? nud_times.Value;
        // Staring Delay
        nup_delay_h.Value = pattern.StartingDelay.Hours + pattern.StartingDelay.Days * 24;
        nup_delay_min.Value = pattern.StartingDelay.Minutes;
        nup_delay_sec.Value = pattern.StartingDelay.Seconds;
        nup_delay_ms.Value = pattern.StartingDelay.Milliseconds;

        // Tab Page Single:
        if (pattern.Clicks.Count == 1)
        {
            var click = pattern.Clicks[0];
            // Interval
            nup_interval_h.Value = click.Delay.Hours + click.Delay.Days * 24;
            nup_interval_min.Value = click.Delay.Minutes;
            nup_interval_sec.Value = click.Delay.Seconds;
            nup_interval_ms.Value = click.Delay.Milliseconds;
            // Click Options
            cb_clickType.SelectedItem = click.ClickType;
            cb_mouseButton.SelectedItem = click.MouseButton;
            if (click.ClickType == ClickTypes.Hold)
            {
                EnableClickRepeat(false);
                EnableDuration(true);
                EnableClickingPostition(false);
            }
            // Clicking Position
            rb_currentPos.Checked = click.Position == null;
            if (click.Position != null)
            {
                rb_XY.Checked = true;
                nup_clickingPos_X.Value = click.Position.Value.X;
                nup_clickingPos_Y.Value = click.Position.Value.Y;
            }
            // Show Tab
            tabControl.SelectedIndex = 0;
        }
        // Tab: Multiple
        else if (pattern.Clicks.Count > 1)
        {
            // DataViewGrid
            _pattern.StartingDelay = pattern.StartingDelay;
            _pattern.Repeat = pattern.Repeat;
            _pattern.Clicks.Clear();
            foreach (var click in pattern.Clicks)
            {
                _pattern.Clicks.Add(click);
            }

            // Show Tab
            tabControl.SelectedIndex = 1;
        }
    }
}
