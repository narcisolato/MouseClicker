using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseClicker
{
    class HotKey
    {
        //핫키 등록 : 핸들, 아이디, 조합키사용여부, 키
        [DllImport("User32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        
        //핫키제거 : 핸들, 아이디
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        //누름 상태
        [DllImport("user32")]
        public static extern UInt16 GetAsyncKeyState(Int32 vKey);

        private const int MOD_NULL = 0x0;
        private const int MOD_ALT = 0x1;
        private const int MOD_CONTROL = 0x2;
        private const int MOD_SHIFT = 0x4;
        private const int MOD_WIN = 0x8;

        public static int nLeftClick { get; set; } = (int)Keys.Q;
        public static int nMiddleClick { get; set; } = (int)Keys.W;
        public static int nRightClick { get; set; } = (int)Keys.E;
        public static int nMiddleWheelUp { get; set; } = (int)Keys.S;
        public static int nMiddleWheelDown { get; set; } = (int)Keys.D;
        public static int nStop { get; set; } = (int)Keys.Escape;

        public static int nOpen { get; set; } = 999;
        public static int nClose { get; set; } = 1000;
        
        public static void HotKeyRegist(int handle)
        {            
            RegisterHotKey(handle, nLeftClick, MOD_NULL, nLeftClick);            
            RegisterHotKey(handle, nMiddleClick, MOD_NULL, nMiddleClick);
            RegisterHotKey(handle, nRightClick, MOD_NULL, nRightClick);
            RegisterHotKey(handle, nMiddleWheelUp, MOD_NULL, nMiddleWheelUp);
            RegisterHotKey(handle, nMiddleWheelDown, MOD_NULL, nMiddleWheelDown);        
            RegisterHotKey(handle, nStop, MOD_NULL, nStop);            
        }

        public static void HotKeyStart(int handle)
        {
            RegisterHotKey(handle, nOpen, MOD_ALT, (int)Keys.Q);
            RegisterHotKey(handle, nClose, MOD_ALT, (int)Keys.Escape);
        }

        public static void HotKeyClose(int handle)
        {
            UnregisterHotKey(handle, nOpen);
        }

        public static void HotKeyStop(int handle)
        {
            UnregisterHotKey(handle, nLeftClick);
            UnregisterHotKey(handle, nMiddleClick);
            UnregisterHotKey(handle, nRightClick);
            UnregisterHotKey(handle, nMiddleWheelUp);
            UnregisterHotKey(handle, nMiddleWheelDown);
            UnregisterHotKey(handle, nStop);
        }

        public static void LeftClick()
        {
            if (KeyPressState(nLeftClick))
            {
                MouseEvent.LeftDown();
                KeyPressSleep(nLeftClick);
                MouseEvent.LeftUp();
            }
        }

        public static void MiddleClick()
        {
            if (KeyPressState(nMiddleClick))
            {
                MouseEvent.MiddleDown();
                KeyPressSleep(nMiddleClick);
                MouseEvent.MiddleUp();
            }
        }

        public static void RightClick()
        {
            if (KeyPressState(nRightClick))
            {
                MouseEvent.RightDown();
                KeyPressSleep(nRightClick);
                MouseEvent.RightUp();
            }
        }
             
        private static bool KeyPressState(int nKey)
        {
            bool bKeyPress = false;
            if (HotKey.GetAsyncKeyState(nKey) != 0)
            {
                bKeyPress = true;
            }
            return bKeyPress;
        }

        private static void KeyPressSleep(int nKey)
        {
            while (true)
            {
                if (HotKey.GetAsyncKeyState(nKey) == 0) { return; }
                Thread.Sleep(1);
            }
        }

        public static void RightHandMode()
        {
           nLeftClick = (int)Keys.Q;
           nMiddleClick = (int)Keys.W;
           nRightClick = (int)Keys.E;
           nMiddleWheelUp = (int)Keys.S;
           nMiddleWheelDown = (int)Keys.D;
        }

        public static void LeftHandMode()
        {
            nLeftClick = (int)Keys.P;
            nMiddleClick = (int)Keys.OemOpenBrackets;
            nRightClick = (int)Keys.OemCloseBrackets;
            nMiddleWheelUp = (int)Keys.OemSemicolon;
            nMiddleWheelDown = (int)Keys.OemQuotes;
        }

        public static void NumberPadRightMode()
        {
            nLeftClick = (int)Keys.NumPad9;
            nMiddleClick = (int)Keys.NumPad8;
            nRightClick = (int)Keys.NumPad7;
            nMiddleWheelUp = (int)Keys.NumPad6;
            nMiddleWheelDown = (int)Keys.NumPad5;
        }

        public static void NumberPadLeftMode()
        {
            nLeftClick = (int)Keys.NumPad7;
            nMiddleClick = (int)Keys.NumPad8;
            nRightClick = (int)Keys.NumPad9;
            nMiddleWheelUp = (int)Keys.NumPad5;
            nMiddleWheelDown = (int)Keys.NumPad6;
        }
    }
}
