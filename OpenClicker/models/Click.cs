using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.models;
public class Click
{
    public Point Position { get; set; }
    public ClickTypes ClickType { get; set; }
    public MouseButtons MouseButton { get; set; }
    public int Delay { get; set; } // Delay after next click
}
