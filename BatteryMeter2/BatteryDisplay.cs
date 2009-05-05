using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gma.System.Windows;

namespace BatteryMeter2
{
    public partial class BatteryDisplay : Form
    {
        
        public BatteryDisplay()
        {
            InitializeComponent();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            int seconds;

            if (hideEntireInterfaceOnBatteryDiToolStripMenuItem.Checked)
            {
                if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
                {
                    Percent.Visible = false;
                    Time.Visible = false;
                    return;
                }
            }
            else
            {
                Percent.Visible = true;
                Time.Visible = true;
            }

            try
            {
                this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                this.Top = Screen.PrimaryScreen.WorkingArea.Top;
            }
            catch (Exception)
            { 
            }


            if (showBatteryToolStripMenuItem.Checked)
            {
                Percent.Visible = true;

                if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
                {
                    Percent.Text = "";
                }
                else
                {
                    Percent.Text = ((int)(SystemInformation.PowerStatus.BatteryLifePercent * 100)).ToString() + "%";
                }
            }
            else
            {
                Percent.Visible = false;
            }

            if (timeRemainingToolStripMenuItem.Checked)
            {
                Time.Visible = true;
                switch (SystemInformation.PowerStatus.BatteryChargeStatus)
                {
                    case BatteryChargeStatus.Charging|BatteryChargeStatus.Critical:
                    case BatteryChargeStatus.Charging|BatteryChargeStatus.Low:
                    case BatteryChargeStatus.Charging|BatteryChargeStatus.High:
                    case BatteryChargeStatus.Charging:
                        Time.Text = "CHG";
                        break;
                    default:
                        if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
                        {
                            Time.Text = "PWR";
                        }
                        else
                        {
                            seconds = SystemInformation.PowerStatus.BatteryLifeRemaining;
                            TimeSpan ts = TimeSpan.FromSeconds(seconds);
                            if (ts.Minutes.ToString().Length == 1)
                            {
                                Time.Text = ts.Hours + ":0" + ts.Minutes;
                            }
                            else
                            {
                                Time.Text = ts.Hours + ":" + ts.Minutes;
                            }
                        }
                        break;
                }
            }
            else
            {
                Time.Visible = false;
            }

            /// Enable a battery alarm feature to trigger at a different time
            if (lowThreashold.Text != "")
            {
                if (Convert.ToInt32(SystemInformation.PowerStatus.BatteryLifePercent * 100) ==
                    int.Parse(lowThreashold.Text))
                {
                    System.Media.SoundPlayer Snd = new System.Media.SoundPlayer("alarm.wav");
                    Snd.Play();
                }
            }


            /// Reset the time to the new interval
            RefreshTimer.Interval = int.Parse(txtInterval.Text);
        }

        private void BatteryDisplay_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process MyProc = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] AllProc = System.Diagnostics.Process.GetProcessesByName(MyProc.ProcessName);
                     
            this.Width = 76 * 2;
            this.Height = 24;

            foreach (System.Diagnostics.Process proc in AllProc)
            {
                if (proc.Id == MyProc.Id)
                {
                    //do nothing about self
                }
                else
                {
                    proc.Kill();
                }
            }

            Percent.Text = "...";
            Time.Text = "LOAD";

            try
            {
                timeRemainingToolStripMenuItem.Checked = Properties.Settings.Default.ShowTimeRemain;
                showBatteryToolStripMenuItem.Checked = Properties.Settings.Default.ShowBattPercent;
                hideEntireInterfaceOnBatteryDiToolStripMenuItem.Checked = Properties.Settings.Default.HideInterface;
                txtInterval.Text = Properties.Settings.Default.Interval;
                lowThreashold.Text = Properties.Settings.Default.Threashold;
            }
            catch(Exception){}

            RefreshTimer.Start();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowTimeRemain = timeRemainingToolStripMenuItem.Checked;
            Properties.Settings.Default.ShowBattPercent = showBatteryToolStripMenuItem.Checked;
            Properties.Settings.Default.HideInterface = hideEntireInterfaceOnBatteryDiToolStripMenuItem.Checked;
            Properties.Settings.Default.Interval = txtInterval.Text;
            Properties.Settings.Default.Threashold = lowThreashold.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txtInterval_Leave(object sender, EventArgs e)
        {
            RefreshTimer.Interval = Int32.Parse(txtInterval.Text);
        }

        private void monitorStandbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayCtrl.MonitorStandby();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            DisplayCtrl.MonitorStandby();
        }

    }
}