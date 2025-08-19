namespace OpenClicker;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        gp_interval = new GroupBox();
        nup_sec = new NumericUpDown();
        nup_min = new NumericUpDown();
        nup_hours = new NumericUpDown();
        nup_mili = new NumericUpDown();
        lb_msec = new Label();
        lb_sec = new Label();
        lb_Minutes = new Label();
        lb_Hours = new Label();
        gp_repeat = new GroupBox();
        nup_times = new NumericUpDown();
        label1 = new Label();
        rb_times = new RadioButton();
        rb_infinite = new RadioButton();
        btn_start = new Button();
        btn_stop = new Button();
        gp_options = new GroupBox();
        cb_clickType = new ComboBox();
        lbl_clickType = new Label();
        lbl_mouseButton = new Label();
        cb_mouseButton = new ComboBox();
        gp_delay = new GroupBox();
        nup_delay_sec = new NumericUpDown();
        nup_delay_min = new NumericUpDown();
        nup_delay_h = new NumericUpDown();
        nup_delay_mili = new NumericUpDown();
        lbl_delay_mili = new Label();
        lbl_delay_sec = new Label();
        lbl_delay_min = new Label();
        lbl_delay_h = new Label();
        pb_progress = new ProgressBar();
        gp_duration = new GroupBox();
        nup_duration_sec = new NumericUpDown();
        nup_duration_min = new NumericUpDown();
        nup_duration_h = new NumericUpDown();
        nup_duration_mili = new NumericUpDown();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        gp_clickPos = new GroupBox();
        btn_pickLocation = new Button();
        nup_clickingPos_Y = new NumericUpDown();
        lbl_clickingPos_Y = new Label();
        nup_clickingPos_X = new NumericUpDown();
        lbl_clickingPos_X = new Label();
        rb_XY = new RadioButton();
        rb_currentPos = new RadioButton();
        gp_interval.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_hours).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_mili).BeginInit();
        gp_repeat.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_times).BeginInit();
        gp_options.SuspendLayout();
        gp_delay.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_delay_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_h).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_mili).BeginInit();
        gp_duration.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_duration_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_h).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_mili).BeginInit();
        gp_clickPos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_X).BeginInit();
        SuspendLayout();
        // 
        // gp_interval
        // 
        gp_interval.Controls.Add(nup_sec);
        gp_interval.Controls.Add(nup_min);
        gp_interval.Controls.Add(nup_hours);
        gp_interval.Controls.Add(nup_mili);
        gp_interval.Controls.Add(lb_msec);
        gp_interval.Controls.Add(lb_sec);
        gp_interval.Controls.Add(lb_Minutes);
        gp_interval.Controls.Add(lb_Hours);
        gp_interval.Location = new Point(12, 12);
        gp_interval.Name = "gp_interval";
        gp_interval.Size = new Size(489, 62);
        gp_interval.TabIndex = 0;
        gp_interval.TabStop = false;
        gp_interval.Text = "Click Interval";
        // 
        // nup_sec
        // 
        nup_sec.Location = new Point(222, 25);
        nup_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_sec.Name = "nup_sec";
        nup_sec.Size = new Size(54, 23);
        nup_sec.TabIndex = 11;
        nup_sec.KeyPress += nup_KeyPress;
        // 
        // nup_min
        // 
        nup_min.Location = new Point(111, 25);
        nup_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_min.Name = "nup_min";
        nup_min.Size = new Size(54, 23);
        nup_min.TabIndex = 10;
        nup_min.KeyPress += nup_KeyPress;
        // 
        // nup_hours
        // 
        nup_hours.Location = new Point(10, 25);
        nup_hours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_hours.Name = "nup_hours";
        nup_hours.Size = new Size(54, 23);
        nup_hours.TabIndex = 9;
        nup_hours.KeyPress += nup_KeyPress;
        // 
        // nup_mili
        // 
        nup_mili.Location = new Point(342, 25);
        nup_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_mili.Name = "nup_mili";
        nup_mili.Size = new Size(54, 23);
        nup_mili.TabIndex = 8;
        nup_mili.KeyPress += nup_KeyPress;
        // 
        // lb_msec
        // 
        lb_msec.Location = new Point(402, 27);
        lb_msec.Name = "lb_msec";
        lb_msec.Size = new Size(73, 16);
        lb_msec.TabIndex = 7;
        lb_msec.Text = "Milliseconds";
        // 
        // lb_sec
        // 
        lb_sec.Location = new Point(282, 27);
        lb_sec.Name = "lb_sec";
        lb_sec.Size = new Size(54, 16);
        lb_sec.TabIndex = 6;
        lb_sec.Text = "Seconds";
        // 
        // lb_Minutes
        // 
        lb_Minutes.Location = new Point(171, 28);
        lb_Minutes.Name = "lb_Minutes";
        lb_Minutes.Size = new Size(54, 16);
        lb_Minutes.TabIndex = 5;
        lb_Minutes.Text = "Minutes";
        // 
        // lb_Hours
        // 
        lb_Hours.Location = new Point(70, 27);
        lb_Hours.Name = "lb_Hours";
        lb_Hours.Size = new Size(39, 16);
        lb_Hours.TabIndex = 1;
        lb_Hours.Text = "Hours";
        // 
        // gp_repeat
        // 
        gp_repeat.Controls.Add(nup_times);
        gp_repeat.Controls.Add(label1);
        gp_repeat.Controls.Add(rb_times);
        gp_repeat.Controls.Add(rb_infinite);
        gp_repeat.Location = new Point(12, 80);
        gp_repeat.Name = "gp_repeat";
        gp_repeat.Size = new Size(264, 97);
        gp_repeat.TabIndex = 1;
        gp_repeat.TabStop = false;
        gp_repeat.Text = "Click Repeat";
        // 
        // nup_times
        // 
        nup_times.Location = new Point(33, 57);
        nup_times.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
        nup_times.Name = "nup_times";
        nup_times.Size = new Size(53, 23);
        nup_times.TabIndex = 4;
        nup_times.KeyPress += nup_KeyPress;
        // 
        // label1
        // 
        label1.Location = new Point(92, 59);
        label1.Name = "label1";
        label1.Size = new Size(56, 19);
        label1.TabIndex = 3;
        label1.Text = "Times";
        // 
        // rb_times
        // 
        rb_times.Location = new Point(10, 52);
        rb_times.Name = "rb_times";
        rb_times.Size = new Size(124, 29);
        rb_times.TabIndex = 1;
        rb_times.TabStop = true;
        rb_times.UseVisualStyleBackColor = true;
        // 
        // rb_infinite
        // 
        rb_infinite.Location = new Point(10, 22);
        rb_infinite.Name = "rb_infinite";
        rb_infinite.Size = new Size(146, 24);
        rb_infinite.TabIndex = 0;
        rb_infinite.TabStop = true;
        rb_infinite.Text = "Infinite (Until stopped)";
        rb_infinite.UseVisualStyleBackColor = true;
        // 
        // btn_start
        // 
        btn_start.Location = new Point(12, 413);
        btn_start.Name = "btn_start";
        btn_start.Size = new Size(64, 25);
        btn_start.TabIndex = 2;
        btn_start.Text = "Start";
        btn_start.UseVisualStyleBackColor = true;
        btn_start.Click += btn_start_Click;
        // 
        // btn_stop
        // 
        btn_stop.Location = new Point(82, 413);
        btn_stop.Name = "btn_stop";
        btn_stop.Size = new Size(64, 25);
        btn_stop.TabIndex = 3;
        btn_stop.Text = "Stop";
        btn_stop.UseVisualStyleBackColor = true;
        btn_stop.Click += btn_stop_Click;
        // 
        // gp_options
        // 
        gp_options.Controls.Add(cb_clickType);
        gp_options.Controls.Add(lbl_clickType);
        gp_options.Controls.Add(lbl_mouseButton);
        gp_options.Controls.Add(cb_mouseButton);
        gp_options.Location = new Point(282, 80);
        gp_options.Name = "gp_options";
        gp_options.Size = new Size(219, 97);
        gp_options.TabIndex = 4;
        gp_options.TabStop = false;
        gp_options.Text = "Click Options";
        // 
        // cb_clickType
        // 
        cb_clickType.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_clickType.FormattingEnabled = true;
        cb_clickType.Location = new Point(107, 56);
        cb_clickType.Name = "cb_clickType";
        cb_clickType.Size = new Size(67, 23);
        cb_clickType.TabIndex = 3;
        cb_clickType.SelectedIndexChanged += cb_clickType_SelectedIndexChanged;
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
        cb_mouseButton.Size = new Size(67, 23);
        cb_mouseButton.TabIndex = 0;
        cb_mouseButton.SelectedIndexChanged += cb_mouseButton_SelectedIndexChanged;
        // 
        // gp_delay
        // 
        gp_delay.Controls.Add(nup_delay_sec);
        gp_delay.Controls.Add(nup_delay_min);
        gp_delay.Controls.Add(nup_delay_h);
        gp_delay.Controls.Add(nup_delay_mili);
        gp_delay.Controls.Add(lbl_delay_mili);
        gp_delay.Controls.Add(lbl_delay_sec);
        gp_delay.Controls.Add(lbl_delay_min);
        gp_delay.Controls.Add(lbl_delay_h);
        gp_delay.Location = new Point(12, 183);
        gp_delay.Name = "gp_delay";
        gp_delay.Size = new Size(489, 62);
        gp_delay.TabIndex = 5;
        gp_delay.TabStop = false;
        gp_delay.Text = "Starting Delay";
        // 
        // nup_delay_sec
        // 
        nup_delay_sec.Location = new Point(222, 25);
        nup_delay_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_sec.Name = "nup_delay_sec";
        nup_delay_sec.Size = new Size(54, 23);
        nup_delay_sec.TabIndex = 11;
        nup_delay_sec.KeyPress += nup_KeyPress;
        // 
        // nup_delay_min
        // 
        nup_delay_min.Location = new Point(111, 25);
        nup_delay_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_min.Name = "nup_delay_min";
        nup_delay_min.Size = new Size(54, 23);
        nup_delay_min.TabIndex = 10;
        nup_delay_min.KeyPress += nup_KeyPress;
        // 
        // nup_delay_h
        // 
        nup_delay_h.Location = new Point(10, 25);
        nup_delay_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_h.Name = "nup_delay_h";
        nup_delay_h.Size = new Size(54, 23);
        nup_delay_h.TabIndex = 9;
        nup_delay_h.KeyPress += nup_KeyPress;
        // 
        // nup_delay_mili
        // 
        nup_delay_mili.Location = new Point(342, 25);
        nup_delay_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_mili.Name = "nup_delay_mili";
        nup_delay_mili.Size = new Size(54, 23);
        nup_delay_mili.TabIndex = 8;
        nup_delay_mili.KeyPress += nup_KeyPress;
        // 
        // lbl_delay_mili
        // 
        lbl_delay_mili.Location = new Point(402, 27);
        lbl_delay_mili.Name = "lbl_delay_mili";
        lbl_delay_mili.Size = new Size(73, 16);
        lbl_delay_mili.TabIndex = 7;
        lbl_delay_mili.Text = "Milliseconds";
        // 
        // lbl_delay_sec
        // 
        lbl_delay_sec.Location = new Point(282, 27);
        lbl_delay_sec.Name = "lbl_delay_sec";
        lbl_delay_sec.Size = new Size(54, 16);
        lbl_delay_sec.TabIndex = 6;
        lbl_delay_sec.Text = "Seconds";
        // 
        // lbl_delay_min
        // 
        lbl_delay_min.Location = new Point(171, 28);
        lbl_delay_min.Name = "lbl_delay_min";
        lbl_delay_min.Size = new Size(54, 16);
        lbl_delay_min.TabIndex = 5;
        lbl_delay_min.Text = "Minutes";
        // 
        // lbl_delay_h
        // 
        lbl_delay_h.Location = new Point(70, 27);
        lbl_delay_h.Name = "lbl_delay_h";
        lbl_delay_h.Size = new Size(39, 16);
        lbl_delay_h.TabIndex = 1;
        lbl_delay_h.Text = "Hours";
        // 
        // pb_progress
        // 
        pb_progress.AccessibleDescription = "";
        pb_progress.Location = new Point(152, 413);
        pb_progress.Name = "pb_progress";
        pb_progress.Size = new Size(349, 25);
        pb_progress.TabIndex = 6;
        // 
        // gp_duration
        // 
        gp_duration.Controls.Add(nup_duration_sec);
        gp_duration.Controls.Add(nup_duration_min);
        gp_duration.Controls.Add(nup_duration_h);
        gp_duration.Controls.Add(nup_duration_mili);
        gp_duration.Controls.Add(label2);
        gp_duration.Controls.Add(label3);
        gp_duration.Controls.Add(label4);
        gp_duration.Controls.Add(label5);
        gp_duration.Location = new Point(12, 251);
        gp_duration.Name = "gp_duration";
        gp_duration.Size = new Size(489, 62);
        gp_duration.TabIndex = 7;
        gp_duration.TabStop = false;
        gp_duration.Text = "Duration (Only for Click Type = Holding)";
        // 
        // nup_duration_sec
        // 
        nup_duration_sec.Location = new Point(222, 25);
        nup_duration_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_sec.Name = "nup_duration_sec";
        nup_duration_sec.Size = new Size(54, 23);
        nup_duration_sec.TabIndex = 11;
        nup_duration_sec.KeyPress += nup_KeyPress;
        // 
        // nup_duration_min
        // 
        nup_duration_min.Location = new Point(111, 25);
        nup_duration_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_min.Name = "nup_duration_min";
        nup_duration_min.Size = new Size(54, 23);
        nup_duration_min.TabIndex = 10;
        nup_duration_min.KeyPress += nup_KeyPress;
        // 
        // nup_duration_h
        // 
        nup_duration_h.Location = new Point(10, 25);
        nup_duration_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_h.Name = "nup_duration_h";
        nup_duration_h.Size = new Size(54, 23);
        nup_duration_h.TabIndex = 9;
        nup_duration_h.KeyPress += nup_KeyPress;
        // 
        // nup_duration_mili
        // 
        nup_duration_mili.Location = new Point(342, 25);
        nup_duration_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_mili.Name = "nup_duration_mili";
        nup_duration_mili.Size = new Size(54, 23);
        nup_duration_mili.TabIndex = 8;
        nup_duration_mili.KeyPress += nup_KeyPress;
        // 
        // label2
        // 
        label2.Location = new Point(402, 27);
        label2.Name = "label2";
        label2.Size = new Size(73, 16);
        label2.TabIndex = 7;
        label2.Text = "Milliseconds";
        // 
        // label3
        // 
        label3.Location = new Point(282, 27);
        label3.Name = "label3";
        label3.Size = new Size(54, 16);
        label3.TabIndex = 6;
        label3.Text = "Seconds";
        // 
        // label4
        // 
        label4.Location = new Point(171, 28);
        label4.Name = "label4";
        label4.Size = new Size(54, 16);
        label4.TabIndex = 5;
        label4.Text = "Minutes";
        // 
        // label5
        // 
        label5.Location = new Point(70, 27);
        label5.Name = "label5";
        label5.Size = new Size(39, 16);
        label5.TabIndex = 1;
        label5.Text = "Hours";
        // 
        // gp_clickPos
        // 
        gp_clickPos.Controls.Add(btn_pickLocation);
        gp_clickPos.Controls.Add(nup_clickingPos_Y);
        gp_clickPos.Controls.Add(lbl_clickingPos_Y);
        gp_clickPos.Controls.Add(nup_clickingPos_X);
        gp_clickPos.Controls.Add(lbl_clickingPos_X);
        gp_clickPos.Controls.Add(rb_XY);
        gp_clickPos.Controls.Add(rb_currentPos);
        gp_clickPos.Location = new Point(15, 321);
        gp_clickPos.Name = "gp_clickPos";
        gp_clickPos.Size = new Size(485, 86);
        gp_clickPos.TabIndex = 8;
        gp_clickPos.TabStop = false;
        gp_clickPos.Text = "Clicking Position";
        // 
        // btn_pickLocation
        // 
        btn_pickLocation.Location = new Point(222, 52);
        btn_pickLocation.Name = "btn_pickLocation";
        btn_pickLocation.Size = new Size(104, 25);
        btn_pickLocation.TabIndex = 6;
        btn_pickLocation.Text = "Pick Location";
        btn_pickLocation.UseVisualStyleBackColor = true;
        btn_pickLocation.Click += btn_pickLocation_Click;
        // 
        // nup_clickingPos_Y
        // 
        nup_clickingPos_Y.Location = new Point(143, 52);
        nup_clickingPos_Y.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nup_clickingPos_Y.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
        nup_clickingPos_Y.Name = "nup_clickingPos_Y";
        nup_clickingPos_Y.Size = new Size(73, 23);
        nup_clickingPos_Y.TabIndex = 5;
        nup_clickingPos_Y.KeyPress += nup_KeyPress;
        // 
        // lbl_clickingPos_Y
        // 
        lbl_clickingPos_Y.Location = new Point(126, 55);
        lbl_clickingPos_Y.Name = "lbl_clickingPos_Y";
        lbl_clickingPos_Y.Size = new Size(23, 23);
        lbl_clickingPos_Y.TabIndex = 4;
        lbl_clickingPos_Y.Text = "Y";
        // 
        // nup_clickingPos_X
        // 
        nup_clickingPos_X.Location = new Point(44, 52);
        nup_clickingPos_X.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nup_clickingPos_X.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
        nup_clickingPos_X.Name = "nup_clickingPos_X";
        nup_clickingPos_X.Size = new Size(72, 23);
        nup_clickingPos_X.TabIndex = 3;
        nup_clickingPos_X.KeyPress += nup_KeyPress;
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
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(507, 450);
        Controls.Add(gp_clickPos);
        Controls.Add(gp_duration);
        Controls.Add(pb_progress);
        Controls.Add(gp_delay);
        Controls.Add(gp_options);
        Controls.Add(btn_stop);
        Controls.Add(btn_start);
        Controls.Add(gp_repeat);
        Controls.Add(gp_interval);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximumSize = new Size(523, 489);
        MinimumSize = new Size(523, 489);
        Name = "Main";
        Text = "OpenClicker";
        Load += Main_Load;
        gp_interval.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_hours).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_mili).EndInit();
        gp_repeat.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_times).EndInit();
        gp_options.ResumeLayout(false);
        gp_delay.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_delay_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_h).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_mili).EndInit();
        gp_duration.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_duration_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_h).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_mili).EndInit();
        gp_clickPos.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_X).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_pickLocation;

    private System.Windows.Forms.NumericUpDown nup_clickingPos_Y;

    private System.Windows.Forms.Label lbl_clickingPos_X;
    private System.Windows.Forms.NumericUpDown nup_clickingPos_X;
    private System.Windows.Forms.Label lbl_clickingPos_Y;

    private System.Windows.Forms.GroupBox gp_clickPos;
    private System.Windows.Forms.RadioButton rb_currentPos;
    private System.Windows.Forms.RadioButton rb_XY;

    private System.Windows.Forms.GroupBox gp_duration;
    private System.Windows.Forms.NumericUpDown nup_duration_sec;
    private System.Windows.Forms.NumericUpDown nup_duration_min;
    private System.Windows.Forms.NumericUpDown nup_duration_h;
    private System.Windows.Forms.NumericUpDown nup_duration_mili;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.ProgressBar pb_progress;

    private System.Windows.Forms.NumericUpDown nup_delay_sec;

    private System.Windows.Forms.GroupBox gp_delay;
    private System.Windows.Forms.NumericUpDown nup_sec;
    private System.Windows.Forms.NumericUpDown nup_delay_min;
    private System.Windows.Forms.NumericUpDown nup_delay_h;
    private System.Windows.Forms.NumericUpDown nup_delay_mili;
    private System.Windows.Forms.Label lbl_delay_mili;
    private System.Windows.Forms.Label lbl_delay_sec;
    private System.Windows.Forms.Label lbl_delay_min;
    private System.Windows.Forms.Label lbl_delay_h;

    private System.Windows.Forms.ComboBox cb_clickType;

    private System.Windows.Forms.Label lbl_clickType;

    private System.Windows.Forms.Label lbl_mouseButton;

    private System.Windows.Forms.ComboBox cb_mouseButton;

    private System.Windows.Forms.GroupBox gp_options;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nup_times;

    private System.Windows.Forms.TextBox tb_times;

    private System.Windows.Forms.RadioButton rb_infinite;
    private System.Windows.Forms.RadioButton rb_times;

    private System.Windows.Forms.NumericUpDown nup_min;
    private System.Windows.Forms.NumericUpDown nup_seconds;

    private System.Windows.Forms.NumericUpDown nup_hours;

    private System.Windows.Forms.NumericUpDown nup_mili;

    private System.Windows.Forms.Button btn_stop;

    private System.Windows.Forms.Button btn_start;

    private System.Windows.Forms.GroupBox gp_repeat;

    private System.Windows.Forms.Label lb_msec;

    private System.Windows.Forms.Label lb_sec;

    private System.Windows.Forms.Label lb_Minutes;

    private System.Windows.Forms.Label lb_Hours;

    private System.Windows.Forms.GroupBox gp_interval;

    #endregion
}