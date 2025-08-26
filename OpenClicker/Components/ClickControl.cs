using OpenClicker.Lib;
using OpenClicker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClicker;

public partial class ClickControl : UserControl
{
    private FlowLayoutPanel _parentContainer;

    // Outputs
    public ClickTypes ClickType => (ClickTypes)(cb_ClickType.SelectedItem ?? ClickTypes.Single);
    public OCMouseButtons MouseButton => (OCMouseButtons)(cb_MouseButton.SelectedItem ?? OCMouseButtons.Left);
    public Point Position => new Point((int)nud_X.Value, (int)nud_Y.Value);
    public TimeSpan Delay => new TimeSpan(0,
                                (int)nud_h.Value,
                                (int)nud_min.Value,
                                (int)nud_sec.Value,
                                (int)nud_ms.Value);

    // Inputs
    public bool PickLocationEnabled { get => CanUsePickLocation(); set => SetCanUsePickLocation(value); }

    public ClickControl(FlowLayoutPanel parent, Click? click = null)
    {
        InitializeComponent();
        _parentContainer = parent;

        SetClickTypes();
        SetMouseButtons();

        if (click != null)
        {
            cb_ClickType.SelectedItem = click.ClickType;
            cb_MouseButton.SelectedItem = click.MouseButton;
            if (click.Position != null)
            {
                nud_X.Value = click.Position.Value.X;
                nud_Y.Value = click.Position.Value.Y;
            }
            nud_h.Value = click.Delay.Hours + click.Delay.Days * 24;
            nud_min.Value = click.Delay.Minutes;
            nud_sec.Value = click.Delay.Seconds;
            nud_ms.Value = click.Delay.Milliseconds;
        }
    }

    private void SetClickTypes()
    {
        var values = Enum.GetValues<ClickTypes>()
                     .Where(v => v != ClickTypes.Hold)
                     .ToList();

        cb_ClickType.DataSource = values;
        cb_ClickType.SelectedIndex = 0;
    }
    private void SetMouseButtons()
    {
        cb_MouseButton.DataSource = Enum.GetValues<OCMouseButtons>();
        cb_MouseButton.SelectedIndex = 0;
    }

    private void nup_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
        _parentContainer.Controls.Remove(this);
        this.Dispose();
    }

    private void btn_PickLocation_Click(object sender, EventArgs e)
    {
        var location = PickLocation.GetLocation();
        if (location != null)
        {
            nud_X.Value = location.Value.X;
            nud_Y.Value = location.Value.Y;
        }
    }

    private void SetCanUsePickLocation(bool enable)
    {
        nud_X.Enabled = enable;
        nud_Y.Enabled = enable;
        btn_PickLocation.Enabled = enable;
    }
    private bool CanUsePickLocation()
    {
        return nud_X.Enabled && nud_Y.Enabled && btn_PickLocation.Enabled;
    }
}
