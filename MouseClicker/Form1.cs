using System;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class MouseClicker : Form
    {
        private const int WM_HOTKEY = 0x312;
        private static bool bMouseClickerOn = false;
        public static int nWheelScrollLength = 400;   

        public MouseClicker()
        {
            InitializeComponent();            
        }

        //폼 관련
        private void FormLoad(object sender, EventArgs e)
        {
            FormHidden();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            HotKey.StopHotKey((int)this.Handle);
            HotKey.CloseHotKey((int)this.Handle);
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
            // Form을 Taskbar로 숨기면 레지스트 등록이 취소되어 재등록
            HotKey.StartHotKey((int)this.Handle);
            if (bMouseClickerOn)
            {
                HotKey.RegistHotKey((int)this.Handle);
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
                else if (m.WParam == (IntPtr)HotKey.nOpen)
                {
                    MouseClickerStart();
                }
                else if (m.WParam == (IntPtr)HotKey.nClose)                
                {
                    this.Close();
                }
                else
                {
                    MouseClickerStop();
                }
            }          
        }

        //클릭 기능 관련  
        private void MouseClickerStart()
        {
            bMouseClickerOn = true;
            HotKey.RegistHotKey((int)this.Handle);
            ToolStripMenuItem_OnOff.Text = "정지하기";
        }

        private void MouseClickerStop()
        {
            bMouseClickerOn = false;
            HotKey.StopHotKey((int)this.Handle);
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
            FormHidden();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            FormHidden();
            textBox_WheelScrollLength.Text = nWheelScrollLength.ToString();
            trackBar_WheelScrollLength.Value = nWheelScrollLength;               
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
