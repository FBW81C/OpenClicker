using OpenClicker.Forms.Hotkeys;
using OpenClicker.models.Hotkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Forms.Main;
public partial class Main 
{
    public void RegsiterHotkeysHandler(HotkeyManager hotkeyManager)
    {
        hotkeyManager.HotkeyPressed += (hotkey) =>
        {

            switch (hotkey)
            {
                case (HotKeys.Start):
                    OnHotKeyStartPress();
                    break;
                case (HotKeys.Stop):
                    OnHotKeyStopPress();
                    break;
                case (HotKeys.Toggle):
                    OnHotKeyTogglePress();
                    break;
                default:
                    break;
            }
        };
    }
    private void OnHotKeyStartPress()
    {
        if (_isRunning)
        {
            return;
        }

        btn_start_Click(null, EventArgs.Empty);
    }
    private void OnHotKeyStopPress()
    {
        btn_stop_Click(null, EventArgs.Empty);
    }
    private void OnHotKeyTogglePress()
    {
        if (_isRunning)
        {
            OnHotKeyStopPress();
        }

        OnHotKeyStartPress();
    }
}
