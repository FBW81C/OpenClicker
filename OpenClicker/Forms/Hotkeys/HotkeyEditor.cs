using OpenClicker.models.Hotkeys;
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
    private Dictionary<HotKeys, HotkeyConfig> _hotkeys = [];

    public HotkeyEditor(HotkeyManager hotkeyManager)
    {
        InitializeComponent();
        _hotkeyManager = hotkeyManager;
    }

    private void HotkeyEditor_Load(object sender, EventArgs e)
    {
        this.ActiveControl = null;
        _hotkeys = _hotkeyManager.GetHotKeys();

        UpdateUI(_hotkeys);
    }

    private void tb_start_KeyDown(object? sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = _hotkeyManager.GetModifier(e);

        _hotkeys[HotKeys.Start] = new HotkeyConfig(pressedKey, pressedMod);

        tb_start.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private void tb_stop_KeyDown(object sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = _hotkeyManager.GetModifier(e);

        _hotkeys[HotKeys.Stop] = new HotkeyConfig(pressedKey, pressedMod);

        tb_stop.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private void tb_toggle_KeyDown(object sender, KeyEventArgs e)
    {
        Keys pressedKey = e.KeyCode;
        int pressedMod = _hotkeyManager.GetModifier(e);

        _hotkeys[HotKeys.Toggle] = new HotkeyConfig(pressedKey, pressedMod);

        tb_toggle.Text = $"{(e.Modifiers != Keys.None ? $"{e.Modifiers} + " : "")}{pressedKey}";
        e.SuppressKeyPress = true;
    }

    private void btn_ok_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (HotKeys key in _hotkeys.Keys)
            {
                _hotkeyManager.RegisterHotkey(_hotkeys[key], key);
            }
            _hotkeyManager.SaveHotKeys();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Failed to save hotkeys", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        this.Close();
    }

    private void btn_restore_Click(object sender, EventArgs e)
    {
        _hotkeys.Clear();
        foreach (var value in Constants.DEFAULT_HOTKEYS)
        {
            _hotkeys.Add(value.Key, value.Value);
        }

        UpdateUI(_hotkeys);
    }

    private void UpdateUI(Dictionary<HotKeys, HotkeyConfig> hotkeys)
    {
        hotkeys.TryGetValue(HotKeys.Start, out var startHotKey);
        hotkeys.TryGetValue(HotKeys.Stop, out var stopHotKey);
        hotkeys.TryGetValue(HotKeys.Toggle, out var toggleHotKey);

        tb_start.Text = $"{((startHotKey != null && startHotKey.Modifier != 0) ? $"{_hotkeyManager.GetModifierFromInt(startHotKey.Modifier)} + " : "")}{startHotKey?.Key.ToString() ?? ""}";
        tb_stop.Text = $"{((stopHotKey != null && stopHotKey.Modifier != 0) ? $"{_hotkeyManager.GetModifierFromInt(stopHotKey.Modifier)} + " : "")}{stopHotKey?.Key.ToString() ?? ""}";
        tb_toggle.Text = $"{((toggleHotKey != null && toggleHotKey.Modifier != 0) ? $"{_hotkeyManager.GetModifierFromInt(toggleHotKey.Modifier)} + " : "")}{toggleHotKey?.Key.ToString() ?? ""}";
    }
}
