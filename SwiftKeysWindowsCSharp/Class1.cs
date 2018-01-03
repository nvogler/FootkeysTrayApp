using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowMover
{
    using System.Windows.Forms;

    static class WinCmds
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        public static void Move(int x, int y, bool onTop)
        {
            const int SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            Process[] processes = Process.GetProcessesByName("vysor");
            foreach (var process in processes)
            {
                if (process.MainWindowTitle == "Raspberry Pi_3")
                {
                    IntPtr handle = process.MainWindowHandle;
                    if (onTop)
                    {
                        SetWindowPos(handle, -1, x, y, 600, 800, SWP_NOZORDER | SWP_SHOWWINDOW);
                    }
                    else
                    {
                        SetWindowPos(handle, 0, x, y, 600, 800, SWP_NOZORDER | SWP_SHOWWINDOW );
                    }
                    
                }
            }

            
        }
    }
}
