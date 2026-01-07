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
    public ClickTypes ClickType { get; set; }
    public OCMouseButtons MouseButton { get; set; }
    public TimeSpan HoldingDuration { get; set; }

    // Keyboard
    public ushort? Key { get; set; } // Virtual-Key Code
    public bool? KeyDown { get; set; } // null = Press

    // Only for ClickType = Holding
    // Timing
    public TimeSpan Delay { get; set; } // Delay after next click



    // Helper Properties
    public int? X
    {
        get => Position?.X;
        set
        {
            if (value.HasValue)
                Position = new Point(value.Value, Position?.Y ?? 0);
            else
                Position = null;
        }
    }

    public int? Y
    {
        get => Position?.Y;
        set
        {
            if (value.HasValue)
                Position = new Point(Position?.X ?? 0, value.Value);
            else
                Position = null;
        }
    }
}
