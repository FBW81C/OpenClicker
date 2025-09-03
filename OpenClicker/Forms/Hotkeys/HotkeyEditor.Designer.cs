namespace OpenClicker.Forms.Hotkeys
{
    partial class HotkeyEditor
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
            tb_start = new TextBox();
            btn_cancel = new Button();
            btn_ok = new Button();
            lbl_start = new Label();
            tb_stop = new TextBox();
            tb_toggle = new TextBox();
            lbl_stop = new Label();
            lbl_toggle = new Label();
            SuspendLayout();
            // 
            // tb_start
            // 
            tb_start.Location = new Point(62, 46);
            tb_start.Name = "tb_start";
            tb_start.PlaceholderText = "Press Hotkey";
            tb_start.ReadOnly = true;
            tb_start.Size = new Size(154, 23);
            tb_start.TabIndex = 0;
            tb_start.KeyDown += tb_start_KeyDown;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.Location = new Point(256, 236);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ok.Location = new Point(337, 236);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 2;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.Location = new Point(25, 49);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(31, 15);
            lbl_start.TabIndex = 3;
            lbl_start.Text = "Start";
            // 
            // tb_stop
            // 
            tb_stop.Location = new Point(62, 91);
            tb_stop.Name = "tb_stop";
            tb_stop.PlaceholderText = "Press Hotkey";
            tb_stop.ReadOnly = true;
            tb_stop.Size = new Size(154, 23);
            tb_stop.TabIndex = 4;
            tb_stop.KeyDown += tb_stop_KeyDown;
            // 
            // tb_toggle
            // 
            tb_toggle.Location = new Point(62, 134);
            tb_toggle.Name = "tb_toggle";
            tb_toggle.PlaceholderText = "Press Hotkey";
            tb_toggle.ReadOnly = true;
            tb_toggle.Size = new Size(154, 23);
            tb_toggle.TabIndex = 5;
            tb_toggle.KeyDown += tb_toggle_KeyDown;
            // 
            // lbl_stop
            // 
            lbl_stop.AutoSize = true;
            lbl_stop.Location = new Point(18, 94);
            lbl_stop.Name = "lbl_stop";
            lbl_stop.Size = new Size(31, 15);
            lbl_stop.TabIndex = 6;
            lbl_stop.Text = "Stop";
            // 
            // lbl_toggle
            // 
            lbl_toggle.AutoSize = true;
            lbl_toggle.Location = new Point(18, 137);
            lbl_toggle.Name = "lbl_toggle";
            lbl_toggle.Size = new Size(42, 15);
            lbl_toggle.TabIndex = 7;
            lbl_toggle.Text = "Toggle";
            // 
            // HotkeyEditor
            // 
            AcceptButton = btn_ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(424, 271);
            Controls.Add(lbl_toggle);
            Controls.Add(lbl_stop);
            Controls.Add(tb_toggle);
            Controls.Add(tb_stop);
            Controls.Add(lbl_start);
            Controls.Add(btn_ok);
            Controls.Add(btn_cancel);
            Controls.Add(tb_start);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotkeyEditor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "HotkeyEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_start;
        private Button btn_cancel;
        private Button btn_ok;
        private Label lbl_start;
        private TextBox tb_stop;
        private TextBox tb_toggle;
        private Label lbl_stop;
        private Label lbl_toggle;
    }
}