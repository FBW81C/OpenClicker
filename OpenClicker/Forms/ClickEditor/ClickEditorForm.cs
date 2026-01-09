using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenClicker.Lib;
using OpenClicker.Models;

namespace OpenClicker.Forms.ClickEditor;
public partial class ClickEditorForm : Form
{
    public InputAction Click { get; private set; }

    public ClickEditorForm(InputAction? existing = null)
    {
        InitializeComponent();
        SetClickTypes();
        SetMouseButtons();
        gb_duration.Enabled = false;
        rb_currentPos.Checked = true;

        if (existing != null)
        {
            // Delay
            nud_delay_h.Value = existing.Delay.Hours + existing.Delay.Days * 24;
            nud_delay_min.Value = existing.Delay.Minutes;
            nud_delay_sec.Value = existing.Delay.Seconds;
            nud_delay_ms.Value = existing.Delay.Milliseconds;
            // Click Options
            cb_clickType.SelectedItem = existing.ClickType;
            cb_mouseButton.SelectedItem = existing.MouseButton;
            // Clickin Position
            rb_currentPos.Checked = existing.Position == null;
            rb_XY.Checked = existing.Position != null;
            nud_X.Value = existing.Position?.X ?? 0;
            nud_Y.Value = existing.Position?.Y ?? 0;
            // Duration
            if (existing.ClickType.HasValue)
            {
                gb_duration.Enabled = existing.ClickType.Value == ClickTypes.Hold;
            }
            if (existing.HoldingDuration.HasValue)
            {
                nud_duration_h.Value = existing.HoldingDuration.Value.Hours + existing.HoldingDuration.Value.Days * 24;
                nud_duration_min.Value = existing.HoldingDuration.Value.Minutes;
                nud_duration_sec.Value = existing.HoldingDuration.Value.Seconds;
                nud_duration_ms.Value = existing.HoldingDuration.Value.Milliseconds;
            }

            Click = existing;
        }
        else
        {
            Click = new InputAction();
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

    private void btn_ok_Click(object sender, EventArgs e)
    {
        Click.MouseButton = (OCMouseButtons)(cb_mouseButton.SelectedItem ?? OCMouseButtons.Left);
        Click.ClickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single);
        Click.Delay = new TimeSpan(0,
                                (int)nud_delay_h.Value,
                                (int)nud_delay_min.Value,
                                (int)nud_delay_sec.Value,
                                (int)nud_delay_ms.Value);
        Click.Position = rb_currentPos.Checked ? null : new Point((int)nud_X.Value, (int)nud_Y.Value);

        if (Click.ClickType == ClickTypes.Hold)
        {
            Click.HoldingDuration = new TimeSpan(0,
                (int)nud_duration_h.Value,
                (int)nud_duration_min.Value,
                (int)nud_duration_sec.Value,
                (int)nud_duration_ms.Value);
        }

        DialogResult = DialogResult.OK;
    }

    private void btn_pickLocation_Click(object sender, EventArgs e)
    {
        var location = PickLocation.GetLocation();
        if (location != null)
        {
            nud_X.Value = location.Value.X;
            nud_Y.Value = location.Value.Y;
            rb_XY.Checked = true;
        }
    }

    private void cb_clickType_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var clickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single);

        if (clickType == ClickTypes.Hold)
        {
            gb_duration.Enabled = true;
        }
        else
        {
            gb_duration.Enabled = false;
        }
    }
}
