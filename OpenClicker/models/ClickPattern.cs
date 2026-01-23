using OpenClicker.Exceptions;
using OpenClicker.models.Click;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenClicker.Models;

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public class ClickPattern
{
    private BindingList<InputAction> _clicks = [];

    public BindingList<InputAction> Clicks
    {
        get => _clicks;
        set
        {
            if (value is BindingList<InputAction> bindingList)
            {
                _clicks = bindingList;
            }
            else if (value != null)
            {
                _clicks = new BindingList<InputAction>(value.ToList());
            }
            else
            {
                _clicks = [];
            }
        }
    }

    public TimeSpan StartingDelay { get; set; }
    public int? Repeat { get; set; }// null = infinite

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
