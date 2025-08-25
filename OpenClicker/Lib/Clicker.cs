using OpenClicker.Exceptions;
using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClicker.Lib;
public static class Clicker
{
    public static void AssertValidClickPattern(ClickPattern pattern)
    {
        if (pattern.StartingDelay < TimeSpan.Zero)
        {
            throw new InvalidClickPatternException("Starting delay can't be negative");
        }

        if (pattern.Repeat != null && pattern.Repeat < 1)
        {
            throw new InvalidClickPatternException("Repeat must be greater 0 if not infinite");
        }

        foreach (var click in pattern.Clicks)
        {
            if (click.ClickType == ClickTypes.Hold)
            {
                if (click.HoldingDuration <= TimeSpan.Zero)
                {
                    throw new InvalidClickPatternException("Holding duration must be greater 0");
                }
            }
            else
            {
                if (click.Delay <= TimeSpan.Zero)
                {
                    throw new InvalidClickPatternException("All intervals must be greater 0");
                }
            }
        }
    }
}
