using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker;
public static class Constants
{
    public readonly static string APPLICATION_FOLDER_NAME = "OpenClicker_FBW81C";
    public readonly static string FILEENDING = "ocp";

    public readonly static string SETTINGS_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APPLICATION_FOLDER_NAME, "settings");
    public readonly static string DEFAULTPROFILE_PATH = Path.Combine(SETTINGS_PATH, $"defaultProfile.{FILEENDING}");
    public readonly static string TEXTS_PATH = Path.Combine(Application.StartupPath, "assets", "texts");

    public readonly static string LINK_GITHUB = "https://github.com/FBW81C/OpenClicker";
}
