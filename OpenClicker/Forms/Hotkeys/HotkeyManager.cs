using OpenClicker.Exceptions;
using OpenClicker.models.Hotkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenClicker.Forms.Hotkeys;

public class HotkeyManager : NativeWindow, IDisposable
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    private readonly Dictionary<HotKeys, HotkeyConfig> _hotkeys = [];

    public event Action<HotKeys>? HotkeyPressed;

    public HotkeyManager()
    {
        CreateHandle(new CreateParams()); // invisible window for Hotkey-Messages
    }

    public Dictionary<HotKeys, HotkeyConfig> GetHotKeys()
    {
        return _hotkeys.ToDictionary();
    }

    public int RegisterHotkey(HotkeyConfig hotkeyConfig, HotKeys hotkey)
    {
        UnregisterHotkey(hotkey);

        int id = (int)hotkey;
        if (!RegisterHotKey(this.Handle, id, hotkeyConfig.Modifier, (int)hotkeyConfig.Key))
            throw new InvalidOperationException("Hotkey couldn't be registered. Hotkey is maybe already in use by another application");

        _hotkeys[hotkey] = hotkeyConfig;
        return id;
    }

    private void UnregisterHotkey(HotKeys hotkey)
    {
        if (_hotkeys.ContainsKey(hotkey))
        {
            var id = (int)hotkey;
            UnregisterHotKey(this.Handle, id);
            _hotkeys.Remove(hotkey);
        }
    }

    protected override void WndProc(ref Message m)
    {
        const int WM_HOTKEY = 0x0312;

        if (m.Msg == WM_HOTKEY)
        {
            var hotkeyEnum = (HotKeys)m.WParam.ToInt32();
            if (_hotkeys.TryGetValue(hotkeyEnum, out var hotkey))
            {
                HotkeyPressed?.Invoke(hotkeyEnum);
            }
        }
        base.WndProc(ref m);
    }

    public void Dispose()
    {
        foreach (var hotkey in _hotkeys.Keys.ToList())
            UnregisterHotkey(hotkey);
        DestroyHandle();
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

    public string GetModifierFromInt(int modifier)
    {
        List<string> mods = [];

        if ((modifier & 0x2) != 0) mods.Add("Strg");
        if ((modifier & 0x1) != 0) mods.Add("Alt");
        if ((modifier & 0x4) != 0) mods.Add("Shift");
        if ((modifier & 0x8) != 0) mods.Add("Win");

        return string.Join(" + ", mods);
    }

    public void SetDefaultHotkeys()
    {
        foreach (var key in Constants.DEFAULT_HOTKEYS.Keys)
        {
            RegisterHotkey(Constants.DEFAULT_HOTKEYS[key], key);
        }
        SaveHotKeys();
    }

    public void SaveHotKeys()
    {
        Program.CreateSettingsFolderIfNotExist();

        try
        {
            var json = JsonSerializer.Serialize(_hotkeys);
            File.WriteAllText(Constants.HOTKEYS_PATH, json);
        }
        catch (Exception ex)
        {
            throw new OCInvalidFile($"Failed to save Hotkeys:\n{ex.Message}");
        }
    }
    public void LoadHotKeys()
    {
        if (File.Exists(Constants.HOTKEYS_PATH))
        {
            try
            {
                string content = File.ReadAllText(Constants.HOTKEYS_PATH);
                var hotkeys = JsonSerializer.Deserialize<Dictionary<HotKeys, HotkeyConfig>>(content);

                if (hotkeys == null) 
                {
                    throw new OCInvalidFile("file corrupted"); 
                }

                foreach (var key in hotkeys.Keys)
                {
                    RegisterHotkey(hotkeys[key], key);
                }
            }
            catch (Exception ex)
            {
                SetDefaultHotkeys();
                throw new OCInvalidFile($"File couldn't be read:\n{ex.Message}");
            }
        } 
        else
        {
            SetDefaultHotkeys();
        }
    }
}
