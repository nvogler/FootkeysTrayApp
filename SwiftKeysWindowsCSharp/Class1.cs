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
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            var process = Process.GetProcessesByName("Raspberry Pi_3");
            var handle = process[0].MainWindowHandle;

            SetWindowPos(handle, onTop ? -1 : 0, x, y, 600, 800, SWP_NOZORDER | SWP_SHOWWINDOW);
        }
    }
}
