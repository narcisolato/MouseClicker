using System;
using System.Collections.Generic;
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

        public static int nLeftClick { get; set; }
        public static int nMiddleClick { get; set; }
        public static int nRightClick { get; set; }
        public static int nMiddleWheelUp { get; set; }
        public static int nMiddleWheelDown { get; set; }
     
        public static int nOpen { get; set; } = 999;
        public static int nClose { get; set; } = 1000;

        public static void RegistHotKey(int handle)
        {
            foreach (int i in Enum.GetValues(typeof(Keys)))
            {                
                RegisterHotKey(handle, i, MOD_NULL, i);              
            }
        }

        public static void StartHotKey(int handle)
        {
            RegisterHotKey(handle, nOpen, MOD_ALT, (int)Keys.Q);
            RegisterHotKey(handle, nClose, MOD_ALT, (int)Keys.Escape);
            RegistKey();
        }

        public static void CloseHotKey(int handle)
        {
            UnregisterHotKey(handle, nOpen);
        }

        public static void StopHotKey(int handle)
        {
            foreach (int i in Enum.GetValues(typeof(Keys)))
            {
                UnregisterHotKey(handle, i);                
            }
        }

        public static void LeftClick()
        {
            if (StateKeyPress(nLeftClick))
            {
                MouseEvent.LeftDown();
                SleepKeyPress(nLeftClick);
                MouseEvent.LeftUp();
            }
        }

        public static void MiddleClick()
        {
            if (StateKeyPress(nMiddleClick))
            {
                MouseEvent.MiddleDown();
                SleepKeyPress(nMiddleClick);
                MouseEvent.MiddleUp();
            }
        }

        public static void RightClick()
        {
            if (StateKeyPress(nRightClick))
            {
                MouseEvent.RightDown();
                SleepKeyPress(nRightClick);
                MouseEvent.RightUp();
            }
        }
             
        private static bool StateKeyPress(int nKey)
        {
            bool bKeyPress = false;
            if (HotKey.GetAsyncKeyState(nKey) != 0)
            {
                bKeyPress = true;
            }
            return bKeyPress;
        }

        private static void SleepKeyPress(int nKey)
        {
            while (true)
            {
                if (HotKey.GetAsyncKeyState(nKey) == 0) { return; }
                Thread.Sleep(1);
            }
        }

        public static void RegistKey()
        {
           nLeftClick = (int)Keys.Q;
           nMiddleClick = (int)Keys.W;
           nRightClick = (int)Keys.E;
           nMiddleWheelUp = (int)Keys.S;
           nMiddleWheelDown = (int)Keys.D;
        }
    }
}
