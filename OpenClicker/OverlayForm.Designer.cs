namespace OpenClicker
{
    partial class OverlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCoords = new Label();
            SuspendLayout();
            // 
            // lblCoords
            // 
            lblCoords.AutoSize = true;
            lblCoords.Location = new Point(345, 40);
            lblCoords.Name = "lblCoords";
            lblCoords.Size = new Size(71, 15);
            lblCoords.TabIndex = 0;
            lblCoords.Text = "Coordinates";
            // 
            // OverlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCoords);
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OverlayForm";
            Opacity = 0.5D;
            ShowInTaskbar = false;
            Text = "OverlayForm";
            TopMost = true;
            MouseDown += OverlayForm_MouseDown;
            MouseMove += OverlayForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCoords;
    }
}