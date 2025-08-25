using OpenClicker.CustomComponents;

namespace OpenClicker
{
    partial class ClickControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_MouseButton = new ComboBox();
            lbl_mouseButton = new Label();
            lbl_ClickType = new Label();
            cb_ClickType = new ComboBox();
            nud_X = new NumericUpDownNoScroll();
            nud_Y = new NumericUpDownNoScroll();
            lbl_X = new Label();
            lbl_Y = new Label();
            btn_delete = new Button();
            btn_PickLocation = new Button();
            gp_interval = new GroupBox();
            nud_sec = new NumericUpDownNoScroll();
            nud_h = new NumericUpDownNoScroll();
            nud_min = new NumericUpDownNoScroll();
            nud_ms = new NumericUpDownNoScroll();
            lb_msec = new Label();
            lb_sec = new Label();
            lb_Minutes = new Label();
            lb_Hours = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Y).BeginInit();
            gp_interval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_h).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_ms).BeginInit();
            SuspendLayout();
            // 
            // cb_MouseButton
            // 
            cb_MouseButton.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_MouseButton.FormattingEnabled = true;
            cb_MouseButton.Location = new Point(91, 10);
            cb_MouseButton.Name = "cb_MouseButton";
            cb_MouseButton.Size = new Size(121, 23);
            cb_MouseButton.TabIndex = 0;
            // 
            // lbl_mouseButton
            // 
            lbl_mouseButton.AutoSize = true;
            lbl_mouseButton.Location = new Point(3, 13);
            lbl_mouseButton.Name = "lbl_mouseButton";
            lbl_mouseButton.Size = new Size(82, 15);
            lbl_mouseButton.TabIndex = 1;
            lbl_mouseButton.Text = "Mouse Button";
            // 
            // lbl_ClickType
            // 
            lbl_ClickType.AutoSize = true;
            lbl_ClickType.Location = new Point(3, 42);
            lbl_ClickType.Name = "lbl_ClickType";
            lbl_ClickType.Size = new Size(60, 15);
            lbl_ClickType.TabIndex = 2;
            lbl_ClickType.Text = "Click Type";
            // 
            // cb_ClickType
            // 
            cb_ClickType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ClickType.FormattingEnabled = true;
            cb_ClickType.Location = new Point(91, 39);
            cb_ClickType.Name = "cb_ClickType";
            cb_ClickType.Size = new Size(121, 23);
            cb_ClickType.TabIndex = 3;
            // 
            // nud_X
            // 
            nud_X.Location = new Point(238, 11);
            nud_X.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_X.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            nud_X.Name = "nud_X";
            nud_X.Size = new Size(120, 23);
            nud_X.TabIndex = 4;
            nud_X.KeyPress += nup_KeyPress;
            // 
            // nud_Y
            // 
            nud_Y.Location = new Point(238, 40);
            nud_Y.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_Y.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            nud_Y.Name = "nud_Y";
            nud_Y.Size = new Size(120, 23);
            nud_Y.TabIndex = 5;
            nud_Y.KeyPress += nup_KeyPress;
            // 
            // lbl_X
            // 
            lbl_X.AutoSize = true;
            lbl_X.Location = new Point(218, 13);
            lbl_X.Name = "lbl_X";
            lbl_X.RightToLeft = RightToLeft.No;
            lbl_X.Size = new Size(14, 15);
            lbl_X.TabIndex = 6;
            lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            lbl_Y.AutoSize = true;
            lbl_Y.Location = new Point(218, 42);
            lbl_Y.Name = "lbl_Y";
            lbl_Y.Size = new Size(14, 15);
            lbl_Y.TabIndex = 7;
            lbl_Y.Text = "Y";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(364, 40);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(89, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_PickLocation
            // 
            btn_PickLocation.Location = new Point(364, 11);
            btn_PickLocation.Name = "btn_PickLocation";
            btn_PickLocation.Size = new Size(89, 23);
            btn_PickLocation.TabIndex = 9;
            btn_PickLocation.Text = "Pick Location";
            btn_PickLocation.UseVisualStyleBackColor = true;
            btn_PickLocation.Click += btn_PickLocation_Click;
            // 
            // gp_interval
            // 
            gp_interval.Controls.Add(nud_sec);
            gp_interval.Controls.Add(nud_h);
            gp_interval.Controls.Add(nud_min);
            gp_interval.Controls.Add(nud_ms);
            gp_interval.Controls.Add(lb_msec);
            gp_interval.Controls.Add(lb_sec);
            gp_interval.Controls.Add(lb_Minutes);
            gp_interval.Controls.Add(lb_Hours);
            gp_interval.Location = new Point(12, 69);
            gp_interval.Name = "gp_interval";
            gp_interval.Size = new Size(441, 56);
            gp_interval.TabIndex = 10;
            gp_interval.TabStop = false;
            gp_interval.Text = "Interval before next click";
            // 
            // nud_sec
            // 
            nud_sec.Location = new Point(226, 20);
            nud_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_sec.Name = "nud_sec";
            nud_sec.Size = new Size(72, 23);
            nud_sec.TabIndex = 11;
            // 
            // nud_h
            // 
            nud_h.Location = new Point(6, 20);
            nud_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_h.Name = "nud_h";
            nud_h.Size = new Size(72, 23);
            nud_h.TabIndex = 10;
            // 
            // nud_min
            // 
            nud_min.Location = new Point(113, 20);
            nud_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_min.Name = "nud_min";
            nud_min.Size = new Size(72, 23);
            nud_min.TabIndex = 9;
            // 
            // nud_ms
            // 
            nud_ms.Location = new Point(334, 20);
            nud_ms.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_ms.Name = "nud_ms";
            nud_ms.Size = new Size(72, 23);
            nud_ms.TabIndex = 8;
            // 
            // lb_msec
            // 
            lb_msec.Location = new Point(412, 22);
            lb_msec.Name = "lb_msec";
            lb_msec.Size = new Size(29, 16);
            lb_msec.TabIndex = 7;
            lb_msec.Text = "ms";
            // 
            // lb_sec
            // 
            lb_sec.Location = new Point(299, 22);
            lb_sec.Name = "lb_sec";
            lb_sec.Size = new Size(29, 16);
            lb_sec.TabIndex = 6;
            lb_sec.Text = "sec";
            // 
            // lb_Minutes
            // 
            lb_Minutes.Location = new Point(191, 22);
            lb_Minutes.Name = "lb_Minutes";
            lb_Minutes.Size = new Size(29, 16);
            lb_Minutes.TabIndex = 5;
            lb_Minutes.Text = "min";
            // 
            // lb_Hours
            // 
            lb_Hours.Location = new Point(79, 22);
            lb_Hours.Name = "lb_Hours";
            lb_Hours.Size = new Size(29, 16);
            lb_Hours.TabIndex = 1;
            lb_Hours.Text = "h";
            // 
            // ClickControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gp_interval);
            Controls.Add(btn_PickLocation);
            Controls.Add(btn_delete);
            Controls.Add(lbl_Y);
            Controls.Add(lbl_X);
            Controls.Add(nud_Y);
            Controls.Add(nud_X);
            Controls.Add(cb_ClickType);
            Controls.Add(lbl_ClickType);
            Controls.Add(lbl_mouseButton);
            Controls.Add(cb_MouseButton);
            Name = "ClickControl";
            Size = new Size(467, 134);
            ((System.ComponentModel.ISupportInitialize)nud_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Y).EndInit();
            gp_interval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_h).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_ms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_MouseButton;
        private Label lbl_mouseButton;
        private Label lbl_ClickType;
        private ComboBox cb_ClickType;
        private NumericUpDown nud_X;
        private NumericUpDownNoScroll nud_Y;
        private Label lbl_X;
        private Label lbl_Y;
        private Button btn_delete;
        private Button btn_PickLocation;
        private GroupBox gp_interval;
        private NumericUpDownNoScroll nud_sec;
        private NumericUpDownNoScroll nud_h;
        private NumericUpDownNoScroll nud_min;
        private NumericUpDownNoScroll nud_ms;
        private Label lb_msec;
        private Label lb_sec;
        private Label lb_Minutes;
        private Label lb_Hours;
    }
}
