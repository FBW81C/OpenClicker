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
}
