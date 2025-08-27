using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Models;
public class Click
{
    public Point? Position { get; set; } = null; // null = at cursor position
    public ClickTypes ClickType { get; set; }
    public OCMouseButtons MouseButton { get; set; }
    public TimeSpan Delay { get; set; } // Delay after next click

    // Only for ClickType = Holding
    public TimeSpan HoldingDuration { get; set; }



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
