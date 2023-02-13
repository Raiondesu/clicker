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
            this.SuspendLayout();
            //
            // ClickerAppMenu
            //
            this.ClickerAppMenu.AutoSize = false;
            this.ClickerAppMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClickerAppMenu.Location = new System.Drawing.Point(0, 0);
            this.ClickerAppMenu.Name = "ClickerAppMenu";
            this.ClickerAppMenu.Size = new System.Drawing.Size(304, 25);
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
            this.CloseButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButt.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButt.Location = new System.Drawing.Point(280, 0);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(24, 24);
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
            this.MinimButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(205)), true);
            this.MinimButt.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimButt.Location = new System.Drawing.Point(256, 0);
            this.MinimButt.Name = "MinimButt";
            this.MinimButt.Size = new System.Drawing.Size(24, 24);
            this.MinimButt.TabIndex = 4;
            this.MinimButt.Text = "__";
            this.MinimButt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimButt.UseVisualStyleBackColor = true;
            this.MinimButt.Click += new System.EventHandler(this.MinimButt_Click);
            //
            // ExecKeyBox
            //
            this.ExecKeyBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExecKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExecKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecKeyBox.ForeColor = System.Drawing.Color.White;
            this.ExecKeyBox.Location = new System.Drawing.Point(185, 42);
            this.ExecKeyBox.Name = "ExecKeyBox";
            this.ExecKeyBox.Size = new System.Drawing.Size(107, 19);
            this.ExecKeyBox.TabIndex = 5;
            this.toolTip.SetToolTip(this.ExecKeyBox, "Key that executes a command from other keys");
            this.ExecKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExecKeyBox_KeyDown);
            //
            // ClickKeyBox
            //
            this.ClickKeyBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClickKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClickKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClickKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClickKeyBox.ForeColor = System.Drawing.Color.White;
            this.ClickKeyBox.Location = new System.Drawing.Point(201, 74);
            this.ClickKeyBox.Name = "ClickKeyBox";
            this.ClickKeyBox.Size = new System.Drawing.Size(91, 19);
            this.ClickKeyBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.ClickKeyBox, "Press this key with the Execution Key to start clicking insanely!");
            this.ClickKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClickKeyBox_KeyDown);
            //
            // ExitKeyBox
            //
            this.ExitKeyBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExitKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitKeyBox.ForeColor = System.Drawing.Color.White;
            this.ExitKeyBox.Location = new System.Drawing.Point(185, 106);
            this.ExitKeyBox.Name = "ExitKeyBox";
            this.ExitKeyBox.Size = new System.Drawing.Size(107, 19);
            this.ExitKeyBox.TabIndex = 7;
            this.ExitKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitKeyBox_KeyDown);
            //
            // labelExec
            //
            this.labelExec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelExec.AutoSize = true;
            this.labelExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExec.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExec.Location = new System.Drawing.Point(12, 42);
            this.labelExec.Name = "labelExec";
            this.labelExec.Size = new System.Drawing.Size(155, 20);
            this.labelExec.TabIndex = 8;
            this.labelExec.Text = "The Execution Key is";
            this.toolTip.SetToolTip(this.labelExec, "Key that executes a command from other keys");
            //
            // labelClick
            //
            this.labelClick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClick.AutoSize = true;
            this.labelClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClick.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClick.Location = new System.Drawing.Point(12, 74);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(183, 20);
            this.labelClick.TabIndex = 9;
            this.labelClick.Text = "The ClickMadness Key is";
            this.toolTip.SetToolTip(this.labelClick, "Press this key with the Execution Key to start clicking insanely!");
            //
            // labelExit
            //
            this.labelExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelExit.AutoSize = true;
            this.labelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExit.Location = new System.Drawing.Point(12, 106);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(149, 20);
            this.labelExit.TabIndex = 10;
            this.labelExit.Text = "The ExitCode Key is";
            this.toolTip.SetToolTip(this.labelExit, "Press this key with the Execution Key to exit");
            //
            // MainLabel
            //
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MainLabel.Location = new System.Drawing.Point(6, 4);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(117, 17);
            this.MainLabel.TabIndex = 12;
            this.MainLabel.Text = "InsaneClickerApp";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ClickerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 140);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClickerForm";
            this.Text = "ClickerApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickerForm_FormClosing);
            this.Load += new System.EventHandler(this.ClickerForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickerAppMenu_MouseUp);
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

    }
}

