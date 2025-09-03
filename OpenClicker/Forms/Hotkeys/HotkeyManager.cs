using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Forms.Hotkeys;

public class HotkeyManager : NativeWindow, IDisposable
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    private readonly Dictionary<HotKeys, (Keys key, int modifier)> _hotkeys = [];

    public event Action<HotKeys, Keys, int>? HotkeyPressed;

    public HotkeyManager()
    {
        CreateHandle(new CreateParams()); // invisible window for Hotkey-Messages
    }

    public int RegisterHotKey(Keys key, int modifier, HotKeys hotkey)
    {
        int id = (int)hotkey;
        if (!RegisterHotKey(this.Handle, id, modifier, (int)key))
            throw new InvalidOperationException("Hotkey couldn't be registered.");

        _hotkeys[hotkey] = (key, modifier);
        return id;
    }

    public void UnregisterHotKey(HotKeys hotkey)
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
                HotkeyPressed?.Invoke(hotkeyEnum, hotkey.key, hotkey.modifier);
            }
        }
        base.WndProc(ref m);
    }

    public void Dispose()
    {
        foreach (var hotkey in _hotkeys.Keys.ToList())
            UnregisterHotKey(hotkey);
        DestroyHandle();
    }
}
