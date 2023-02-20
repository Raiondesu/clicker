namespace Clicker
{
    partial class ClickerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickerForm));
            this.ClickerAppMenu = new System.Windows.Forms.MenuStrip();
            this.CloseButt = new System.Windows.Forms.Button();
            this.MinimButt = new System.Windows.Forms.Button();
            this.ExecKeyBox = new System.Windows.Forms.TextBox();
            this.ClickKeyBox = new System.Windows.Forms.TextBox();
            this.ExitKeyBox = new System.Windows.Forms.TextBox();
            this.labelExec = new System.Windows.Forms.Label();
            this.labelClick = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelMouseDelta = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.stopClickingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownPauseMS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelta = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPauseMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelta)).BeginInit();
            this.SuspendLayout();
            // 
            // ClickerAppMenu
            // 
            this.ClickerAppMenu.AutoSize = false;
            this.ClickerAppMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClickerAppMenu.Location = new System.Drawing.Point(0, 0);
            this.ClickerAppMenu.Name = "ClickerAppMenu";
            this.ClickerAppMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ClickerAppMenu.Size = new System.Drawing.Size(355, 29);
            this.ClickerAppMenu.TabIndex = 2;
            this.ClickerAppMenu.Text = "menuStrip1";
            this.ClickerAppMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseDown);
            this.ClickerAppMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseMove);
            this.ClickerAppMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseUp);
            // 
            // CloseButt
            // 
            this.CloseButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButt.FlatAppearance.BorderSize = 0;
            this.CloseButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CloseButt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloseButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButt.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButt.Location = new System.Drawing.Point(327, 0);
            this.CloseButt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(28, 28);
            this.CloseButt.TabIndex = 3;
            this.CloseButt.Text = "X";
            this.CloseButt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButt.UseVisualStyleBackColor = true;
            this.CloseButt.Click += new System.EventHandler(this.CloseButt_Click);
            // 
            // MinimButt
            // 
            this.MinimButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimButt.FlatAppearance.BorderSize = 0;
            this.MinimButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.MinimButt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.MinimButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MinimButt.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimButt.Location = new System.Drawing.Point(299, 0);
            this.MinimButt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimButt.Name = "MinimButt";
            this.MinimButt.Size = new System.Drawing.Size(28, 28);
            this.MinimButt.TabIndex = 4;
            this.MinimButt.Text = "__";
            this.MinimButt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimButt.UseVisualStyleBackColor = true;
            this.MinimButt.Click += new System.EventHandler(this.MinimButt_Click);
            // 
            // ExecKeyBox
            // 
            this.ExecKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExecKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExecKeyBox.ForeColor = System.Drawing.Color.White;
            this.ExecKeyBox.Location = new System.Drawing.Point(216, 48);
            this.ExecKeyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecKeyBox.Name = "ExecKeyBox";
            this.ExecKeyBox.Size = new System.Drawing.Size(125, 19);
            this.ExecKeyBox.TabIndex = 5;
            this.toolTip.SetToolTip(this.ExecKeyBox, "Key that executes a command from other keys");
            this.ExecKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExecKeyBox_KeyDown);
            // 
            // ClickKeyBox
            // 
            this.ClickKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClickKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClickKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClickKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickKeyBox.ForeColor = System.Drawing.Color.White;
            this.ClickKeyBox.Location = new System.Drawing.Point(234, 85);
            this.ClickKeyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClickKeyBox.Name = "ClickKeyBox";
            this.ClickKeyBox.Size = new System.Drawing.Size(106, 19);
            this.ClickKeyBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.ClickKeyBox, "Press this key with the Execution Key to start clicking insanely!");
            this.ClickKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClickKeyBox_KeyDown);
            // 
            // ExitKeyBox
            // 
            this.ExitKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExitKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitKeyBox.ForeColor = System.Drawing.Color.White;
            this.ExitKeyBox.Location = new System.Drawing.Point(216, 122);
            this.ExitKeyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitKeyBox.Name = "ExitKeyBox";
            this.ExitKeyBox.Size = new System.Drawing.Size(125, 19);
            this.ExitKeyBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.ExitKeyBox, "Press this key with the Execution Key to exit");
            this.ExitKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitKeyBox_KeyDown);
            // 
            // labelExec
            // 
            this.labelExec.AutoSize = true;
            this.labelExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExec.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExec.Location = new System.Drawing.Point(14, 48);
            this.labelExec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExec.Name = "labelExec";
            this.labelExec.Size = new System.Drawing.Size(155, 20);
            this.labelExec.TabIndex = 8;
            this.labelExec.Text = "The Execution Key is";
            this.toolTip.SetToolTip(this.labelExec, "Key that executes a command from other keys");
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClick.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClick.Location = new System.Drawing.Point(14, 85);
            this.labelClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(183, 20);
            this.labelClick.TabIndex = 9;
            this.labelClick.Text = "The ClickMadness Key is";
            this.toolTip.SetToolTip(this.labelClick, "Press this key with the Execution Key to start clicking insanely!");
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExit.Location = new System.Drawing.Point(14, 122);
            this.labelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(149, 20);
            this.labelExit.TabIndex = 10;
            this.labelExit.Text = "The ExitCode Key is";
            this.toolTip.SetToolTip(this.labelExit, "Press this key with the Execution Key to exit");
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MainLabel.Location = new System.Drawing.Point(7, 5);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(117, 17);
            this.MainLabel.TabIndex = 12;
            this.MainLabel.Text = "InsaneClickerApp";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMouseDelta
            // 
            this.labelMouseDelta.AutoSize = true;
            this.labelMouseDelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMouseDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMouseDelta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMouseDelta.Location = new System.Drawing.Point(16, 62);
            this.labelMouseDelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMouseDelta.Name = "labelMouseDelta";
            this.labelMouseDelta.Size = new System.Drawing.Size(231, 20);
            this.labelMouseDelta.TabIndex = 15;
            this.labelMouseDelta.Text = "Cursor travel delta distance (px)";
            this.toolTip.SetToolTip(this.labelMouseDelta, "How many pixels must the mouse cursor travel between clicks to stop clicking");
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPause.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPause.Location = new System.Drawing.Point(16, 98);
            this.labelPause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(196, 20);
            this.labelPause.TabIndex = 17;
            this.labelPause.Text = "Pause between clicks (ms)";
            // 
            // stopClickingCheckBox
            // 
            this.stopClickingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopClickingCheckBox.AutoSize = true;
            this.stopClickingCheckBox.Checked = true;
            this.stopClickingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stopClickingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopClickingCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.stopClickingCheckBox.Location = new System.Drawing.Point(16, 25);
            this.stopClickingCheckBox.Name = "stopClickingCheckBox";
            this.stopClickingCheckBox.Size = new System.Drawing.Size(269, 24);
            this.stopClickingCheckBox.TabIndex = 13;
            this.stopClickingCheckBox.Text = "Stop clicking on mouse movement";
            this.stopClickingCheckBox.UseVisualStyleBackColor = true;
            this.stopClickingCheckBox.CheckedChanged += new System.EventHandler(this.StopClickingCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDownPauseMS);
            this.groupBox1.Controls.Add(this.labelPause);
            this.groupBox1.Controls.Add(this.numericUpDownDelta);
            this.groupBox1.Controls.Add(this.labelMouseDelta);
            this.groupBox1.Controls.Add(this.stopClickingCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(14, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 137);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // numericUpDownPauseMS
            // 
            this.numericUpDownPauseMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPauseMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownPauseMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownPauseMS.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownPauseMS.Location = new System.Drawing.Point(261, 99);
            this.numericUpDownPauseMS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPauseMS.Name = "numericUpDownPauseMS";
            this.numericUpDownPauseMS.Size = new System.Drawing.Size(53, 19);
            this.numericUpDownPauseMS.TabIndex = 18;
            this.numericUpDownPauseMS.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPauseMS.ValueChanged += new System.EventHandler(this.NumericUpDownPause_ValueChanged);
            // 
            // numericUpDownDelta
            // 
            this.numericUpDownDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDelta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownDelta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownDelta.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDelta.Location = new System.Drawing.Point(261, 63);
            this.numericUpDownDelta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelta.Name = "numericUpDownDelta";
            this.numericUpDownDelta.Size = new System.Drawing.Size(53, 19);
            this.numericUpDownDelta.TabIndex = 16;
            this.toolTip.SetToolTip(this.numericUpDownDelta, "How many pixels must the mouse cursor travel between clicks to stop clicking");
            this.numericUpDownDelta.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDelta.ValueChanged += new System.EventHandler(this.NumericUpDownDelta_ValueChanged);
            // 
            // ClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(355, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelClick);
            this.Controls.Add(this.labelExec);
            this.Controls.Add(this.ExitKeyBox);
            this.Controls.Add(this.ClickKeyBox);
            this.Controls.Add(this.ExecKeyBox);
            this.Controls.Add(this.MinimButt);
            this.Controls.Add(this.CloseButt);
            this.Controls.Add(this.ClickerAppMenu);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ClickerAppMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClickerForm";
            this.Text = "ClickerApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickerForm_FormClosing);
            this.Load += new System.EventHandler(this.ClickerForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPauseMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip ClickerAppMenu;
        private System.Windows.Forms.Button CloseButt;
        private System.Windows.Forms.Button MinimButt;
        private System.Windows.Forms.TextBox ExecKeyBox;
        private System.Windows.Forms.TextBox ClickKeyBox;
        private System.Windows.Forms.TextBox ExitKeyBox;
        private System.Windows.Forms.Label labelExec;
        private System.Windows.Forms.Label labelClick;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private CheckBox stopClickingCheckBox;
        private GroupBox groupBox1;
        private Label labelMouseDelta;
        private NumericUpDown numericUpDownDelta;
        private NumericUpDown numericUpDownPauseMS;
        private Label labelPause;
    }
}

