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
            nud_X = new NumericUpDown();
            nud_Y = new NumericUpDown();
            lbl_X = new Label();
            lbl_Y = new Label();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Y).BeginInit();
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
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // ClickControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(451, 74);
            ((System.ComponentModel.ISupportInitialize)nud_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Y).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_MouseButton;
        private Label lbl_mouseButton;
        private Label lbl_ClickType;
        private ComboBox cb_ClickType;
        private NumericUpDown nud_X;
        private NumericUpDown nud_Y;
        private Label lbl_X;
        private Label lbl_Y;
        private Button btn_delete;
    }
}
