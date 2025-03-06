namespace Augustine.ScreenDimmer
{
    public partial class ScreenDimmer
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
            components = new System.ComponentModel.Container();
            toolTipHint = new System.Windows.Forms.ToolTip(components);
            buttonDim = new System.Windows.Forms.Button();
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            labelBrightness = new System.Windows.Forms.Label();
            labelExpandCollapse = new System.Windows.Forms.Label();
            labelHelp = new System.Windows.Forms.Label();
            labelBug = new System.Windows.Forms.Label();
            labelAbout = new System.Windows.Forms.Label();
            buttonBright = new System.Windows.Forms.Button();
            checkBoxZeroBrightness = new System.Windows.Forms.CheckBox();
            checkBoxDebug = new System.Windows.Forms.CheckBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timerEnforceOnTop = new System.Windows.Forms.Timer(components);
            timerFade = new System.Windows.Forms.Timer(components);
            trackBarBrightness = new System.Windows.Forms.TrackBar();
            checkBoxEnforceOnTop = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            toolTipWarning = new System.Windows.Forms.ToolTip(components);
            checkBoxAllowTransition = new System.Windows.Forms.CheckBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipHint
            // 
            toolTipHint.ShowAlways = true;
            // 
            // buttonDim
            // 
            buttonDim.AutoSize = true;
            buttonDim.BackColor = System.Drawing.Color.Black;
            buttonDim.ContextMenuStrip = contextMenuStrip2;
            buttonDim.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonDim.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonDim.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            buttonDim.FlatAppearance.BorderSize = 0;
            buttonDim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDim.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonDim.ForeColor = System.Drawing.Color.Gray;
            buttonDim.Location = new System.Drawing.Point(3, 3);
            buttonDim.Name = "buttonDim";
            buttonDim.Size = new System.Drawing.Size(116, 35);
            buttonDim.TabIndex = 46;
            buttonDim.Text = "Dim ";
            toolTipHint.SetToolTip(buttonDim, "Apply minimum brightness.\r\nRight click to change color.");
            buttonDim.UseVisualStyleBackColor = false;
            buttonDim.Click += buttonDim_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(140, 36);
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            colorToolStripMenuItem.Text = "Color...";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // labelBrightness
            // 
            labelBrightness.AutoSize = true;
            labelBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            labelBrightness.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelBrightness.Location = new System.Drawing.Point(3, 0);
            labelBrightness.Name = "labelBrightness";
            labelBrightness.Size = new System.Drawing.Size(33, 32);
            labelBrightness.TabIndex = 1;
            labelBrightness.Text = "";
            labelBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipHint.SetToolTip(labelBrightness, "Brightness");
            // 
            // labelExpandCollapse
            // 
            labelExpandCollapse.AutoSize = true;
            labelExpandCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            labelExpandCollapse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelExpandCollapse.Location = new System.Drawing.Point(216, 79);
            labelExpandCollapse.Margin = new System.Windows.Forms.Padding(0);
            labelExpandCollapse.Name = "labelExpandCollapse";
            labelExpandCollapse.Size = new System.Drawing.Size(34, 31);
            labelExpandCollapse.TabIndex = 54;
            labelExpandCollapse.Text = "▷";
            toolTipHint.SetToolTip(labelExpandCollapse, "More...");
            labelExpandCollapse.Click += labelExpandCollapse_Click;
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            labelHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHelp.Location = new System.Drawing.Point(170, 79);
            labelHelp.Margin = new System.Windows.Forms.Padding(0);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new System.Drawing.Size(46, 31);
            labelHelp.TabIndex = 55;
            labelHelp.Text = "❔";
            toolTipHint.SetToolTip(labelHelp, "Hotkeys...");
            labelHelp.Click += labelHelp_Click;
            // 
            // labelBug
            // 
            labelBug.AutoSize = true;
            labelBug.Cursor = System.Windows.Forms.Cursors.Hand;
            labelBug.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelBug.ForeColor = System.Drawing.Color.Maroon;
            labelBug.Location = new System.Drawing.Point(221, 134);
            labelBug.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            labelBug.Name = "labelBug";
            labelBug.Size = new System.Drawing.Size(46, 31);
            labelBug.TabIndex = 56;
            labelBug.Text = "🐞";
            toolTipHint.SetToolTip(labelBug, "View...");
            labelBug.Visible = false;
            labelBug.Click += labelBug_Click;
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            labelAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelAbout.Location = new System.Drawing.Point(0, 79);
            labelAbout.Margin = new System.Windows.Forms.Padding(0);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new System.Drawing.Size(34, 31);
            labelAbout.TabIndex = 42;
            labelAbout.Text = "ⓘ";
            labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTipHint.SetToolTip(labelAbout, "About...");
            labelAbout.Click += labelAbout_Click;
            // 
            // buttonBright
            // 
            buttonBright.AutoSize = true;
            buttonBright.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonBright.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonBright.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            buttonBright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBright.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonBright.ForeColor = System.Drawing.Color.Gray;
            buttonBright.Location = new System.Drawing.Point(125, 3);
            buttonBright.Name = "buttonBright";
            buttonBright.Size = new System.Drawing.Size(116, 35);
            buttonBright.TabIndex = 45;
            buttonBright.Text = "Brighten ";
            toolTipHint.SetToolTip(buttonBright, "Apply maximum brightness.");
            buttonBright.UseVisualStyleBackColor = true;
            buttonBright.Click += buttonBright_Click;
            // 
            // checkBoxZeroBrightness
            // 
            checkBoxZeroBrightness.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(checkBoxZeroBrightness, 2);
            checkBoxZeroBrightness.Location = new System.Drawing.Point(3, 3);
            checkBoxZeroBrightness.Name = "checkBoxZeroBrightness";
            checkBoxZeroBrightness.Size = new System.Drawing.Size(201, 27);
            checkBoxZeroBrightness.TabIndex = 47;
            checkBoxZeroBrightness.Text = "Allow Zero Brightness";
            toolTipWarning.SetToolTip(checkBoxZeroBrightness, "When setting brightness to zero, the screen will be completely dimmed with selected color!");
            checkBoxZeroBrightness.UseVisualStyleBackColor = true;
            checkBoxZeroBrightness.CheckedChanged += checkBoxZeroBrightness_CheckedChanged;
            // 
            // checkBoxDebug
            // 
            checkBoxDebug.AutoSize = true;
            checkBoxDebug.Location = new System.Drawing.Point(3, 137);
            checkBoxDebug.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            checkBoxDebug.Name = "checkBoxDebug";
            checkBoxDebug.Size = new System.Drawing.Size(155, 27);
            checkBoxDebug.TabIndex = 41;
            checkBoxDebug.Text = "Log Debug Info";
            checkBoxDebug.UseVisualStyleBackColor = true;
            checkBoxDebug.Visible = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Screen Dimmer is Running Here!";
            notifyIcon1.BalloonTipTitle = "Screen Dimmer";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Text = "Screen Dimmer";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { controlPanelToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(190, 74);
            // 
            // controlPanelToolStripMenuItem
            // 
            controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            controlPanelToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            controlPanelToolStripMenuItem.Text = "Control Panel";
            controlPanelToolStripMenuItem.Click += controlPanelToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // timerEnforceOnTop
            // 
            timerEnforceOnTop.Interval = 30000;
            timerEnforceOnTop.Tick += timerEnforceOnTop_Tick;
            // 
            // timerFade
            // 
            timerFade.Interval = 40;
            timerFade.Tick += timerFade_Tick;
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.AutoSize = false;
            tableLayoutPanel1.SetColumnSpan(trackBarBrightness, 3);
            trackBarBrightness.Dock = System.Windows.Forms.DockStyle.Top;
            trackBarBrightness.LargeChange = 20;
            trackBarBrightness.Location = new System.Drawing.Point(42, 3);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Minimum = 20;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new System.Drawing.Size(205, 26);
            trackBarBrightness.SmallChange = 10;
            trackBarBrightness.TabIndex = 30;
            trackBarBrightness.TickFrequency = 10;
            trackBarBrightness.Value = 45;
            trackBarBrightness.ValueChanged += trackBarBrightness_ValueChanged;
            // 
            // checkBoxEnforceOnTop
            // 
            checkBoxEnforceOnTop.AutoSize = true;
            checkBoxEnforceOnTop.Location = new System.Drawing.Point(3, 36);
            checkBoxEnforceOnTop.Name = "checkBoxEnforceOnTop";
            checkBoxEnforceOnTop.Size = new System.Drawing.Size(215, 27);
            checkBoxEnforceOnTop.TabIndex = 49;
            checkBoxEnforceOnTop.Text = "Force on Top of Taskbar";
            checkBoxEnforceOnTop.UseVisualStyleBackColor = true;
            checkBoxEnforceOnTop.CheckedChanged += checkBoxEnforceOnTop_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Right;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(3, 66);
            label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 29);
            label1.TabIndex = 51;
            label1.Text = "Enforcing Period [seconds]:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorDialog1
            // 
            colorDialog1.FullOpen = true;
            colorDialog1.SolidColorOnly = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.AutoSize = true;
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new System.Drawing.Point(224, 69);
            numericUpDown1.Maximum = new decimal(new int[] { 1800, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(70, 29);
            numericUpDown1.TabIndex = 53;
            numericUpDown1.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // toolTipWarning
            // 
            toolTipWarning.ForeColor = System.Drawing.Color.Maroon;
            toolTipWarning.ShowAlways = true;
            toolTipWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            toolTipWarning.ToolTipTitle = "Caution";
            // 
            // checkBoxAllowTransition
            // 
            checkBoxAllowTransition.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(checkBoxAllowTransition, 2);
            checkBoxAllowTransition.Location = new System.Drawing.Point(3, 104);
            checkBoxAllowTransition.Name = "checkBoxAllowTransition";
            checkBoxAllowTransition.Size = new System.Drawing.Size(166, 27);
            checkBoxAllowTransition.TabIndex = 57;
            checkBoxAllowTransition.Text = "Enable Transition";
            checkBoxAllowTransition.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(labelBrightness, 0, 0);
            tableLayoutPanel1.Controls.Add(trackBarBrightness, 1, 0);
            tableLayoutPanel1.Controls.Add(labelExpandCollapse, 3, 3);
            tableLayoutPanel1.Controls.Add(labelHelp, 2, 3);
            tableLayoutPanel1.Controls.Add(labelAbout, 0, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(250, 110);
            tableLayoutPanel1.TabIndex = 58;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonDim, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonBright, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(244, 41);
            tableLayoutPanel2.TabIndex = 59;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.Controls.Add(checkBoxZeroBrightness, 0, 0);
            tableLayoutPanel3.Controls.Add(checkBoxEnforceOnTop, 0, 1);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 1, 2);
            tableLayoutPanel3.Controls.Add(labelBug, 1, 4);
            tableLayoutPanel3.Controls.Add(checkBoxAllowTransition, 0, 3);
            tableLayoutPanel3.Controls.Add(checkBoxDebug, 0, 4);
            tableLayoutPanel3.Controls.Add(label1, 0, 2);
            tableLayoutPanel3.Location = new System.Drawing.Point(259, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(297, 167);
            tableLayoutPanel3.TabIndex = 59;
            tableLayoutPanel3.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(559, 173);
            tableLayoutPanel4.TabIndex = 60;
            // 
            // ScreenDimmer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(430, 153);
            Controls.Add(tableLayoutPanel4);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ScreenDimmer";
            Text = "Form1";
            FormClosing += screenDimmer_FormClosing;
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipHint;
        private System.Windows.Forms.CheckBox checkBoxZeroBrightness;
        private System.Windows.Forms.Button buttonDim;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerEnforceOnTop;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.CheckBox checkBoxEnforceOnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelExpandCollapse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.ToolTip toolTipWarning;
        private System.Windows.Forms.Label labelBug;
        private System.Windows.Forms.CheckBox checkBoxAllowTransition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}

