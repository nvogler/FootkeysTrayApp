﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowMover;

namespace SwiftKeysWindowsCSharp
{
    public partial class FootKeys : Form
    {
        private int processId; 

        public FootKeys()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            this.notifyIcon1.ShowBalloonTip(5);
            startBluetooth(); 
        }

        private void startBluetooth()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = "";
            start.FileName = "SwiftFootKeysWindows.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;

            Process proc = Process.Start(start);
            processId = proc.Id;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinCmds.Move(400, -350, true);
        }

        private void option2ToolStripMeduItem_Click(object sender, EventArgs e)
        {
            WinCmds.Move(0, 0, false);
        }

        private void closeApplication(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Process.GetProcessById(processId).Kill();
            Application.Exit(); 
        }

        private void restartBlueTooth(object sender, EventArgs e)
        {
            Process.GetProcessById(processId).Kill();
            startBluetooth(); 
        }

        private void restartAndroidApp(object sender, EventArgs e)
        {
            string strCmdText = "adb shell am force-stop a481project.swiftkeys";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            strCmdText = "adb shell am start-n a481project.swiftkeys/SwiftKeys";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
