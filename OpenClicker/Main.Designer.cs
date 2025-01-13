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
        gp_interval = new System.Windows.Forms.GroupBox();
        nup_sec = new System.Windows.Forms.NumericUpDown();
        nup_min = new System.Windows.Forms.NumericUpDown();
        nup_hours = new System.Windows.Forms.NumericUpDown();
        nup_mili = new System.Windows.Forms.NumericUpDown();
        lb_msec = new System.Windows.Forms.Label();
        lb_sec = new System.Windows.Forms.Label();
        lb_Minutes = new System.Windows.Forms.Label();
        lb_Hours = new System.Windows.Forms.Label();
        gp_repeat = new System.Windows.Forms.GroupBox();
        nup_times = new System.Windows.Forms.NumericUpDown();
        label1 = new System.Windows.Forms.Label();
        rb_times = new System.Windows.Forms.RadioButton();
        rb_infinite = new System.Windows.Forms.RadioButton();
        btn_start = new System.Windows.Forms.Button();
        btn_stop = new System.Windows.Forms.Button();
        gp_options = new System.Windows.Forms.GroupBox();
        cb_clickType = new System.Windows.Forms.ComboBox();
        lbl_clickType = new System.Windows.Forms.Label();
        lbl_mouseButton = new System.Windows.Forms.Label();
        cb_mouseButton = new System.Windows.Forms.ComboBox();
        gp_delay = new System.Windows.Forms.GroupBox();
        nup_delay_sec = new System.Windows.Forms.NumericUpDown();
        nup_delay_min = new System.Windows.Forms.NumericUpDown();
        nup_delay_h = new System.Windows.Forms.NumericUpDown();
        nup_delay_mili = new System.Windows.Forms.NumericUpDown();
        lbl_delay_mili = new System.Windows.Forms.Label();
        lbl_delay_sec = new System.Windows.Forms.Label();
        lbl_delay_min = new System.Windows.Forms.Label();
        lbl_delay_h = new System.Windows.Forms.Label();
        pb_progress = new System.Windows.Forms.ProgressBar();
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
        gp_interval.Location = new System.Drawing.Point(12, 12);
        gp_interval.Name = "gp_interval";
        gp_interval.Size = new System.Drawing.Size(489, 62);
        gp_interval.TabIndex = 0;
        gp_interval.TabStop = false;
        gp_interval.Text = "Click Interval";
        // 
        // nup_sec
        // 
        nup_sec.Location = new System.Drawing.Point(222, 25);
        nup_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_sec.Name = "nup_sec";
        nup_sec.Size = new System.Drawing.Size(54, 23);
        nup_sec.TabIndex = 11;
        nup_sec.KeyPress += nup_KeyPress;
        // 
        // nup_min
        // 
        nup_min.Location = new System.Drawing.Point(111, 25);
        nup_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_min.Name = "nup_min";
        nup_min.Size = new System.Drawing.Size(54, 23);
        nup_min.TabIndex = 10;
        nup_min.KeyPress += nup_KeyPress;
        // 
        // nup_hours
        // 
        nup_hours.Location = new System.Drawing.Point(10, 25);
        nup_hours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_hours.Name = "nup_hours";
        nup_hours.Size = new System.Drawing.Size(54, 23);
        nup_hours.TabIndex = 9;
        nup_hours.KeyPress += nup_KeyPress;
        // 
        // nup_mili
        // 
        nup_mili.Location = new System.Drawing.Point(342, 25);
        nup_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_mili.Name = "nup_mili";
        nup_mili.Size = new System.Drawing.Size(54, 23);
        nup_mili.TabIndex = 8;
        nup_mili.KeyPress += nup_KeyPress;
        // 
        // lb_msec
        // 
        lb_msec.Location = new System.Drawing.Point(402, 27);
        lb_msec.Name = "lb_msec";
        lb_msec.Size = new System.Drawing.Size(73, 16);
        lb_msec.TabIndex = 7;
        lb_msec.Text = "Milliseconds";
        // 
        // lb_sec
        // 
        lb_sec.Location = new System.Drawing.Point(282, 27);
        lb_sec.Name = "lb_sec";
        lb_sec.Size = new System.Drawing.Size(54, 16);
        lb_sec.TabIndex = 6;
        lb_sec.Text = "Seconds";
        // 
        // lb_Minutes
        // 
        lb_Minutes.Location = new System.Drawing.Point(171, 28);
        lb_Minutes.Name = "lb_Minutes";
        lb_Minutes.Size = new System.Drawing.Size(54, 16);
        lb_Minutes.TabIndex = 5;
        lb_Minutes.Text = "Minutes";
        // 
        // lb_Hours
        // 
        lb_Hours.Location = new System.Drawing.Point(70, 27);
        lb_Hours.Name = "lb_Hours";
        lb_Hours.Size = new System.Drawing.Size(39, 16);
        lb_Hours.TabIndex = 1;
        lb_Hours.Text = "Hours";
        // 
        // gp_repeat
        // 
        gp_repeat.Controls.Add(nup_times);
        gp_repeat.Controls.Add(label1);
        gp_repeat.Controls.Add(rb_times);
        gp_repeat.Controls.Add(rb_infinite);
        gp_repeat.Location = new System.Drawing.Point(12, 80);
        gp_repeat.Name = "gp_repeat";
        gp_repeat.Size = new System.Drawing.Size(264, 97);
        gp_repeat.TabIndex = 1;
        gp_repeat.TabStop = false;
        gp_repeat.Text = "Click Repeat";
        // 
        // nup_times
        // 
        nup_times.Location = new System.Drawing.Point(33, 57);
        nup_times.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
        nup_times.Name = "nup_times";
        nup_times.Size = new System.Drawing.Size(53, 23);
        nup_times.TabIndex = 4;
        nup_times.KeyPress += nup_KeyPress;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(92, 59);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(56, 19);
        label1.TabIndex = 3;
        label1.Text = "Times";
        // 
        // rb_times
        // 
        rb_times.Location = new System.Drawing.Point(10, 52);
        rb_times.Name = "rb_times";
        rb_times.Size = new System.Drawing.Size(124, 29);
        rb_times.TabIndex = 1;
        rb_times.TabStop = true;
        rb_times.UseVisualStyleBackColor = true;
        // 
        // rb_infinite
        // 
        rb_infinite.Location = new System.Drawing.Point(10, 22);
        rb_infinite.Name = "rb_infinite";
        rb_infinite.Size = new System.Drawing.Size(146, 24);
        rb_infinite.TabIndex = 0;
        rb_infinite.TabStop = true;
        rb_infinite.Text = "Infinite (Until stopped)";
        rb_infinite.UseVisualStyleBackColor = true;
        // 
        // btn_start
        // 
        btn_start.Location = new System.Drawing.Point(12, 413);
        btn_start.Name = "btn_start";
        btn_start.Size = new System.Drawing.Size(64, 25);
        btn_start.TabIndex = 2;
        btn_start.Text = "Start";
        btn_start.UseVisualStyleBackColor = true;
        btn_start.Click += btn_start_Click;
        // 
        // btn_stop
        // 
        btn_stop.Location = new System.Drawing.Point(82, 413);
        btn_stop.Name = "btn_stop";
        btn_stop.Size = new System.Drawing.Size(64, 25);
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
        gp_options.Location = new System.Drawing.Point(282, 80);
        gp_options.Name = "gp_options";
        gp_options.Size = new System.Drawing.Size(219, 97);
        gp_options.TabIndex = 4;
        gp_options.TabStop = false;
        gp_options.Text = "Click Options";
        // 
        // cb_clickType
        // 
        cb_clickType.FormattingEnabled = true;
        cb_clickType.Location = new System.Drawing.Point(107, 56);
        cb_clickType.Name = "cb_clickType";
        cb_clickType.Size = new System.Drawing.Size(67, 23);
        cb_clickType.TabIndex = 3;
        cb_clickType.SelectionChangeCommitted += cb_clickType_SelectionChangeCommitted;
        cb_clickType.KeyPress += cb_KeyPress;
        // 
        // lbl_clickType
        // 
        lbl_clickType.Location = new System.Drawing.Point(12, 59);
        lbl_clickType.Name = "lbl_clickType";
        lbl_clickType.Size = new System.Drawing.Size(86, 16);
        lbl_clickType.TabIndex = 2;
        lbl_clickType.Text = "Click Type";
        // 
        // lbl_mouseButton
        // 
        lbl_mouseButton.Location = new System.Drawing.Point(9, 27);
        lbl_mouseButton.Name = "lbl_mouseButton";
        lbl_mouseButton.Size = new System.Drawing.Size(92, 16);
        lbl_mouseButton.TabIndex = 1;
        lbl_mouseButton.Text = "Mouse Button";
        // 
        // cb_mouseButton
        // 
        cb_mouseButton.FormattingEnabled = true;
        cb_mouseButton.Items.AddRange(new object[] { "Left", "Right", "Middle" });
        cb_mouseButton.Location = new System.Drawing.Point(107, 24);
        cb_mouseButton.Name = "cb_mouseButton";
        cb_mouseButton.Size = new System.Drawing.Size(67, 23);
        cb_mouseButton.TabIndex = 0;
        cb_mouseButton.KeyPress += cb_KeyPress;
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
        gp_delay.Location = new System.Drawing.Point(12, 183);
        gp_delay.Name = "gp_delay";
        gp_delay.Size = new System.Drawing.Size(489, 62);
        gp_delay.TabIndex = 5;
        gp_delay.TabStop = false;
        gp_delay.Text = "Starting Delay";
        // 
        // nup_delay_sec
        // 
        nup_delay_sec.Location = new System.Drawing.Point(222, 25);
        nup_delay_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_sec.Name = "nup_delay_sec";
        nup_delay_sec.Size = new System.Drawing.Size(54, 23);
        nup_delay_sec.TabIndex = 11;
        nup_delay_sec.KeyPress += nup_KeyPress;
        // 
        // nup_delay_min
        // 
        nup_delay_min.Location = new System.Drawing.Point(111, 25);
        nup_delay_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_min.Name = "nup_delay_min";
        nup_delay_min.Size = new System.Drawing.Size(54, 23);
        nup_delay_min.TabIndex = 10;
        nup_delay_min.KeyPress += nup_KeyPress;
        // 
        // nup_delay_h
        // 
        nup_delay_h.Location = new System.Drawing.Point(10, 25);
        nup_delay_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_h.Name = "nup_delay_h";
        nup_delay_h.Size = new System.Drawing.Size(54, 23);
        nup_delay_h.TabIndex = 9;
        nup_delay_h.KeyPress += nup_KeyPress;
        // 
        // nup_delay_mili
        // 
        nup_delay_mili.Location = new System.Drawing.Point(342, 25);
        nup_delay_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_mili.Name = "nup_delay_mili";
        nup_delay_mili.Size = new System.Drawing.Size(54, 23);
        nup_delay_mili.TabIndex = 8;
        nup_delay_mili.KeyPress += nup_KeyPress;
        // 
        // lbl_delay_mili
        // 
        lbl_delay_mili.Location = new System.Drawing.Point(402, 27);
        lbl_delay_mili.Name = "lbl_delay_mili";
        lbl_delay_mili.Size = new System.Drawing.Size(73, 16);
        lbl_delay_mili.TabIndex = 7;
        lbl_delay_mili.Text = "Milliseconds";
        // 
        // lbl_delay_sec
        // 
        lbl_delay_sec.Location = new System.Drawing.Point(282, 27);
        lbl_delay_sec.Name = "lbl_delay_sec";
        lbl_delay_sec.Size = new System.Drawing.Size(54, 16);
        lbl_delay_sec.TabIndex = 6;
        lbl_delay_sec.Text = "Seconds";
        // 
        // lbl_delay_min
        // 
        lbl_delay_min.Location = new System.Drawing.Point(171, 28);
        lbl_delay_min.Name = "lbl_delay_min";
        lbl_delay_min.Size = new System.Drawing.Size(54, 16);
        lbl_delay_min.TabIndex = 5;
        lbl_delay_min.Text = "Minutes";
        // 
        // lbl_delay_h
        // 
        lbl_delay_h.Location = new System.Drawing.Point(70, 27);
        lbl_delay_h.Name = "lbl_delay_h";
        lbl_delay_h.Size = new System.Drawing.Size(39, 16);
        lbl_delay_h.TabIndex = 1;
        lbl_delay_h.Text = "Hours";
        // 
        // pb_progress
        // 
        pb_progress.Location = new System.Drawing.Point(152, 413);
        pb_progress.Name = "pb_progress";
        pb_progress.Size = new System.Drawing.Size(349, 25);
        pb_progress.TabIndex = 6;
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(515, 450);
        Controls.Add(pb_progress);
        Controls.Add(gp_delay);
        Controls.Add(gp_options);
        Controls.Add(btn_stop);
        Controls.Add(btn_start);
        Controls.Add(gp_repeat);
        Controls.Add(gp_interval);
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
        ResumeLayout(false);
    }

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