using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenClicker.models.Click;

namespace OpenClicker.Lib.NativeAPI;

public static class Input
{
    /* =========================
       PUBLIC API
       ========================= */

    public static void Click(ClickTypes type, OCMouseButtons button, Point? point = null)
    {
        if (type == ClickTypes.Hold)
            throw new InvalidOperationException("Use Hold/Release for hold clicks.");

        if (point != null)
            //NativeInput.SetCursorPos(point.Value.X, point.Value.Y);
            MoveMouseAbsolute(point.Value.X, point.Value.Y);

        ClickWithButton(button);

        if (type == ClickTypes.Double)
            ClickWithButton(button);
    }

    public static void ToggleMouseButton(OCMouseButtons button, bool down, Point? point = null)
    {
        if (point != null)
            //NativeInput.SetCursorPos(point.Value.X, point.Value.Y);
            MoveMouseAbsolute(point.Value.X, point.Value.Y);

        uint flag = down ? GetDownFlag(button) : GetUpFlag(button);

        SendMouse(flag);
    }

    public static void Hold(OCMouseButtons button, Point? point = null)
    {
        ToggleMouseButton(button, true, point);
    }

    public static void Release(OCMouseButtons button)
    {
        ToggleMouseButton(button, false);
    }

    public static void KeyDown(ushort vk)
    {
        SendKeyboard(vk, false);
    }

    public static void KeyUp(ushort vk)
    {
        SendKeyboard(vk, true);
    }

    public static void KeyPress(ushort vk)
    {
        KeyDown(vk);
        KeyUp(vk);
    }

    /// <summary>
    /// Abosult mouse movement (Multi-Monitor)
    /// </summary>
    public static void MoveMouseAbsolute(int x, int y)
    {
        var vs = SystemInformation.VirtualScreen;

        int nx = (int)Math.Round((x - vs.Left) * 65535.0 / vs.Width);
        int ny = (int)Math.Round((y - vs.Top) * 65535.0 / vs.Height);

        var input = new NativeInput.INPUT
        {
            type = NativeInput.INPUT_MOUSE,
            u = new NativeInput.INPUTUNION
            {
                mi = new NativeInput.MOUSEINPUT
                {
                    dx = nx,
                    dy = ny,
                    dwFlags = NativeInput.MOUSEEVENTF_MOVE |
                              NativeInput.MOUSEEVENTF_ABSOLUTE |
                              NativeInput.MOUSEEVENTF_VIRTUALDESK
                }
            }
        };

        NativeInput.SendInput(1, new[] { input }, Marshal.SizeOf<NativeInput.INPUT>());
    }

    /// <summary>
    /// absolut mouse movement + click (atomicity)
    /// </summary>
    public static void MoveAndClick(int x, int y, OCMouseButtons button)
    {
        var vs = SystemInformation.VirtualScreen;

        int nx = (int)Math.Round((x - vs.Left) * 65535.0 / vs.Width);
        int ny = (int)Math.Round((y - vs.Top) * 65535.0 / vs.Height);

        var inputs = new[]
        {
            new NativeInput.INPUT
            {
                type = NativeInput.INPUT_MOUSE,
                u = new NativeInput.INPUTUNION
                {
                    mi = new NativeInput.MOUSEINPUT
                    {
                        dx = nx,
                        dy = ny,
                        dwFlags = NativeInput.MOUSEEVENTF_MOVE |
                                  NativeInput.MOUSEEVENTF_ABSOLUTE |
                                  NativeInput.MOUSEEVENTF_VIRTUALDESK
                    }
                }
            },
            CreateMouseInput(GetDownFlag(button)),
            CreateMouseInput(GetUpFlag(button))
        };

        NativeInput.SendInput(
            (uint)inputs.Length,
            inputs,
            Marshal.SizeOf<NativeInput.INPUT>());
    }

    /* =========================
       INTERNAL IMPLEMENTATION
       ========================= */

    private static void ClickWithButton(OCMouseButtons button)
    {
        var inputs = new[]
        {
            CreateMouseInput(GetDownFlag(button)),
            CreateMouseInput(GetUpFlag(button))
        };

        NativeInput.SendInput(
            (uint)inputs.Length,
            inputs,
            Marshal.SizeOf<NativeInput.INPUT>());
    }

    private static void SendMouse(uint flags)
    {
        var input = CreateMouseInput(flags);

        NativeInput.SendInput(
            1,
            new[] { input },
            Marshal.SizeOf<NativeInput.INPUT>());
    }

    private static void SendKeyboard(ushort vk, bool keyUp)
    {
        var input = new NativeInput.INPUT
        {
            type = NativeInput.INPUT_KEYBOARD,
            u = new NativeInput.INPUTUNION
            {
                ki = new NativeInput.KEYBDINPUT
                {
                    wVk = vk,
                    dwFlags = keyUp ? NativeInput.KEYEVENTF_KEYUP : 0
                }
            }
        };

        NativeInput.SendInput(
            1,
            new[] { input },
            Marshal.SizeOf<NativeInput.INPUT>());
    }

    private static NativeInput.INPUT CreateMouseInput(uint flags)
    {
        return new NativeInput.INPUT
        {
            type = NativeInput.INPUT_MOUSE,
            u = new NativeInput.INPUTUNION
            {
                mi = new NativeInput.MOUSEINPUT
                {
                    dwFlags = flags
                }
            }
        };
    }

    private static uint GetDownFlag(OCMouseButtons button) => button switch
    {
        OCMouseButtons.Left => NativeInput.MOUSEEVENTF_LEFTDOWN,
        OCMouseButtons.Right => NativeInput.MOUSEEVENTF_RIGHTDOWN,
        OCMouseButtons.Middle => NativeInput.MOUSEEVENTF_MIDDLEDOWN,
        _ => throw new ArgumentOutOfRangeException(nameof(button))
    };

    private static uint GetUpFlag(OCMouseButtons button) => button switch
    {
        OCMouseButtons.Left => NativeInput.MOUSEEVENTF_LEFTUP,
        OCMouseButtons.Right => NativeInput.MOUSEEVENTF_RIGHTUP,
        OCMouseButtons.Middle => NativeInput.MOUSEEVENTF_MIDDLEUP,
        _ => throw new ArgumentOutOfRangeException(nameof(button))
    };
}