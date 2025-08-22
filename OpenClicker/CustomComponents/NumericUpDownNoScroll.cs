using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.CustomComponents;
public class NumericUpDownNoScroll : NumericUpDown
{
    protected override void OnMouseWheel(MouseEventArgs e)
    {
    }
}
