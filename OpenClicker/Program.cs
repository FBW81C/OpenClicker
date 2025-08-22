using OpenClicker.Models;
using System.Runtime.InteropServices;

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
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Main());
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

    public static void Click(ClickTypes type, MouseButtons button, Point? point = null, bool? twice = false)
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

    private static void ClickWithButton(MouseButtons button)
    {
        switch (button)
        {
            case MouseButtons.Left:
                LeftClick();
                break;
            case MouseButtons.Right:
                RightClick();
                break;
            case MouseButtons.Middle:
                MiddleClick();
                break;
            default:
                break;
        }
    }
}