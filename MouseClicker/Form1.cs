using System;
using System.Threading;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class MouseClicker : Form
    {
        private const int WM_HOTKEY = 0x312;
        private static bool bMouseClickerOn = false;
        public static int nWheelScrollLength = 400;      
        public static int nMode = nRightHandMode;

        public const int nRightHandMode = 0;
        public const int nLeftHandMode = 1;
        public const int nNumberPadRightMode = 2;
        public const int nNumberPadLeftMode = 3;

        public MouseClicker()
        {
            InitializeComponent();
            comboBox_Mode.SelectedIndex = nRightHandMode;
        }

        //폼 관련
        private void FormLoad(object sender, EventArgs e)
        {
            FormHidden();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            HotKey.HotKeyStop((int)this.Handle);
            HotKey.HotKeyClose((int)this.Handle);
        }

        private void FormVisible()
        {
            Visible = true;
            ShowInTaskbar = true;
            HotKeyReRegist();
        }

        private void FormHidden()
        {
            Visible = false;
            ShowInTaskbar = false;
            HotKeyReRegist();
        }

        private void HotKeyReRegist()
        {
            // ShowInTaskbar 변경하면 레지스트 등록한 게 사라지는 이유로 인해 임시 조치
            HotKey.HotKeyStart((int)this.Handle);
            if (bMouseClickerOn)
            {
                HotKey.HotKeyRegist((int)this.Handle);
            }
        }

        //단축키
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);                  
            if (m.Msg == WM_HOTKEY) //핫키가 눌려지면 312 정수 메시지를 받음
            {     
                if (m.WParam == (IntPtr)HotKey.nLeftClick)
                {                   
                    HotKey.LeftClick();
                }
                else if (m.WParam == (IntPtr)HotKey.nRightClick)
                {
                    HotKey.RightClick();
                }
                else if (m.WParam == (IntPtr)HotKey.nMiddleClick)
                {
                    HotKey.MiddleClick();
                }
                else if (m.WParam == (IntPtr)HotKey.nMiddleWheelUp)
                {
                    MouseEvent.MiddleWheelUp();
                }
                else if (m.WParam == (IntPtr)HotKey.nMiddleWheelDown)
                {
                    MouseEvent.MiddleWheelDown();
                }
                else if (m.WParam == (IntPtr)HotKey.nStop)
                {
                    MouseClickerStop();
                }
                else if (m.WParam == (IntPtr)HotKey.nOpen)
                {
                    MouseClickerStart();
                }                       
                else if (m.WParam == (IntPtr)HotKey.nClose)
                {
                    this.Close();
                }
            }          
        }

        //클릭 기능 관련  
        private void MouseClickerStart()
        {
            bMouseClickerOn = true;
            HotKey.HotKeyRegist((int)this.Handle);
            ToolStripMenuItem_OnOff.Text = "정지하기";
        }

        private void MouseClickerStop()
        {
            bMouseClickerOn = false;
            HotKey.HotKeyStop((int)this.Handle);
            ToolStripMenuItem_OnOff.Text = "시작하기";
        }
        
        //툴팁 관련
        private void ToolStripMenuItemOnOff_Click(object sender, EventArgs e)
        {
            if (bMouseClickerOn == false)
            {
                MouseClickerStart();
            }
            else
            {
                MouseClickerStop();
            }
        }

        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void ToolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            FormVisible();
        }

        //설정창 관련
        private void button_Set_Click(object sender, EventArgs e)
        {            
            Int32.TryParse(textBox_WheelScrollLength.Text, out nWheelScrollLength);
            nMode = comboBox_Mode.SelectedIndex;
            switch (nMode)
            {
                case nRightHandMode:
                    HotKey.RightHandMode();
                    break;
                case nLeftHandMode:
                    HotKey.LeftHandMode();
                    break;
                case nNumberPadRightMode:
                    HotKey.NumberPadRightMode();
                    break;
                case nNumberPadLeftMode:
                    HotKey.NumberPadLeftMode();
                    break;
                default:
                    HotKey.RightHandMode();
                    break;
            }
            FormHidden();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            FormHidden();
            textBox_WheelScrollLength.Text = nWheelScrollLength.ToString();
            trackBar_WheelScrollLength.Value = nWheelScrollLength;
            comboBox_Mode.SelectedIndex = nMode;       
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void trackBar_WheelScrollLength_Scroll(object sender, EventArgs e)
        {
            textBox_WheelScrollLength.Text = trackBar_WheelScrollLength.Value.ToString();
        }

        private void textBox_WheelScrollLength_TextChanged(object sender, EventArgs e)
        {           
            int wheelScrollLength;
            Int32.TryParse(textBox_WheelScrollLength.Text, out wheelScrollLength);
            if (wheelScrollLength < trackBar_WheelScrollLength.Minimum)
            {
                trackBar_WheelScrollLength.Value = trackBar_WheelScrollLength.Minimum;
                
            }
            else if (wheelScrollLength > trackBar_WheelScrollLength.Maximum)
            {
                trackBar_WheelScrollLength.Value = trackBar_WheelScrollLength.Maximum;                
            }
            else
            {
                trackBar_WheelScrollLength.Value = wheelScrollLength;
            }      
        }
    }
}
