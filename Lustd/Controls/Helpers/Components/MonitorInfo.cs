using System.Runtime.InteropServices;

namespace Lustd.Controls.Helpers.Components
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class MonitorInfo
    {
        public int cbSize = Marshal.SizeOf(typeof(MonitorInfo));

        public Rectangle rcMonitor = new Rectangle();

        public Rectangle rcWork = new Rectangle();

        public int dwFlags = 0;
    }
}