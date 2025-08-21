using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Lib;

public static class PickLocation
{
    public static Point? GetLocation()
    {
        using (var overlay = new OverlayForm())
        {
            overlay.ShowDialog(); // Modal
            if (overlay.PointCaptured)
            {
                return overlay.CapturedPoint;
            }
            else
            {
                return null;
            }
        }
    }
}