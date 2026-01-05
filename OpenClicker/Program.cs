using OpenClicker.Forms.Hotkeys;
using OpenClicker.Forms.Main;
using OpenClicker.Lib;
using OpenClicker.Models;
using OpenClicker.Models;
using System.Runtime.InteropServices;
using OCMouseButtons = OpenClicker.Models.OCMouseButtons;

namespace OpenClicker;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        using var hotkeyManager = new HotkeyManager();

        // Set standard hotkeys
        try
        {
            hotkeyManager.LoadHotKeys();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Couldn't load hotkeys from settings.\n Using default hokeys and restoring file.\nDetails:\n\n{ex.Message}", "Error loading hotkeys", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Determine if file needs to be opened
        string? fileToOpen = args.Length > 0 ? args[0] : null;

        Application.Run(new Main(hotkeyManager, fileToOpen));
    }

    public static void CreateSettingsFolderIfNotExist()
    {
        if (!Directory.Exists(Constants.SETTINGS_PATH))
        {
            Directory.CreateDirectory(Constants.SETTINGS_PATH);
        }
    }
}