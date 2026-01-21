using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Models;

public enum InputType
{
    Mouse,
    Keyboard
}

public class InputAction
{
    public InputType Type { get; set; }

    // Mouse
    public Point? Position { get; set; } = null; // null = at cursor position
    public ClickTypes? ClickType { get; set; }
    public OCMouseButtons? MouseButton { get; set; }
    public TimeSpan? HoldingDuration { get; set; }

    // Keyboard
    public ushort? Key { get; set; } // Virtual-Key Code
    public int? Modifiers { get; set; }
    public bool? KeyDown { get; set; }

    // Only for ClickType = Holding
    // Timing
    public TimeSpan Delay { get; set; } // Delay after next click



    // Helper Properties
    public string DisplayPosition =>
        Type == InputType.Mouse ? (Position.HasValue ? $"{Position.Value.X}; {Position.Value.Y}" : "Current") : "";
    public string DisplayKey => 
        Key.HasValue ? ((Keys)Key.Value).ToString() : "";
    public string DisplayKeyDown => 
        KeyDown.HasValue ? (KeyDown.Value ? "Down" : "Up") : "";
}
