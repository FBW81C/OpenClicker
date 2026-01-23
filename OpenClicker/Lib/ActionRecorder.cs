using Gma.System.MouseKeyHook;
using OpenClicker.models.Click;
using OpenClicker.Models;
using System.Diagnostics;

namespace OpenClicker.Lib;
public class ActionRecorder : IDisposable
{
    private IKeyboardMouseEvents _globalHook;
    private Stopwatch _stopwatch = new();
    private Stopwatch _holdStopwatch = new();
    private List<InputAction> _actions;

    public void Start()
    {
        _actions = new List<InputAction>();
        _globalHook = Hook.GlobalEvents();

        // Maus
        _globalHook.MouseDownExt += GlobalHook_MouseDownExt;
        _globalHook.MouseUpExt += GlobalHook_MouseUpExt;

        // Keyboard
        _globalHook.KeyDown += GlobalHook_KeyDown;
        _globalHook.KeyUp += GlobalHook_KeyUp;

        _stopwatch.Restart();
    }
    public List<InputAction> Stop()
    {
        _globalHook.MouseDownExt -= GlobalHook_MouseDownExt;
        _globalHook.MouseUpExt -= GlobalHook_MouseUpExt;
        _globalHook.KeyDown -= GlobalHook_KeyDown;
        _globalHook.KeyUp -= GlobalHook_KeyUp;

        _globalHook.Dispose();
        _stopwatch.Stop();

        return _actions;
    }

    public void Dispose()
    {
        if (_globalHook != null)
        {
            _globalHook.MouseDownExt -= GlobalHook_MouseDownExt;
            _globalHook.MouseUpExt -= GlobalHook_MouseUpExt;
            _globalHook.KeyDown -= GlobalHook_KeyDown;
            _globalHook.KeyUp -= GlobalHook_KeyUp;
            _globalHook.Dispose();
            _globalHook = null;
        }
    }

    // -------------------------------
    // Mouse Event-Handler
    // -------------------------------
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

        var action = new InputAction
        {
            Type = InputType.Mouse,
            Position = e.Location,
            MouseButton = Mapper.MapMouseButton(e.Button),
            ClickType = type,
            HoldingDuration = type == ClickTypes.Hold ? holding : TimeSpan.Zero,
            Delay = delay
        };

        _actions.Add(action);
    }

    // -------------------------------
    // Keyboard Event-Handler
    // -------------------------------
    private void GlobalHook_KeyDown(object? sender, KeyEventArgs e)
    {
        var delay = _stopwatch.Elapsed;
        _stopwatch.Restart();

        var action = new InputAction
        {
            Type = InputType.Keyboard,
            Key = (ushort)e.KeyValue,
            KeyDown = true,
            Delay = delay
        };

        _actions.Add(action);
    }

    private void GlobalHook_KeyUp(object? sender, KeyEventArgs e)
    {
        var delay = _stopwatch.Elapsed;
        _stopwatch.Restart();

        var action = new InputAction
        {
            Type = InputType.Keyboard,
            Key = (ushort)e.KeyValue,
            KeyDown = false,
            Delay = delay
        };

        _actions.Add(action);
    }
}