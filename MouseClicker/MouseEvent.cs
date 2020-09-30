using System.Runtime.InteropServices;

namespace MouseClicker
{
    class MouseEvent
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(uint dwDlags, uint dx, uint dy, int dwData, int dwExtraInfo);             
        //https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;

        public static void LeftDown() { mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); }
        public static void LeftUp() { mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); }
        public static void RightDown() { mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0); }
        public static void RightUp() { mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0); }
        public static void MiddleDown() { mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0); }
        public static void MiddleUp() { mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0); }               
        public static void MiddleWheelUp() { mouse_event(MOUSEEVENTF_WHEEL, 0, 0, MouseClicker.nWheelScrollLength, 0); }
        public static void MiddleWheelDown() { mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -MouseClicker.nWheelScrollLength, 0); }
    }   
}
