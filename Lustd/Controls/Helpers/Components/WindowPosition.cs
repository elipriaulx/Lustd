using System;
using System.Runtime.InteropServices;

namespace Lustd.Controls.Helpers.Components
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowPosition
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public int flags;
    }
}