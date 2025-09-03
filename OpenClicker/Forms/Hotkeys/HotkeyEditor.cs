using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClicker.Forms.Hotkeys;
public partial class HotkeyEditor : Form
{
    private readonly HotkeyManager _hotkeyManager;

    public HotkeyEditor(HotkeyManager hotkeyManager)
    {
        InitializeComponent();
        _hotkeyManager = hotkeyManager;
    }

    private void tb_start_KeyDown(object? sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = GetModfier(e);

        _hotkeyManager.UnregisterHotKey(HotKeys.Start);
        _hotkeyManager.RegisterHotKey(pressedKey, pressedMod, HotKeys.Start);

        tb_start.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private void tb_stop_KeyDown(object sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = GetModfier(e);

        _hotkeyManager.UnregisterHotKey(HotKeys.Stop);
        _hotkeyManager.RegisterHotKey(pressedKey, pressedMod, HotKeys.Stop);

        tb_stop.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private void tb_toggle_KeyDown(object sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = GetModfier(e);

        _hotkeyManager.UnregisterHotKey(HotKeys.Toggle);
        _hotkeyManager.RegisterHotKey(pressedKey, pressedMod, HotKeys.Toggle);

        tb_toggle.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private int GetModfier(KeyEventArgs e)
    {
        int pressedMod = 0;
        if (e.Control) pressedMod |= 0x2;  // STRG
        if (e.Alt) pressedMod |= 0x1;      // ALT
        if (e.Shift) pressedMod |= 0x4;    // SHIFT
        if ((e.KeyData & Keys.LWin) == Keys.LWin || (e.KeyData & Keys.RWin) == Keys.RWin)
            pressedMod |= 0x8;             // WIN

        return pressedMod;
    }
}
