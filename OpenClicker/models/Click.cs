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
    public MouseButtons MouseButton { get; set; }
    public TimeSpan Delay { get; set; } // Delay after next click
}
