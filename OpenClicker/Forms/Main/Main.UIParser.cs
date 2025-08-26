using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClicker.Lib;
using OpenClicker.Models;

namespace OpenClicker.Forms.Main;
public partial class Main
{
    private ClickPattern ParseClicksFromUI()
    {
        var list = new List<Click>();
        int? repeat;

        if (tabControl.SelectedIndex == 0)
        { 
            // Single
            var click = new Click
            {
                Position = rb_currentPos.Checked ?
                            null :
                            new global::System.Drawing.Point((int)nup_clickingPos_X.Value, (int)nup_clickingPos_Y.Value),
                ClickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single),
                MouseButton = (OCMouseButtons)(cb_mouseButton.SelectedItem ?? OCMouseButtons.Left),
            };

            if (click.ClickType == ClickTypes.Hold)
            {
                click.HoldingDuration = new TimeSpan(0,
                    (int)nup_duration_h.Value,
                    (int)nup_duration_min.Value,
                    (int)nup_duration_sec.Value,
                    (int)nup_duration_mili.Value);
            }
            else
            {
                click.Delay = new TimeSpan(0,
                    (int)nup_interval_h.Value,
                    (int)nup_interval_min.Value,
                    (int)nup_interval_sec.Value,
                    (int)nup_interval_ms.Value);
            }

            list.Add(click);

            repeat = rb_infinite.Checked ? null : (int)nup_times.Value;
        }
        else
        { 
            // Multiple
            foreach (ClickControl cc in flowLayoutPanel.Controls)
            {
                var click = new Click
                {
                    Position = cc.Position,
                    ClickType = cc.ClickType,
                    MouseButton = cc.MouseButton,
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
                    (int)nup_delay_ms.Value),
            Repeat = repeat
        };

        Clicker.AssertValidClickPattern(pattern);

        return pattern;
    }

    public void PraseClicksToUI(ClickPattern pattern)
    {
        Clicker.AssertValidClickPattern(pattern);

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
            // Click Repeat
            rb_infinite.Checked = pattern.Repeat == null;
            rb_times.Checked = pattern.Repeat != null;
            nup_times.Value = pattern.Repeat ?? nup_times.Value;
            // Click Options
            cb_clickType.SelectedItem = click.ClickType;
            cb_mouseButton.SelectedItem = click.MouseButton;
            if (click.ClickType == ClickTypes.Hold)
            {
                EnableInterval(false);
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
        }
        // Tab: Multiple
        else if (pattern.Clicks.Count > 1)
        {
            // Click Repeat
            rb_multiple_infinite.Checked = pattern.Repeat == null;
            rb_multiple_times.Checked = pattern.Repeat != null;
            nud_multiple_times.Value = pattern.Repeat ?? nup_times.Value;

            foreach (var click in pattern.Clicks)
            {
                var clickControl = new ClickControl(flowLayoutPanel, click);
                flowLayoutPanel.Controls.Add(clickControl);
            }

            // Checkbox: Click at current Pos
            cb_multiple_currentPosition.Checked = pattern.Clicks.All(x => x.Position == null);
        }
    }
}
