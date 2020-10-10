using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using Lustd.Controls.Helpers.Components;

namespace Lustd.Controls.Helpers
{
    public static class WindowHelper
    {
        private static readonly Dictionary<IntPtr, Window> _windows = new Dictionary<IntPtr, Window>();

        public static void OnSourceInitialized(Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;

            if (_windows.ContainsKey(handle) || handle == IntPtr.Zero)
                return;

            _windows.Add(handle, window);
            
            EventHandler handler = null;
            handler = (sender, e) =>
            {
                window.Closed -= handler;

                _windows.Remove(handle);
            };

            window.Closed += handler;

            HwndSource.FromHwnd(handle)?.AddHook(WindowProc);
        }
        
        private static IntPtr WindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                // Address maximise issue
                case WindowMessages.GetMinMaxInfo:

                    OnGetMinMaxInfo(hwnd, lParam);
                    break;
            }

            return IntPtr.Zero;
        }

        private static void OnGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            var mmi = (MinMaxInfo)Marshal.PtrToStructure(lParam, typeof(MinMaxInfo));

            // Adjust the maximized size and position to fit the work area of the correct monitor
            const int monitorDefaultToNearest = 0x00000002;

            var monitor = MonitorFromWindow(hwnd, monitorDefaultToNearest);

            if (monitor != IntPtr.Zero)
            {
                var monitorInfo = new MonitorInfo();
                GetMonitorInfo(monitor, monitorInfo);

                var rcWorkArea = monitorInfo.rcWork;
                var rcMonitorArea = monitorInfo.rcMonitor;

                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.left - rcMonitorArea.left);
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.top - rcMonitorArea.top);
                mmi.ptMaxSize.x = Math.Abs(rcWorkArea.right - rcWorkArea.left);
                mmi.ptMaxSize.y = Math.Abs(rcWorkArea.bottom - rcWorkArea.top);
            }

            Marshal.StructureToPtr(mmi, lParam, true);
        }

        [DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MonitorInfo lpmi);

        [DllImport("User32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
    }
}
