using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenClicker.Models;

namespace OpenClicker
{
    public partial class OverlayForm : Form
    {
        public Point CapturedPoint { get; private set; }
        public bool PointCaptured { get; private set; }

        public OverlayForm()
        {
            InitializeComponent();

            // Set full virtual screen bounds
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = SystemInformation.VirtualScreen;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.ShowInTaskbar = false;
            this.Cursor = Cursors.Cross;

            this.DoubleBuffered = true;

            this.MouseMove += OverlayForm_MouseMove;
            this.MouseDown += OverlayForm_MouseDown;

            lblCoords.AutoSize = true;
            lblCoords.BackColor = Color.LightYellow;
        }

        private void OverlayForm_MouseMove(object sender, MouseEventArgs e)
        {
            Point screenPoint = this.PointToScreen(e.Location);
            lblCoords.Text = $"X: {screenPoint.X}, Y: {screenPoint.Y}";
            // Adjust label to not go off-screen
            int labelOffset = 20;
            lblCoords.Location = new Point(
                Math.Min(e.X + labelOffset, this.Width - lblCoords.Width - 10),
                Math.Min(e.Y + labelOffset, this.Height - lblCoords.Height - 10));
        }

        private void OverlayForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CapturedPoint = Cursor.Position;
                PointCaptured = true;
                this.Close();
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Cancel on right-click
                PointCaptured = false;
                this.Close();
            }
        }
    }
}
