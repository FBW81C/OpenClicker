using OpenClicker.CustomComponents;

namespace OpenClicker.Forms.Main;

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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        gp_interval = new GroupBox();
        nup_interval_h = new NumericUpDownNoScroll();
        nup_interval_sec = new NumericUpDownNoScroll();
        nup_interval_min = new NumericUpDownNoScroll();
        nup_interval_ms = new NumericUpDownNoScroll();
        lb_msec = new Label();
        lb_sec = new Label();
        lb_Minutes = new Label();
        lb_Hours = new Label();
        gb_repeat = new GroupBox();
        nud_times = new NumericUpDownNoScroll();
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
        nup_delay_sec = new NumericUpDownNoScroll();
        nup_delay_min = new NumericUpDownNoScroll();
        nup_delay_h = new NumericUpDownNoScroll();
        nup_delay_ms = new NumericUpDownNoScroll();
        lbl_delay_mili = new Label();
        lbl_delay_sec = new Label();
        lbl_delay_min = new Label();
        lbl_delay_h = new Label();
        pb_progress = new ProgressBar();
        gp_duration = new GroupBox();
        nup_duration_sec = new NumericUpDownNoScroll();
        nup_duration_min = new NumericUpDownNoScroll();
        nup_duration_h = new NumericUpDownNoScroll();
        nup_duration_mili = new NumericUpDownNoScroll();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        gp_clickPos = new GroupBox();
        btn_pickLocation = new Button();
        nup_clickingPos_Y = new NumericUpDownNoScroll();
        lbl_clickingPos_Y = new Label();
        nup_clickingPos_X = new NumericUpDownNoScroll();
        lbl_clickingPos_X = new Label();
        rb_XY = new RadioButton();
        rb_currentPos = new RadioButton();
        tabControl = new TabControl();
        tabPageSingle = new TabPage();
        tabPageMultiple = new TabPage();
        btn_deleteAll = new Button();
        btn_record = new Button();
        btn_multiple_delete = new Button();
        btn_multiple_EditClick = new Button();
        dataGridView = new DataGridView();
        Type = new DataGridViewTextBoxColumn();
        delayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        Position = new DataGridViewTextBoxColumn();
        clickTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        mouseButtonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        HoldingDuration = new DataGridViewTextBoxColumn();
        Key = new DataGridViewTextBoxColumn();
        KeyDown = new DataGridViewTextBoxColumn();
        clickBindingSource = new BindingSource(components);
        btn_multiple_addClick = new Button();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        saveToolStripMenuItem = new ToolStripMenuItem();
        loadToolStripMenuItem = new ToolStripMenuItem();
        setAsDefaultToolStripMenuItem = new ToolStripMenuItem();
        setAsDefaultToolStripMenuItem1 = new ToolStripMenuItem();
        resetDefaultToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        hotkeysToolStripMenuItem = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        gitHubToolStripMenuItem = new ToolStripMenuItem();
        aboutOpenClickerToolStripMenuItem = new ToolStripMenuItem();
        gp_interval.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_interval_h).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_ms).BeginInit();
        gb_repeat.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nud_times).BeginInit();
        gp_options.SuspendLayout();
        gp_delay.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_delay_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_h).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_ms).BeginInit();
        gp_duration.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_duration_sec).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_h).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_mili).BeginInit();
        gp_clickPos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_Y).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_X).BeginInit();
        tabControl.SuspendLayout();
        tabPageSingle.SuspendLayout();
        tabPageMultiple.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)clickBindingSource).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // gp_interval
        // 
        gp_interval.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gp_interval.Controls.Add(nup_interval_h);
        gp_interval.Controls.Add(nup_interval_sec);
        gp_interval.Controls.Add(nup_interval_min);
        gp_interval.Controls.Add(nup_interval_ms);
        gp_interval.Controls.Add(lb_msec);
        gp_interval.Controls.Add(lb_sec);
        gp_interval.Controls.Add(lb_Minutes);
        gp_interval.Controls.Add(lb_Hours);
        gp_interval.Location = new Point(17, 10);
        gp_interval.Name = "gp_interval";
        gp_interval.Size = new Size(682, 62);
        gp_interval.TabIndex = 0;
        gp_interval.TabStop = false;
        gp_interval.Text = "Click Interval";
        // 
        // nup_interval_h
        // 
        nup_interval_h.Location = new Point(6, 25);
        nup_interval_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_interval_h.Name = "nup_interval_h";
        nup_interval_h.Size = new Size(100, 23);
        nup_interval_h.TabIndex = 12;
        // 
        // nup_interval_sec
        // 
        nup_interval_sec.AutoSize = true;
        nup_interval_sec.Location = new Point(328, 25);
        nup_interval_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_interval_sec.Name = "nup_interval_sec";
        nup_interval_sec.Size = new Size(100, 23);
        nup_interval_sec.TabIndex = 11;
        nup_interval_sec.KeyPress += nup_KeyPress;
        // 
        // nup_interval_min
        // 
        nup_interval_min.Location = new Point(157, 25);
        nup_interval_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_interval_min.Name = "nup_interval_min";
        nup_interval_min.Size = new Size(100, 23);
        nup_interval_min.TabIndex = 10;
        nup_interval_min.KeyPress += nup_KeyPress;
        // 
        // nup_interval_ms
        // 
        nup_interval_ms.AutoSize = true;
        nup_interval_ms.Location = new Point(494, 25);
        nup_interval_ms.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nup_interval_ms.Name = "nup_interval_ms";
        nup_interval_ms.Size = new Size(100, 23);
        nup_interval_ms.TabIndex = 8;
        nup_interval_ms.KeyPress += nup_KeyPress;
        // 
        // lb_msec
        // 
        lb_msec.Location = new Point(600, 28);
        lb_msec.Name = "lb_msec";
        lb_msec.Size = new Size(73, 16);
        lb_msec.TabIndex = 7;
        lb_msec.Text = "Milliseconds";
        // 
        // lb_sec
        // 
        lb_sec.Location = new Point(434, 28);
        lb_sec.Name = "lb_sec";
        lb_sec.Size = new Size(54, 16);
        lb_sec.TabIndex = 6;
        lb_sec.Text = "Seconds";
        // 
        // lb_Minutes
        // 
        lb_Minutes.Location = new Point(268, 28);
        lb_Minutes.Name = "lb_Minutes";
        lb_Minutes.Size = new Size(54, 16);
        lb_Minutes.TabIndex = 5;
        lb_Minutes.Text = "Minutes";
        // 
        // lb_Hours
        // 
        lb_Hours.Location = new Point(112, 28);
        lb_Hours.Name = "lb_Hours";
        lb_Hours.Size = new Size(39, 16);
        lb_Hours.TabIndex = 1;
        lb_Hours.Text = "Hours";
        // 
        // gb_repeat
        // 
        gb_repeat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gb_repeat.Controls.Add(nud_times);
        gb_repeat.Controls.Add(label1);
        gb_repeat.Controls.Add(rb_times);
        gb_repeat.Controls.Add(rb_infinite);
        gb_repeat.Location = new Point(19, 404);
        gb_repeat.Name = "gb_repeat";
        gb_repeat.Size = new Size(787, 97);
        gb_repeat.TabIndex = 1;
        gb_repeat.TabStop = false;
        gb_repeat.Text = "Click Repeat";
        // 
        // nud_times
        // 
        nud_times.Location = new Point(33, 56);
        nud_times.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
        nud_times.Name = "nud_times";
        nud_times.Size = new Size(132, 23);
        nud_times.TabIndex = 4;
        nud_times.KeyPress += nup_KeyPress;
        // 
        // label1
        // 
        label1.Location = new Point(171, 59);
        label1.Name = "label1";
        label1.Size = new Size(56, 19);
        label1.TabIndex = 3;
        label1.Text = "Times";
        // 
        // rb_times
        // 
        rb_times.Location = new Point(10, 52);
        rb_times.Name = "rb_times";
        rb_times.Size = new Size(248, 29);
        rb_times.TabIndex = 1;
        rb_times.UseVisualStyleBackColor = true;
        // 
        // rb_infinite
        // 
        rb_infinite.Checked = true;
        rb_infinite.Location = new Point(10, 22);
        rb_infinite.Name = "rb_infinite";
        rb_infinite.Size = new Size(248, 24);
        rb_infinite.TabIndex = 0;
        rb_infinite.TabStop = true;
        rb_infinite.Text = "Infinite";
        rb_infinite.UseVisualStyleBackColor = true;
        // 
        // btn_start
        // 
        btn_start.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btn_start.Location = new Point(13, 575);
        btn_start.Name = "btn_start";
        btn_start.Size = new Size(64, 25);
        btn_start.TabIndex = 2;
        btn_start.Text = "Start";
        btn_start.UseVisualStyleBackColor = true;
        btn_start.Click += btn_start_Click;
        // 
        // btn_stop
        // 
        btn_stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btn_stop.Location = new Point(83, 575);
        btn_stop.Name = "btn_stop";
        btn_stop.Size = new Size(64, 25);
        btn_stop.TabIndex = 3;
        btn_stop.Text = "Stop";
        btn_stop.UseVisualStyleBackColor = true;
        btn_stop.Click += btn_stop_Click;
        // 
        // gp_options
        // 
        gp_options.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gp_options.Controls.Add(cb_clickType);
        gp_options.Controls.Add(lbl_clickType);
        gp_options.Controls.Add(lbl_mouseButton);
        gp_options.Controls.Add(cb_mouseButton);
        gp_options.Location = new Point(17, 78);
        gp_options.Name = "gp_options";
        gp_options.Size = new Size(682, 97);
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
        cb_clickType.Size = new Size(86, 23);
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
        cb_mouseButton.Size = new Size(86, 23);
        cb_mouseButton.TabIndex = 0;
        // 
        // gp_delay
        // 
        gp_delay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gp_delay.Controls.Add(nup_delay_sec);
        gp_delay.Controls.Add(nup_delay_min);
        gp_delay.Controls.Add(nup_delay_h);
        gp_delay.Controls.Add(nup_delay_ms);
        gp_delay.Controls.Add(lbl_delay_mili);
        gp_delay.Controls.Add(lbl_delay_sec);
        gp_delay.Controls.Add(lbl_delay_min);
        gp_delay.Controls.Add(lbl_delay_h);
        gp_delay.Location = new Point(19, 507);
        gp_delay.Name = "gp_delay";
        gp_delay.Size = new Size(787, 62);
        gp_delay.TabIndex = 5;
        gp_delay.TabStop = false;
        gp_delay.Text = "Starting Delay";
        // 
        // nup_delay_sec
        // 
        nup_delay_sec.Location = new Point(327, 25);
        nup_delay_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_sec.Name = "nup_delay_sec";
        nup_delay_sec.Size = new Size(100, 23);
        nup_delay_sec.TabIndex = 11;
        nup_delay_sec.KeyPress += nup_KeyPress;
        // 
        // nup_delay_min
        // 
        nup_delay_min.Location = new Point(161, 25);
        nup_delay_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_min.Name = "nup_delay_min";
        nup_delay_min.Size = new Size(100, 23);
        nup_delay_min.TabIndex = 10;
        nup_delay_min.KeyPress += nup_KeyPress;
        // 
        // nup_delay_h
        // 
        nup_delay_h.Location = new Point(10, 25);
        nup_delay_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_h.Name = "nup_delay_h";
        nup_delay_h.Size = new Size(100, 23);
        nup_delay_h.TabIndex = 9;
        nup_delay_h.KeyPress += nup_KeyPress;
        // 
        // nup_delay_ms
        // 
        nup_delay_ms.Location = new Point(495, 25);
        nup_delay_ms.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_delay_ms.Name = "nup_delay_ms";
        nup_delay_ms.Size = new Size(100, 23);
        nup_delay_ms.TabIndex = 8;
        nup_delay_ms.KeyPress += nup_KeyPress;
        // 
        // lbl_delay_mili
        // 
        lbl_delay_mili.Location = new Point(601, 27);
        lbl_delay_mili.Name = "lbl_delay_mili";
        lbl_delay_mili.Size = new Size(73, 16);
        lbl_delay_mili.TabIndex = 7;
        lbl_delay_mili.Text = "Milliseconds";
        // 
        // lbl_delay_sec
        // 
        lbl_delay_sec.Location = new Point(435, 28);
        lbl_delay_sec.Name = "lbl_delay_sec";
        lbl_delay_sec.Size = new Size(54, 16);
        lbl_delay_sec.TabIndex = 6;
        lbl_delay_sec.Text = "Seconds";
        // 
        // lbl_delay_min
        // 
        lbl_delay_min.Location = new Point(267, 28);
        lbl_delay_min.Name = "lbl_delay_min";
        lbl_delay_min.Size = new Size(54, 16);
        lbl_delay_min.TabIndex = 5;
        lbl_delay_min.Text = "Minutes";
        // 
        // lbl_delay_h
        // 
        lbl_delay_h.Location = new Point(116, 27);
        lbl_delay_h.Name = "lbl_delay_h";
        lbl_delay_h.Size = new Size(39, 16);
        lbl_delay_h.TabIndex = 1;
        lbl_delay_h.Text = "Hours";
        // 
        // pb_progress
        // 
        pb_progress.AccessibleDescription = "";
        pb_progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pb_progress.Location = new Point(153, 575);
        pb_progress.Name = "pb_progress";
        pb_progress.Size = new Size(653, 25);
        pb_progress.TabIndex = 6;
        // 
        // gp_duration
        // 
        gp_duration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gp_duration.Controls.Add(nup_duration_sec);
        gp_duration.Controls.Add(nup_duration_min);
        gp_duration.Controls.Add(nup_duration_h);
        gp_duration.Controls.Add(nup_duration_mili);
        gp_duration.Controls.Add(label2);
        gp_duration.Controls.Add(label3);
        gp_duration.Controls.Add(label4);
        gp_duration.Controls.Add(label5);
        gp_duration.Location = new Point(17, 181);
        gp_duration.Name = "gp_duration";
        gp_duration.Size = new Size(682, 62);
        gp_duration.TabIndex = 7;
        gp_duration.TabStop = false;
        gp_duration.Text = "Duration (Only for Click Type = Holding)";
        // 
        // nup_duration_sec
        // 
        nup_duration_sec.Location = new Point(328, 25);
        nup_duration_sec.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_sec.Name = "nup_duration_sec";
        nup_duration_sec.Size = new Size(100, 23);
        nup_duration_sec.TabIndex = 11;
        nup_duration_sec.KeyPress += nup_KeyPress;
        // 
        // nup_duration_min
        // 
        nup_duration_min.Location = new Point(161, 25);
        nup_duration_min.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_min.Name = "nup_duration_min";
        nup_duration_min.Size = new Size(100, 23);
        nup_duration_min.TabIndex = 10;
        nup_duration_min.KeyPress += nup_KeyPress;
        // 
        // nup_duration_h
        // 
        nup_duration_h.Location = new Point(10, 25);
        nup_duration_h.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_h.Name = "nup_duration_h";
        nup_duration_h.Size = new Size(100, 23);
        nup_duration_h.TabIndex = 9;
        nup_duration_h.KeyPress += nup_KeyPress;
        // 
        // nup_duration_mili
        // 
        nup_duration_mili.Location = new Point(494, 26);
        nup_duration_mili.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nup_duration_mili.Name = "nup_duration_mili";
        nup_duration_mili.Size = new Size(100, 23);
        nup_duration_mili.TabIndex = 8;
        nup_duration_mili.KeyPress += nup_KeyPress;
        // 
        // label2
        // 
        label2.Location = new Point(600, 29);
        label2.Name = "label2";
        label2.Size = new Size(73, 16);
        label2.TabIndex = 7;
        label2.Text = "Milliseconds";
        // 
        // label3
        // 
        label3.Location = new Point(434, 28);
        label3.Name = "label3";
        label3.Size = new Size(54, 16);
        label3.TabIndex = 6;
        label3.Text = "Seconds";
        // 
        // label4
        // 
        label4.Location = new Point(268, 29);
        label4.Name = "label4";
        label4.Size = new Size(54, 16);
        label4.TabIndex = 5;
        label4.Text = "Minutes";
        // 
        // label5
        // 
        label5.Location = new Point(116, 29);
        label5.Name = "label5";
        label5.Size = new Size(39, 16);
        label5.TabIndex = 1;
        label5.Text = "Hours";
        // 
        // gp_clickPos
        // 
        gp_clickPos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gp_clickPos.Controls.Add(btn_pickLocation);
        gp_clickPos.Controls.Add(nup_clickingPos_Y);
        gp_clickPos.Controls.Add(lbl_clickingPos_Y);
        gp_clickPos.Controls.Add(nup_clickingPos_X);
        gp_clickPos.Controls.Add(lbl_clickingPos_X);
        gp_clickPos.Controls.Add(rb_XY);
        gp_clickPos.Controls.Add(rb_currentPos);
        gp_clickPos.Location = new Point(17, 249);
        gp_clickPos.Name = "gp_clickPos";
        gp_clickPos.Size = new Size(682, 86);
        gp_clickPos.TabIndex = 8;
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
        // nup_clickingPos_Y
        // 
        nup_clickingPos_Y.Location = new Point(171, 52);
        nup_clickingPos_Y.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nup_clickingPos_Y.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
        nup_clickingPos_Y.Name = "nup_clickingPos_Y";
        nup_clickingPos_Y.Size = new Size(107, 23);
        nup_clickingPos_Y.TabIndex = 5;
        nup_clickingPos_Y.KeyPress += nup_KeyPress;
        // 
        // lbl_clickingPos_Y
        // 
        lbl_clickingPos_Y.Location = new Point(157, 55);
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
        nup_clickingPos_X.Size = new Size(107, 23);
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
        // tabControl
        // 
        tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl.Controls.Add(tabPageSingle);
        tabControl.Controls.Add(tabPageMultiple);
        tabControl.Location = new Point(12, 26);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(794, 372);
        tabControl.TabIndex = 9;
        // 
        // tabPageSingle
        // 
        tabPageSingle.Controls.Add(gp_interval);
        tabPageSingle.Controls.Add(gp_clickPos);
        tabPageSingle.Controls.Add(gp_duration);
        tabPageSingle.Controls.Add(gp_options);
        tabPageSingle.Location = new Point(4, 24);
        tabPageSingle.Name = "tabPageSingle";
        tabPageSingle.Padding = new Padding(3);
        tabPageSingle.Size = new Size(786, 344);
        tabPageSingle.TabIndex = 0;
        tabPageSingle.Text = "Single";
        tabPageSingle.UseVisualStyleBackColor = true;
        // 
        // tabPageMultiple
        // 
        tabPageMultiple.Controls.Add(btn_deleteAll);
        tabPageMultiple.Controls.Add(btn_record);
        tabPageMultiple.Controls.Add(btn_multiple_delete);
        tabPageMultiple.Controls.Add(btn_multiple_EditClick);
        tabPageMultiple.Controls.Add(dataGridView);
        tabPageMultiple.Controls.Add(btn_multiple_addClick);
        tabPageMultiple.Location = new Point(4, 24);
        tabPageMultiple.Name = "tabPageMultiple";
        tabPageMultiple.Padding = new Padding(3);
        tabPageMultiple.Size = new Size(786, 344);
        tabPageMultiple.TabIndex = 1;
        tabPageMultiple.Text = "Multiple";
        tabPageMultiple.UseVisualStyleBackColor = true;
        // 
        // btn_deleteAll
        // 
        btn_deleteAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn_deleteAll.Location = new Point(690, 144);
        btn_deleteAll.Name = "btn_deleteAll";
        btn_deleteAll.Size = new Size(90, 40);
        btn_deleteAll.TabIndex = 8;
        btn_deleteAll.Text = "Delete All";
        btn_deleteAll.UseVisualStyleBackColor = true;
        btn_deleteAll.Click += btn_deleteAll_Click;
        // 
        // btn_record
        // 
        btn_record.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn_record.Location = new Point(690, 190);
        btn_record.Name = "btn_record";
        btn_record.Size = new Size(90, 40);
        btn_record.TabIndex = 7;
        btn_record.Text = "Record";
        btn_record.UseVisualStyleBackColor = true;
        btn_record.Click += btn_record_Click;
        // 
        // btn_multiple_delete
        // 
        btn_multiple_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn_multiple_delete.Location = new Point(690, 98);
        btn_multiple_delete.Name = "btn_multiple_delete";
        btn_multiple_delete.Size = new Size(90, 40);
        btn_multiple_delete.TabIndex = 6;
        btn_multiple_delete.Text = "Delete";
        btn_multiple_delete.UseVisualStyleBackColor = true;
        btn_multiple_delete.Click += btn_multiple_delete_Click;
        // 
        // btn_multiple_EditClick
        // 
        btn_multiple_EditClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn_multiple_EditClick.Location = new Point(690, 52);
        btn_multiple_EditClick.Name = "btn_multiple_EditClick";
        btn_multiple_EditClick.Size = new Size(90, 40);
        btn_multiple_EditClick.TabIndex = 5;
        btn_multiple_EditClick.Text = "Edit";
        btn_multiple_EditClick.UseVisualStyleBackColor = true;
        btn_multiple_EditClick.Click += btn_multiple_EditClick_Click;
        // 
        // dataGridView
        // 
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AllowUserToResizeRows = false;
        dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView.AutoGenerateColumns = false;
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] { Type, delayDataGridViewTextBoxColumn, Position, clickTypeDataGridViewTextBoxColumn, mouseButtonDataGridViewTextBoxColumn, HoldingDuration, Key, KeyDown });
        dataGridView.DataSource = clickBindingSource;
        dataGridView.Location = new Point(6, 6);
        dataGridView.Name = "dataGridView";
        dataGridView.ReadOnly = true;
        dataGridView.Size = new Size(681, 332);
        dataGridView.TabIndex = 4;
        // 
        // Type
        // 
        Type.DataPropertyName = "Type";
        Type.HeaderText = "Type";
        Type.Name = "Type";
        Type.ReadOnly = true;
        // 
        // delayDataGridViewTextBoxColumn
        // 
        delayDataGridViewTextBoxColumn.DataPropertyName = "Delay";
        delayDataGridViewTextBoxColumn.HeaderText = "Delay";
        delayDataGridViewTextBoxColumn.Name = "delayDataGridViewTextBoxColumn";
        delayDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // Position
        // 
        Position.DataPropertyName = "Position";
        Position.HeaderText = "Position";
        Position.Name = "Position";
        Position.ReadOnly = true;
        // 
        // clickTypeDataGridViewTextBoxColumn
        // 
        clickTypeDataGridViewTextBoxColumn.DataPropertyName = "ClickType";
        clickTypeDataGridViewTextBoxColumn.HeaderText = "ClickType";
        clickTypeDataGridViewTextBoxColumn.Name = "clickTypeDataGridViewTextBoxColumn";
        clickTypeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // mouseButtonDataGridViewTextBoxColumn
        // 
        mouseButtonDataGridViewTextBoxColumn.DataPropertyName = "MouseButton";
        mouseButtonDataGridViewTextBoxColumn.HeaderText = "MouseButton";
        mouseButtonDataGridViewTextBoxColumn.Name = "mouseButtonDataGridViewTextBoxColumn";
        mouseButtonDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // HoldingDuration
        // 
        HoldingDuration.DataPropertyName = "HoldingDuration";
        HoldingDuration.HeaderText = "HoldingDuration";
        HoldingDuration.Name = "HoldingDuration";
        HoldingDuration.ReadOnly = true;
        // 
        // Key
        // 
        Key.DataPropertyName = "Key";
        Key.HeaderText = "Key";
        Key.Name = "Key";
        Key.ReadOnly = true;
        // 
        // KeyDown
        // 
        KeyDown.DataPropertyName = "KeyDown";
        KeyDown.HeaderText = "KeyDown";
        KeyDown.Name = "KeyDown";
        KeyDown.ReadOnly = true;
        // 
        // clickBindingSource
        // 
        clickBindingSource.DataSource = typeof(Models.InputAction);
        // 
        // btn_multiple_addClick
        // 
        btn_multiple_addClick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btn_multiple_addClick.Location = new Point(690, 6);
        btn_multiple_addClick.Name = "btn_multiple_addClick";
        btn_multiple_addClick.Size = new Size(90, 40);
        btn_multiple_addClick.TabIndex = 1;
        btn_multiple_addClick.Text = "Add";
        btn_multiple_addClick.UseVisualStyleBackColor = true;
        btn_multiple_addClick.Click += btn_multiple_addClick_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, aboutToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(815, 24);
        menuStrip1.TabIndex = 10;
        menuStrip1.Text = "menuStrip";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, setAsDefaultToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(58, 20);
        fileToolStripMenuItem.Text = "Profiles";
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.Size = new Size(112, 22);
        saveToolStripMenuItem.Text = "Save";
        saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // loadToolStripMenuItem
        // 
        loadToolStripMenuItem.Name = "loadToolStripMenuItem";
        loadToolStripMenuItem.Size = new Size(112, 22);
        loadToolStripMenuItem.Text = "Load";
        loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
        // 
        // setAsDefaultToolStripMenuItem
        // 
        setAsDefaultToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setAsDefaultToolStripMenuItem1, resetDefaultToolStripMenuItem });
        setAsDefaultToolStripMenuItem.Name = "setAsDefaultToolStripMenuItem";
        setAsDefaultToolStripMenuItem.Size = new Size(112, 22);
        setAsDefaultToolStripMenuItem.Text = "Default";
        // 
        // setAsDefaultToolStripMenuItem1
        // 
        setAsDefaultToolStripMenuItem1.Name = "setAsDefaultToolStripMenuItem1";
        setAsDefaultToolStripMenuItem1.Size = new Size(145, 22);
        setAsDefaultToolStripMenuItem1.Text = "Set as Default";
        setAsDefaultToolStripMenuItem1.Click += setAsDefaultToolStripMenuItem1_Click;
        // 
        // resetDefaultToolStripMenuItem
        // 
        resetDefaultToolStripMenuItem.Name = "resetDefaultToolStripMenuItem";
        resetDefaultToolStripMenuItem.Size = new Size(145, 22);
        resetDefaultToolStripMenuItem.Text = "Reset Default";
        resetDefaultToolStripMenuItem.Click += resetDefaultToolStripMenuItem_Click;
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hotkeysToolStripMenuItem });
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(61, 20);
        optionsToolStripMenuItem.Text = "Options";
        // 
        // hotkeysToolStripMenuItem
        // 
        hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
        hotkeysToolStripMenuItem.Size = new Size(117, 22);
        hotkeysToolStripMenuItem.Text = "Hotkeys";
        hotkeysToolStripMenuItem.Click += hotkeysToolStripMenuItem_Click;
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gitHubToolStripMenuItem, aboutOpenClickerToolStripMenuItem });
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(52, 20);
        aboutToolStripMenuItem.Text = "About";
        // 
        // gitHubToolStripMenuItem
        // 
        gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
        gitHubToolStripMenuItem.Size = new Size(175, 22);
        gitHubToolStripMenuItem.Text = "GitHub";
        gitHubToolStripMenuItem.Click += gitHubToolStripMenuItem_Click;
        // 
        // aboutOpenClickerToolStripMenuItem
        // 
        aboutOpenClickerToolStripMenuItem.Name = "aboutOpenClickerToolStripMenuItem";
        aboutOpenClickerToolStripMenuItem.Size = new Size(175, 22);
        aboutOpenClickerToolStripMenuItem.Text = "About OpenClicker";
        aboutOpenClickerToolStripMenuItem.Click += aboutOpenClickerToolStripMenuItem_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(815, 616);
        Controls.Add(tabControl);
        Controls.Add(gp_delay);
        Controls.Add(gb_repeat);
        Controls.Add(pb_progress);
        Controls.Add(btn_stop);
        Controls.Add(btn_start);
        Controls.Add(menuStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MaximumSize = new Size(1000, 2000);
        MinimumSize = new Size(755, 655);
        Name = "Main";
        Text = "OpenClicker";
        gp_interval.ResumeLayout(false);
        gp_interval.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nup_interval_h).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_interval_ms).EndInit();
        gb_repeat.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nud_times).EndInit();
        gp_options.ResumeLayout(false);
        gp_delay.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_delay_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_h).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_delay_ms).EndInit();
        gp_duration.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_duration_sec).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_h).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_duration_mili).EndInit();
        gp_clickPos.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_Y).EndInit();
        ((System.ComponentModel.ISupportInitialize)nup_clickingPos_X).EndInit();
        tabControl.ResumeLayout(false);
        tabPageSingle.ResumeLayout(false);
        tabPageMultiple.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)clickBindingSource).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_pickLocation;

    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_clickingPos_Y;

    private System.Windows.Forms.Label lbl_clickingPos_X;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_clickingPos_X;
    private System.Windows.Forms.Label lbl_clickingPos_Y;

    private System.Windows.Forms.GroupBox gp_clickPos;
    private System.Windows.Forms.RadioButton rb_currentPos;
    private System.Windows.Forms.RadioButton rb_XY;

    private System.Windows.Forms.GroupBox gp_duration;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_duration_sec;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_duration_min;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_duration_h;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_duration_mili;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.ProgressBar pb_progress;

    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_delay_sec;

    private System.Windows.Forms.GroupBox gp_delay;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_interval_sec;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_delay_min;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_delay_h;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_delay_ms;
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
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nud_times;

    private System.Windows.Forms.TextBox tb_times;

    private System.Windows.Forms.RadioButton rb_infinite;
    private System.Windows.Forms.RadioButton rb_times;

    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_interval_min;
    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_seconds;

    private OpenClicker.CustomComponents.NumericUpDownNoScroll nup_interval_ms;

    private System.Windows.Forms.Button btn_stop;

    private System.Windows.Forms.Button btn_start;

    private System.Windows.Forms.GroupBox gb_repeat;

    private System.Windows.Forms.Label lb_msec;

    private System.Windows.Forms.Label lb_sec;

    private System.Windows.Forms.Label lb_Minutes;

    private System.Windows.Forms.Label lb_Hours;

    private System.Windows.Forms.GroupBox gp_interval;

    #endregion

    private TabControl tabControl;
    private TabPage tabPageSingle;
    private TabPage tabPageMultiple;
    private Button btn_multiple_addClick;
    private CustomComponents.NumericUpDownNoScroll nup_interval_h;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem gitHubToolStripMenuItem;
    private ToolStripMenuItem aboutOpenClickerToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem loadToolStripMenuItem;
    private ToolStripMenuItem setAsDefaultToolStripMenuItem;
    private ToolStripMenuItem setAsDefaultToolStripMenuItem1;
    private ToolStripMenuItem resetDefaultToolStripMenuItem;
    private DataGridView dataGridView1;
    private DataGridView dataGridView;
    private BindingSource clickBindingSource;
    private Button btn_multiple_EditClick;
    private Button btn_multiple_delete;
    private ToolStripMenuItem hotkeysToolStripMenuItem;
    private Button btn_record;
    private Button btn_deleteAll;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewTextBoxColumn delayDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn Position;
    private DataGridViewTextBoxColumn clickTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn mouseButtonDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn HoldingDuration;
    private DataGridViewTextBoxColumn Key;
    private DataGridViewTextBoxColumn KeyDown;
}