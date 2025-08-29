using OpenClicker.Models;
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
    private BindingList<Click> _clicks = [];

    public BindingList<Click> Clicks
    {
        get => _clicks;
        set
        {
            if (value is BindingList<Click> bindingList)
            {
                _clicks = bindingList;
            }
            else if (value != null)
            {
                _clicks = new BindingList<Click>(value.ToList());
            }
            else
            {
                _clicks = [];
            }
        }
    }

    public TimeSpan StartingDelay { get; set; }
    public int? Repeat { get; set; }// null = infinite
}
