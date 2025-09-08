using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClicker.models;
using OpenClicker.Models;

namespace OpenClicker;
public static class Constants
{
    public readonly static string APPLICATION_FOLDER_NAME = "OpenClicker_FBW81C";
    public readonly static string FILEENDING = "ocp";

    public readonly static string SETTINGS_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APPLICATION_FOLDER_NAME, "settings");
    public readonly static string DEFAULTPROFILE_PATH = Path.Combine(SETTINGS_PATH, $"defaultProfile.{FILEENDING}");
    public readonly static string TEXTS_PATH = Path.Combine(Application.StartupPath, "assets", "texts");
    public readonly static string HOTKEYS_PATH = Path.Combine(SETTINGS_PATH, "hotkeys.json");

    public readonly static string LINK_GITHUB = "https://github.com/FBW81C/OpenClicker";

    public readonly static Dictionary<HotKeys, HotkeyConfig> DEFAULT_HOTKEYS = new Dictionary<HotKeys, HotkeyConfig>()
    {
        {HotKeys.Start, new HotkeyConfig(Keys.F6, 0) },
        {HotKeys.Stop, new HotkeyConfig(Keys.F7, 0) },
        {HotKeys.Toggle, new HotkeyConfig(Keys.F8, 0) }
    };
}
