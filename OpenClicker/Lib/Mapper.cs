using OpenClicker.models.Click;

namespace OpenClicker.Lib;
public static class Mapper
{
    public static OCMouseButtons MapMouseButton(MouseButtons button)
    {
        return button switch
        {
            MouseButtons.Left => OCMouseButtons.Left,
            MouseButtons.Right => OCMouseButtons.Right,
            MouseButtons.Middle => OCMouseButtons.Middle,
            _ => OCMouseButtons.Left,
        };
    }
}
