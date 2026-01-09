namespace OpenClicker.Forms.ClickEditor
{
    partial class ClickEditorForm
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
            btn_ok = new Button();
            btn_cancel = new Button();
            gp_clickPos = new GroupBox();
            btn_pickLocation = new Button();
            nud_Y = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_clickingPos_Y = new Label();
            nud_X = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_clickingPos_X = new Label();
            rb_XY = new RadioButton();
            rb_currentPos = new RadioButton();
            flp_delay = new FlowLayoutPanel();
            nud_delay_h = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_h = new Label();
            nud_delay_min = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_min = new Label();
            nud_delay_sec = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_s = new Label();
            nud_delay_ms = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            lbl_ms = new Label();
            gb_delay = new GroupBox();
            gp_options = new GroupBox();
            cb_clickType = new ComboBox();
            lbl_clickType = new Label();
            lbl_mouseButton = new Label();
            cb_mouseButton = new ComboBox();
            gb_duration = new GroupBox();
            flp_duration = new FlowLayoutPanel();
            nud_duration_h = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            label1 = new Label();
            nud_duration_min = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            label2 = new Label();
            nud_duration_sec = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            label3 = new Label();
            nud_duration_ms = new OpenClicker.CustomComponents.NumericUpDownNoScroll();
            label4 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lbl_key = new Label();
            tb_key = new TextBox();
            gp_keyDown = new GroupBox();
            rb_keyUp = new RadioButton();
            rb_keyDown = new RadioButton();
            gp_clickPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_X).BeginInit();
            flp_delay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_delay_h).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_ms).BeginInit();
            gb_delay.SuspendLayout();
            gp_options.SuspendLayout();
            gb_duration.SuspendLayout();
            flp_duration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_duration_h).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_ms).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            gp_keyDown.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ok.Location = new Point(530, 413);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.Location = new Point(449, 413);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gp_clickPos
            // 
            gp_clickPos.Controls.Add(btn_pickLocation);
            gp_clickPos.Controls.Add(nud_Y);
            gp_clickPos.Controls.Add(lbl_clickingPos_Y);
            gp_clickPos.Controls.Add(nud_X);
            gp_clickPos.Controls.Add(lbl_clickingPos_X);
            gp_clickPos.Controls.Add(rb_XY);
            gp_clickPos.Controls.Add(rb_currentPos);
            gp_clickPos.Location = new Point(12, 109);
            gp_clickPos.Name = "gp_clickPos";
            gp_clickPos.Size = new Size(564, 86);
            gp_clickPos.TabIndex = 9;
            gp_clickPos.TabStop = false;
            gp_clickPos.Text = "Clicking Position";
            // 
            // btn_pickLocation
            // 
            btn_pickLocation.Location = new Point(284, 51);
            btn_pickLocation.Name = "btn_pickLocation";
            btn_pickLocation.Size = new Size(104, 25);
            btn_pickLocation.TabIndex = 6;
            btn_pickLocation.Text = "Pick Location";
            btn_pickLocation.UseVisualStyleBackColor = true;
            btn_pickLocation.Click += btn_pickLocation_Click;
            // 
            // nud_Y
            // 
            nud_Y.Location = new Point(171, 52);
            nud_Y.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Y.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nud_Y.Name = "nud_Y";
            nud_Y.Size = new Size(107, 23);
            nud_Y.TabIndex = 5;
            // 
            // lbl_clickingPos_Y
            // 
            lbl_clickingPos_Y.Location = new Point(157, 55);
            lbl_clickingPos_Y.Name = "lbl_clickingPos_Y";
            lbl_clickingPos_Y.Size = new Size(23, 23);
            lbl_clickingPos_Y.TabIndex = 4;
            lbl_clickingPos_Y.Text = "Y";
            // 
            // nud_X
            // 
            nud_X.Location = new Point(44, 52);
            nud_X.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_X.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nud_X.Name = "nud_X";
            nud_X.Size = new Size(107, 23);
            nud_X.TabIndex = 3;
            // 
            // lbl_clickingPos_X
            // 
            lbl_clickingPos_X.Location = new Point(26, 55);
            lbl_clickingPos_X.Name = "lbl_clickingPos_X";
            lbl_clickingPos_X.Size = new Size(18, 23);
            lbl_clickingPos_X.TabIndex = 2;
            lbl_clickingPos_X.Text = "X";
            // 
            // rb_XY
            // 
            rb_XY.Location = new Point(10, 51);
            rb_XY.Name = "rb_XY";
            rb_XY.Size = new Size(104, 24);
            rb_XY.TabIndex = 1;
            rb_XY.TabStop = true;
            rb_XY.UseVisualStyleBackColor = true;
            // 
            // rb_currentPos
            // 
            rb_currentPos.Location = new Point(10, 22);
            rb_currentPos.Name = "rb_currentPos";
            rb_currentPos.Size = new Size(156, 24);
            rb_currentPos.TabIndex = 0;
            rb_currentPos.TabStop = true;
            rb_currentPos.Text = "Current Cursor Position";
            rb_currentPos.UseVisualStyleBackColor = true;
            // 
            // flp_delay
            // 
            flp_delay.AutoSize = true;
            flp_delay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp_delay.Controls.Add(nud_delay_h);
            flp_delay.Controls.Add(lbl_h);
            flp_delay.Controls.Add(nud_delay_min);
            flp_delay.Controls.Add(lbl_min);
            flp_delay.Controls.Add(nud_delay_sec);
            flp_delay.Controls.Add(lbl_s);
            flp_delay.Controls.Add(nud_delay_ms);
            flp_delay.Controls.Add(lbl_ms);
            flp_delay.Dock = DockStyle.Fill;
            flp_delay.Location = new Point(3, 19);
            flp_delay.Name = "flp_delay";
            flp_delay.Padding = new Padding(10);
            flp_delay.Size = new Size(564, 52);
            flp_delay.TabIndex = 0;
            flp_delay.WrapContents = false;
            // 
            // nud_delay_h
            // 
            nud_delay_h.Location = new Point(13, 13);
            nud_delay_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_delay_h.Name = "nud_delay_h";
            nud_delay_h.Size = new Size(100, 23);
            nud_delay_h.TabIndex = 0;
            // 
            // lbl_h
            // 
            lbl_h.AutoSize = true;
            lbl_h.Location = new Point(119, 18);
            lbl_h.Margin = new Padding(3, 8, 10, 3);
            lbl_h.Name = "lbl_h";
            lbl_h.Size = new Size(14, 15);
            lbl_h.TabIndex = 1;
            lbl_h.Text = "h";
            // 
            // nud_delay_min
            // 
            nud_delay_min.Location = new Point(146, 13);
            nud_delay_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_delay_min.Name = "nud_delay_min";
            nud_delay_min.Size = new Size(100, 23);
            nud_delay_min.TabIndex = 2;
            // 
            // lbl_min
            // 
            lbl_min.AutoSize = true;
            lbl_min.Location = new Point(252, 18);
            lbl_min.Margin = new Padding(3, 8, 10, 3);
            lbl_min.Name = "lbl_min";
            lbl_min.Size = new Size(28, 15);
            lbl_min.TabIndex = 3;
            lbl_min.Text = "min";
            // 
            // nud_delay_sec
            // 
            nud_delay_sec.Location = new Point(293, 13);
            nud_delay_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_delay_sec.Name = "nud_delay_sec";
            nud_delay_sec.Size = new Size(100, 23);
            nud_delay_sec.TabIndex = 4;
            // 
            // lbl_s
            // 
            lbl_s.AutoSize = true;
            lbl_s.Location = new Point(399, 18);
            lbl_s.Margin = new Padding(3, 8, 10, 3);
            lbl_s.Name = "lbl_s";
            lbl_s.Size = new Size(12, 15);
            lbl_s.TabIndex = 5;
            lbl_s.Text = "s";
            // 
            // nud_delay_ms
            // 
            nud_delay_ms.Location = new Point(424, 13);
            nud_delay_ms.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_delay_ms.Name = "nud_delay_ms";
            nud_delay_ms.Size = new Size(100, 23);
            nud_delay_ms.TabIndex = 6;
            // 
            // lbl_ms
            // 
            lbl_ms.AutoSize = true;
            lbl_ms.Location = new Point(530, 18);
            lbl_ms.Margin = new Padding(3, 8, 10, 3);
            lbl_ms.Name = "lbl_ms";
            lbl_ms.Size = new Size(23, 15);
            lbl_ms.TabIndex = 7;
            lbl_ms.Text = "ms";
            // 
            // gb_delay
            // 
            gb_delay.Controls.Add(flp_delay);
            gb_delay.Location = new Point(13, 13);
            gb_delay.Name = "gb_delay";
            gb_delay.Size = new Size(570, 74);
            gb_delay.TabIndex = 10;
            gb_delay.TabStop = false;
            gb_delay.Text = "Delay (before next click)";
            // 
            // gp_options
            // 
            gp_options.Controls.Add(cb_clickType);
            gp_options.Controls.Add(lbl_clickType);
            gp_options.Controls.Add(lbl_mouseButton);
            gp_options.Controls.Add(cb_mouseButton);
            gp_options.Location = new Point(12, 6);
            gp_options.Name = "gp_options";
            gp_options.Size = new Size(564, 97);
            gp_options.TabIndex = 11;
            gp_options.TabStop = false;
            gp_options.Text = "Click Options";
            // 
            // cb_clickType
            // 
            cb_clickType.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_clickType.FormattingEnabled = true;
            cb_clickType.Location = new Point(107, 56);
            cb_clickType.Name = "cb_clickType";
            cb_clickType.Size = new Size(139, 23);
            cb_clickType.TabIndex = 3;
            cb_clickType.SelectionChangeCommitted += cb_clickType_SelectionChangeCommitted;
            // 
            // lbl_clickType
            // 
            lbl_clickType.Location = new Point(12, 59);
            lbl_clickType.Name = "lbl_clickType";
            lbl_clickType.Size = new Size(86, 16);
            lbl_clickType.TabIndex = 2;
            lbl_clickType.Text = "Click Type";
            // 
            // lbl_mouseButton
            // 
            lbl_mouseButton.Location = new Point(9, 27);
            lbl_mouseButton.Name = "lbl_mouseButton";
            lbl_mouseButton.Size = new Size(92, 16);
            lbl_mouseButton.TabIndex = 1;
            lbl_mouseButton.Text = "Mouse Button";
            // 
            // cb_mouseButton
            // 
            cb_mouseButton.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mouseButton.FormattingEnabled = true;
            cb_mouseButton.Items.AddRange(new object[] { "Left", "Right", "Middle" });
            cb_mouseButton.Location = new Point(107, 24);
            cb_mouseButton.Name = "cb_mouseButton";
            cb_mouseButton.Size = new Size(139, 23);
            cb_mouseButton.TabIndex = 0;
            // 
            // gb_duration
            // 
            gb_duration.Controls.Add(flp_duration);
            gb_duration.Location = new Point(12, 201);
            gb_duration.Name = "gb_duration";
            gb_duration.Size = new Size(570, 74);
            gb_duration.TabIndex = 11;
            gb_duration.TabStop = false;
            gb_duration.Text = "Duration (Only for ClickType = Holding)";
            // 
            // flp_duration
            // 
            flp_duration.AutoSize = true;
            flp_duration.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp_duration.Controls.Add(nud_duration_h);
            flp_duration.Controls.Add(label1);
            flp_duration.Controls.Add(nud_duration_min);
            flp_duration.Controls.Add(label2);
            flp_duration.Controls.Add(nud_duration_sec);
            flp_duration.Controls.Add(label3);
            flp_duration.Controls.Add(nud_duration_ms);
            flp_duration.Controls.Add(label4);
            flp_duration.Dock = DockStyle.Fill;
            flp_duration.Location = new Point(3, 19);
            flp_duration.Name = "flp_duration";
            flp_duration.Padding = new Padding(10);
            flp_duration.Size = new Size(564, 52);
            flp_duration.TabIndex = 0;
            flp_duration.WrapContents = false;
            // 
            // nud_duration_h
            // 
            nud_duration_h.Location = new Point(13, 13);
            nud_duration_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_duration_h.Name = "nud_duration_h";
            nud_duration_h.Size = new Size(100, 23);
            nud_duration_h.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 18);
            label1.Margin = new Padding(3, 8, 10, 3);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 1;
            label1.Text = "h";
            // 
            // nud_duration_min
            // 
            nud_duration_min.Location = new Point(146, 13);
            nud_duration_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_duration_min.Name = "nud_duration_min";
            nud_duration_min.Size = new Size(100, 23);
            nud_duration_min.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 18);
            label2.Margin = new Padding(3, 8, 10, 3);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "min";
            // 
            // nud_duration_sec
            // 
            nud_duration_sec.Location = new Point(293, 13);
            nud_duration_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_duration_sec.Name = "nud_duration_sec";
            nud_duration_sec.Size = new Size(100, 23);
            nud_duration_sec.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 18);
            label3.Margin = new Padding(3, 8, 10, 3);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 5;
            label3.Text = "s";
            // 
            // nud_duration_ms
            // 
            nud_duration_ms.Location = new Point(424, 13);
            nud_duration_ms.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_duration_ms.Name = "nud_duration_ms";
            nud_duration_ms.Size = new Size(100, 23);
            nud_duration_ms.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 18);
            label4.Margin = new Padding(3, 8, 10, 3);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 7;
            label4.Text = "ms";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(13, 93);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(596, 314);
            tabControl.TabIndex = 12;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gb_duration);
            tabPage1.Controls.Add(gp_options);
            tabPage1.Controls.Add(gp_clickPos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(588, 286);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mouse";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbl_key);
            tabPage2.Controls.Add(tb_key);
            tabPage2.Controls.Add(gp_keyDown);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(588, 286);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Keyboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_key
            // 
            lbl_key.AutoSize = true;
            lbl_key.Location = new Point(12, 26);
            lbl_key.Name = "lbl_key";
            lbl_key.Size = new Size(26, 15);
            lbl_key.TabIndex = 2;
            lbl_key.Text = "Key";
            // 
            // tb_key
            // 
            tb_key.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_key.Location = new Point(44, 23);
            tb_key.Name = "tb_key";
            tb_key.PlaceholderText = "Press key";
            tb_key.ReadOnly = true;
            tb_key.Size = new Size(144, 23);
            tb_key.TabIndex = 1;
            tb_key.KeyDown += tb_key_KeyDown;
            // 
            // gp_keyDown
            // 
            gp_keyDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gp_keyDown.Controls.Add(rb_keyUp);
            gp_keyDown.Controls.Add(rb_keyDown);
            gp_keyDown.Location = new Point(6, 62);
            gp_keyDown.Name = "gp_keyDown";
            gp_keyDown.Size = new Size(576, 78);
            gp_keyDown.TabIndex = 0;
            gp_keyDown.TabStop = false;
            gp_keyDown.Text = "Action";
            // 
            // rb_keyUp
            // 
            rb_keyUp.AutoSize = true;
            rb_keyUp.Location = new Point(12, 47);
            rb_keyUp.Name = "rb_keyUp";
            rb_keyUp.Size = new Size(62, 19);
            rb_keyUp.TabIndex = 1;
            rb_keyUp.Text = "Key Up";
            rb_keyUp.UseVisualStyleBackColor = true;
            // 
            // rb_keyDown
            // 
            rb_keyDown.AutoSize = true;
            rb_keyDown.Checked = true;
            rb_keyDown.Location = new Point(12, 22);
            rb_keyDown.Name = "rb_keyDown";
            rb_keyDown.Size = new Size(78, 19);
            rb_keyDown.TabIndex = 0;
            rb_keyDown.TabStop = true;
            rb_keyDown.Text = "Key Down";
            rb_keyDown.UseVisualStyleBackColor = true;
            // 
            // ClickEditorForm
            // 
            AcceptButton = btn_ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(613, 448);
            Controls.Add(gb_delay);
            Controls.Add(tabControl);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(629, 487);
            MinimizeBox = false;
            MinimumSize = new Size(629, 487);
            Name = "ClickEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClickEditorForm";
            gp_clickPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_X).EndInit();
            flp_delay.ResumeLayout(false);
            flp_delay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_delay_h).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_delay_ms).EndInit();
            gb_delay.ResumeLayout(false);
            gb_delay.PerformLayout();
            gp_options.ResumeLayout(false);
            gb_duration.ResumeLayout(false);
            gb_duration.PerformLayout();
            flp_duration.ResumeLayout(false);
            flp_duration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_duration_h).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration_ms).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            gp_keyDown.ResumeLayout(false);
            gp_keyDown.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ok;
        private Button btn_cancel;
        private GroupBox gp_clickPos;
        private Button btn_pickLocation;
        private CustomComponents.NumericUpDownNoScroll nud_Y;
        private Label lbl_clickingPos_Y;
        private CustomComponents.NumericUpDownNoScroll nud_X;
        private Label lbl_clickingPos_X;
        private RadioButton rb_XY;
        private RadioButton rb_currentPos;
        private FlowLayoutPanel flp_delay;
        private CustomComponents.NumericUpDownNoScroll nud_delay_h;
        private Label lbl_h;
        private CustomComponents.NumericUpDownNoScroll nud_delay_min;
        private Label lbl_min;
        private CustomComponents.NumericUpDownNoScroll nud_delay_sec;
        private Label lbl_s;
        private CustomComponents.NumericUpDownNoScroll nud_delay_ms;
        private GroupBox gb_delay;
        private Label lbl_ms;
        private GroupBox gp_options;
        private ComboBox cb_clickType;
        private Label lbl_clickType;
        private Label lbl_mouseButton;
        private ComboBox cb_mouseButton;
        private GroupBox gb_duration;
        private FlowLayoutPanel flp_duration;
        private CustomComponents.NumericUpDownNoScroll nud_duration_h;
        private Label label1;
        private CustomComponents.NumericUpDownNoScroll nud_duration_min;
        private Label label2;
        private CustomComponents.NumericUpDownNoScroll nud_duration_sec;
        private Label label3;
        private CustomComponents.NumericUpDownNoScroll nud_duration_ms;
        private Label label4;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox gp_keyDown;
        private TextBox tb_key;
        private Label lbl_key;
        private RadioButton rb_keyUp;
        private RadioButton rb_keyDown;
    }
}