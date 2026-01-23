using OpenClicker.Forms.Hotkeys;
using OpenClicker.Lib;
using OpenClicker.models;
using OpenClicker.models.Click;
using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        rb_keyDown.Checked = true;

        if (existing != null)
        {
            if (existing.Type == InputType.Mouse)
            {
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

                tabControl.SelectedIndex = 0;
            }
            else
            {
                if (existing.KeyDown.HasValue && existing.KeyDown.Value)
                {
                    rb_keyDown.Checked = true;
                    rb_keyUp.Checked = false;
                } 
                else
                {
                    rb_keyUp.Checked = true;
                    rb_keyDown.Checked = false;
                }
                // TODO: Load pressed key as text
                tb_key.Text = (existing.Key.HasValue ? (Keys)existing.Key.Value : Keys.None).ToString();


                tabControl.SelectedIndex = 1;
            }

            // Delay
            nud_delay_h.Value = existing.Delay.Hours + existing.Delay.Days * 24;
            nud_delay_min.Value = existing.Delay.Minutes;
            nud_delay_sec.Value = existing.Delay.Seconds;
            nud_delay_ms.Value = existing.Delay.Milliseconds;

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
        if (tabControl.SelectedIndex == 0)
        { // Mouse
            Click.Type = InputType.Mouse;

            Click.MouseButton = (OCMouseButtons)(cb_mouseButton.SelectedItem ?? OCMouseButtons.Left);
            Click.ClickType = (ClickTypes)(cb_clickType.SelectedItem ?? ClickTypes.Single);
            Click.Position = rb_currentPos.Checked ? null : new Point((int)nud_X.Value, (int)nud_Y.Value);

            if (Click.ClickType == ClickTypes.Hold)
            {
                Click.HoldingDuration = new TimeSpan(0,
                    (int)nud_duration_h.Value,
                    (int)nud_duration_min.Value,
                    (int)nud_duration_sec.Value,
                    (int)nud_duration_ms.Value);
            }
        }
        else
        { // Keyboard
            Click.Type = InputType.Keyboard;

            if (Click.Key == null)
            {
                MessageBox.Show("No key pressed", "Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Click.KeyDown = rb_keyDown.Checked;
        }

        Click.Delay = new TimeSpan(0,
                                   (int)nud_delay_h.Value,
                                   (int)nud_delay_min.Value,
                                   (int)nud_delay_sec.Value,
                                   (int)nud_delay_ms.Value);

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

    private void tb_key_KeyDown(object sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = GetModifier(e);

        Click.Key = (ushort)pressedKey;
        Click.Modifiers = pressedMod;

        tb_key.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    public int GetModifier(KeyEventArgs e)
    {
        int pressedMod = 0;
        if (e.Control) pressedMod |= 0x2;  // STRG
        if (e.Alt) pressedMod |= 0x1;      // ALT
        if (e.Shift) pressedMod |= 0x4;    // SHIFT
        if ((e.KeyData & Keys.LWin) == Keys.LWin || (e.KeyData & Keys.RWin) == Keys.RWin)
            pressedMod |= 0x8;             // WIN

        return pressedMod;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Delete Mouse or Keyboard if tab changes
        if (tabControl.SelectedIndex == 0)
        { // Delete keyboard
            ResetKeyboardUI();
            Click.Key = null;
            Click.Modifiers = null;
            Click.KeyDown = null;
        } else
        { // Delete mouse
            ResetClickUI();
            Click.Position = null;
            Click.ClickType = null;
            Click.MouseButton = null;
            Click.HoldingDuration = null;
        }
    }

    private void ResetClickUI()
    {
        cb_mouseButton.SelectedIndex = 0;
        cb_clickType.SelectedIndex = 0;
        rb_currentPos.Checked = true;
        rb_XY.Checked = false;
        nud_duration_h.Value = 0;
        nud_duration_min.Value = 0;
        nud_duration_sec.Value = 0;
        nud_duration_ms.Value = 0;
        gb_duration.Enabled = false;
    }
    private void ResetKeyboardUI()
    {
        rb_keyDown.Checked = true;
        rb_keyUp.Checked = false;
        tb_key.Text = "";
    }
}
