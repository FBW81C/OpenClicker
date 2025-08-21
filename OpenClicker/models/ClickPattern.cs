using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Models;
public class ClickPattern
{
    public List<Click> Clicks { get; set; } = [];
    public TimeSpan StartingDelay { get; set; }
    public int? Repeat = null; // null = infinite
}
