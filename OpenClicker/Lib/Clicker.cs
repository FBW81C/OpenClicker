using OpenClicker.Exceptions;
using OpenClicker.Models;

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
            if (click.Delay <= TimeSpan.Zero)
            {
                throw new InvalidClickPatternException("All intervals must be greater 0");
            }

            if (click.ClickType == ClickTypes.Hold)
            {
                if (click.HoldingDuration <= TimeSpan.Zero)
                {
                    throw new InvalidClickPatternException("Holding duration must be greater 0");
                }
            }
        }
    }
}
