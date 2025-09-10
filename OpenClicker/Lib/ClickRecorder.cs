using Gma.System.MouseKeyHook;
using OpenClicker.Models;
using System.Diagnostics;

namespace OpenClicker.Lib;
public class ClickRecorder : IDisposable
{
    private IKeyboardMouseEvents _globalHook;
    private Stopwatch _stopwatch = new();
    private Stopwatch _holdStopwatch = new();
    private List<Click> _clicks;

    public void Start()
    {
        _clicks = [];
        _globalHook = Hook.GlobalEvents();
        _globalHook.MouseDownExt += GlobalHook_MouseDownExt;
        _globalHook.MouseUpExt += GlobalHook_MouseUpExt;
        _stopwatch.Start();
    }
    public List<Click> Stop()
    {
        _globalHook.MouseDownExt -= GlobalHook_MouseDownExt;
        _globalHook.MouseUpExt -= GlobalHook_MouseUpExt;
        _globalHook.Dispose();
        _stopwatch.Stop();

        return _clicks;
    }

    public void Dispose()
    {
        if (_globalHook != null)
        {
            _globalHook.MouseDownExt -= GlobalHook_MouseDownExt;
            _globalHook.MouseUpExt -= GlobalHook_MouseUpExt;
            _globalHook.Dispose();
            _globalHook = null;
        }
    }

    private void GlobalHook_MouseDownExt(object? sender, MouseEventExtArgs e)
    {
        _holdStopwatch.Restart();
    }

    private void GlobalHook_MouseUpExt(object? sender, MouseEventExtArgs e)
    {
        var delay = _stopwatch.Elapsed;
        _stopwatch.Restart();

        var holding = _holdStopwatch.Elapsed;
        var type = holding.TotalMilliseconds > 200 ? ClickTypes.Hold : ClickTypes.Single;

        var click = new Click
        {
            Position = e.Location,
            ClickType = type,
            MouseButton = Mapper.MapMouseButton(e.Button),
            HoldingDuration = type == ClickTypes.Hold ? holding : TimeSpan.Zero,
            Delay = delay,
        };

        _clicks.Add(click);
    }
}
