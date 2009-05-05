using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace BatteryMeter2
{
    class DisplayCtrl
    {
        public DisplayCtrl()
        {
        }

        ~DisplayCtrl()
        {
        }


        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg,
                      IntPtr wParam, IntPtr lParam);
                
        static int HWND_BROADCAST = 0xffff;
        //the message is sent to all 
        //top-level windows in the system

        static int HWND_TOPMOST = -1;
        //the message is sent to one 
        //top-level window in the system

        static int HWND_TOP = 0;        //
        static int HWND_BOTTOM = 1;        //limited use
        static int HWND_NOTOPMOST = -2;       //


        const int SC_MONITORPOWER = 0xF170;
        const int WM_SYSCOMMAND = 0x0112;

        const int MONITOR_ON = -1;
        const int MONITOR_OFF = 2;
        const int MONITOR_STANBY = 1;

        public static void MonitorStandby()
        {
            SendMessage(new IntPtr(HWND_BROADCAST), WM_SYSCOMMAND, new IntPtr(SC_MONITORPOWER), new IntPtr(MONITOR_STANBY));
        }

    }
}
