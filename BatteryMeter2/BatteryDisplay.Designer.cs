namespace BatteryMeter2
{
    partial class BatteryDisplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryDisplay));
            this.Percent = new System.Windows.Forms.Label();
            this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timeRemainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBatteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorStandbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInterval = new System.Windows.Forms.ToolStripTextBox();
            this.lowThreashold = new System.Windows.Forms.ToolStripTextBox();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.popupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Percent
            // 
            this.Percent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.Percent.BackColor = System.Drawing.Color.Black;
            this.Percent.ContextMenuStrip = this.popupMenu;
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.ForeColor = System.Drawing.Color.DarkOrange;
            this.Percent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Percent.Location = new System.Drawing.Point(36, 0);
            this.Percent.Margin = new System.Windows.Forms.Padding(0);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(27, 16);
            this.Percent.TabIndex = 0;
            this.Percent.Text = "100%";
            this.Percent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Percent.Click += new System.EventHandler(this.Time_Click);
            // 
            // popupMenu
            // 
            this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeRemainingToolStripMenuItem,
            this.showBatteryToolStripMenuItem,
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem,
            this.monitorStandbyToolStripMenuItem,
            this.txtInterval,
            this.lowThreashold,
            this.quitToolStripMenuItem});
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Size = new System.Drawing.Size(268, 160);
            // 
            // timeRemainingToolStripMenuItem
            // 
            this.timeRemainingToolStripMenuItem.Checked = true;
            this.timeRemainingToolStripMenuItem.CheckOnClick = true;
            this.timeRemainingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeRemainingToolStripMenuItem.Name = "timeRemainingToolStripMenuItem";
            this.timeRemainingToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.timeRemainingToolStripMenuItem.Text = "Show Time Remaining";
            // 
            // showBatteryToolStripMenuItem
            // 
            this.showBatteryToolStripMenuItem.Checked = true;
            this.showBatteryToolStripMenuItem.CheckOnClick = true;
            this.showBatteryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBatteryToolStripMenuItem.Name = "showBatteryToolStripMenuItem";
            this.showBatteryToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.showBatteryToolStripMenuItem.Text = "Show Battery %";
            // 
            // hideEntireInterfaceOnBatteryDiToolStripMenuItem
            // 
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem.CheckOnClick = true;
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem.Name = "hideEntireInterfaceOnBatteryDiToolStripMenuItem";
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.hideEntireInterfaceOnBatteryDiToolStripMenuItem.Text = "Hide interface when battery is missing";
            // 
            // monitorStandbyToolStripMenuItem
            // 
            this.monitorStandbyToolStripMenuItem.Name = "monitorStandbyToolStripMenuItem";
            this.monitorStandbyToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.monitorStandbyToolStripMenuItem.Text = "Monitor Standby";
            this.monitorStandbyToolStripMenuItem.Click += new System.EventHandler(this.monitorStandbyToolStripMenuItem_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 21);
            this.txtInterval.Text = "10000";
            this.txtInterval.Leave += new System.EventHandler(this.txtInterval_Leave);
            // 
            // lowThreashold
            // 
            this.lowThreashold.Name = "lowThreashold";
            this.lowThreashold.Size = new System.Drawing.Size(100, 21);
            this.lowThreashold.Text = "0";
            this.lowThreashold.Leave += new System.EventHandler(this.txtInterval_Leave);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.Time.BackColor = System.Drawing.Color.Black;
            this.Time.ContextMenuStrip = this.popupMenu;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.DarkOrange;
            this.Time.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Time.Location = new System.Drawing.Point(0, 0);
            this.Time.Margin = new System.Windows.Forms.Padding(0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(36, 16);
            this.Time.TabIndex = 1;
            this.Time.Text = "0:00";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // BatteryDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(76, 25);
            this.ContextMenuStrip = this.popupMenu;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Percent);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatteryDisplay";
            this.Opacity = 0.6;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Battery";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.HotPink;
            this.Load += new System.EventHandler(this.BatteryDisplay_Load);
            this.popupMenu.ResumeLayout(false);
            this.popupMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ContextMenuStrip popupMenu;
        private System.Windows.Forms.ToolStripMenuItem timeRemainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBatteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideEntireInterfaceOnBatteryDiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox lowThreashold;
        private System.Windows.Forms.ToolStripTextBox txtInterval;
        private System.Windows.Forms.ToolStripMenuItem monitorStandbyToolStripMenuItem;



    }
}

