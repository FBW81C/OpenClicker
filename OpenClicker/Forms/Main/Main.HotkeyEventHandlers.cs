using OpenClicker.Forms.Hotkeys;
using OpenClicker.Models;
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
        hotkeyManager.HotkeyPressed += (hotkey, key, mod) =>
        {

            switch (hotkey)
            {
                case (HotKeys.Start):
                    MessageBox.Show($"START: {mod} + {key}");
                    break;
                case (HotKeys.Stop):
                    MessageBox.Show($"STOP: {mod} + {key}");
                    break;
                case (HotKeys.Toggle):
                    MessageBox.Show($"TOGGLE: {mod} + {key}");
                    break;
                default:
                    MessageBox.Show($"{mod} + {key}");
                    break;
            }
        };
    }
}
