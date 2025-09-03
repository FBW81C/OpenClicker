using OpenClicker.Forms.Hotkeys;
using OpenClicker.Forms.Main;
using OpenClicker.Models;
using OpenClicker.Models;
using System.Runtime.InteropServices;
using OCMouseButtons = OpenClicker.Models.OCMouseButtons;

namespace OpenClicker;

static class Program
{
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;
    private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
    private const int MOUSEEVENTF_MIDDLEUP = 0x40;

    [DllImport("user32.dll", SetLastError = true)]
    private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int X, int Y);

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
        hotkeyManager.RegisterHotKey(Keys.F8, 0, HotKeys.Start);

        // Determine if file needs to be opened
        string? fileToOpen = args.Length > 0 ? args[0] : null;

        Application.Run(new Main(hotkeyManager, fileToOpen));
    }

    private static void LeftClick()
    {
        PressMouseButton(MOUSEEVENTF_LEFTDOWN);
        PressMouseButton(MOUSEEVENTF_LEFTUP);
    }
    private static void RightClick()
    {
        PressMouseButton(MOUSEEVENTF_RIGHTDOWN);
        PressMouseButton(MOUSEEVENTF_RIGHTUP);
    }
    private static void MiddleClick()
    {
        PressMouseButton(MOUSEEVENTF_MIDDLEDOWN);
        PressMouseButton(MOUSEEVENTF_MIDDLEUP);
    }

    private static void PressMouseButton(int button)
    {
        mouse_event(button, 0, 0, 0, IntPtr.Zero);
    }

    public static void Click(ClickTypes type, OCMouseButtons button, Point? point = null, bool? twice = false)
    {
        if (type == ClickTypes.Hold)
        {
            throw new InvalidOperationException();
        }

        if (point != null)
        {
            SetCursorPos(point.Value.X, point.Value.Y);
        }

        ClickWithButton(button);
        if (type == ClickTypes.Double)
        {
            ClickWithButton(button);
        }
    }

    private static void ClickWithButton(OCMouseButtons button)
    {
        switch (button)
        {
            case OCMouseButtons.Left:
                LeftClick();
                break;
            case OCMouseButtons.Right:
                RightClick();
                break;
            case OCMouseButtons.Middle:
                MiddleClick();
                break;
            default:
                break;
        }
    }

    public static void ToggleMouseButton(OCMouseButtons button, bool down, Point? point = null)
    {
        if (point != null)
        {
            SetCursorPos(point.Value.X, point.Value.Y);
        }

        switch (button)
        {
            case OCMouseButtons.Left:
                PressMouseButton(down ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_LEFTUP);
                break;
            case OCMouseButtons.Right:
                PressMouseButton(down ? MOUSEEVENTF_RIGHTDOWN : MOUSEEVENTF_RIGHTUP);
                break;
            case OCMouseButtons.Middle:
                PressMouseButton(down ? MOUSEEVENTF_MIDDLEDOWN : MOUSEEVENTF_MIDDLEUP);
                break;
            default:
                break;
        }
    }
}