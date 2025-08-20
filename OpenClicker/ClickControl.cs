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
    public ClickType ClickType => cb_ClickType.SelectedItem as ClickType ?? new ClickType(ClickTypes.Single);
    public MouseButtonItem MouseButton => cb_MouseButton.SelectedItem as MouseButtonItem ?? new MouseButtonItem();
    public Point Position => new Point((int)nud_X.Value, (int)nud_Y.Value);
    public int Delay => (int)nud_ms.Value +
                        (int)nud_sec.Value * 1000 +
                        (int)nud_min.Value * 1000 * 60 +
                        (int)nud_h.Value * 1000 * 60 * 60;

    // Inputs
    public bool PickLocationEnabled { get => CanUsePickLocation(); set => SetCanUsePickLocation(value); }

    public ClickControl(FlowLayoutPanel parent)
    {
        InitializeComponent();
        _parentContainer = parent;

        SetClickTypes();
        SetMouseButtons();
    }

    private void SetClickTypes()
    {
        var clickTypes = new[]
        {
            new ClickType(ClickTypes.Single),
            new ClickType(ClickTypes.Double)
        };
        cb_ClickType.Items.Clear();
        cb_ClickType.Items.AddRange(clickTypes);
        cb_ClickType.DisplayMember = "DisplayName";
        cb_ClickType.SelectedIndex = 0;
    }
    private void SetMouseButtons()
    {
        cb_MouseButton.Items.Clear();
        var buttons = new[]
        {
            new MouseButtonItem {Value = MouseButtons.Left, DisplayName = "Left"},
            new MouseButtonItem {Value = MouseButtons.Right, DisplayName = "Right"},
            new MouseButtonItem {Value = MouseButtons.Middle, DisplayName = "Middle"}
        };

        cb_MouseButton.Items.AddRange(buttons);
        cb_MouseButton.DisplayMember = "DisplayName";
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
