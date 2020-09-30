namespace MouseClicker
{
    partial class MouseClicker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseClicker));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Set = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_WheelScrollLength = new System.Windows.Forms.Label();
            this.trackBar_WheelScrollLength = new System.Windows.Forms.TrackBar();
            this.textBox_WheelScrollLength = new System.Windows.Forms.TextBox();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.label_Mode = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WheelScrollLength)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MouseClicker";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Settings,
            this.ToolStripMenuItem_OnOff,
            this.ToolStripMenuItem_Close});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 70);
            // 
            // ToolStripMenuItem_Settings
            // 
            this.ToolStripMenuItem_Settings.Name = "ToolStripMenuItem_Settings";
            this.ToolStripMenuItem_Settings.Size = new System.Drawing.Size(122, 22);
            this.ToolStripMenuItem_Settings.Text = "설정";
            this.ToolStripMenuItem_Settings.Click += new System.EventHandler(this.ToolStripMenuItem_Settings_Click);
            // 
            // ToolStripMenuItem_OnOff
            // 
            this.ToolStripMenuItem_OnOff.Name = "ToolStripMenuItem_OnOff";
            this.ToolStripMenuItem_OnOff.Size = new System.Drawing.Size(122, 22);
            this.ToolStripMenuItem_OnOff.Text = "시작하기";
            this.ToolStripMenuItem_OnOff.Click += new System.EventHandler(this.ToolStripMenuItemOnOff_Click);
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(122, 22);
            this.ToolStripMenuItem_Close.Text = "종료";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.ToolStripMenuItem_Close_Click);
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(95, 79);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(75, 23);
            this.button_Set.TabIndex = 1;
            this.button_Set.Text = "적용";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(176, 79);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "취소";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(14, 79);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "종료";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_WheelScrollLength
            // 
            this.label_WheelScrollLength.AutoSize = true;
            this.label_WheelScrollLength.Location = new System.Drawing.Point(12, 44);
            this.label_WheelScrollLength.Name = "label_WheelScrollLength";
            this.label_WheelScrollLength.Size = new System.Drawing.Size(85, 12);
            this.label_WheelScrollLength.TabIndex = 5;
            this.label_WheelScrollLength.Text = "휠 스크롤 길이";
            // 
            // trackBar_WheelScrollLength
            // 
            this.trackBar_WheelScrollLength.Location = new System.Drawing.Point(103, 44);
            this.trackBar_WheelScrollLength.Maximum = 600;
            this.trackBar_WheelScrollLength.Minimum = 200;
            this.trackBar_WheelScrollLength.Name = "trackBar_WheelScrollLength";
            this.trackBar_WheelScrollLength.Size = new System.Drawing.Size(90, 45);
            this.trackBar_WheelScrollLength.SmallChange = 40;
            this.trackBar_WheelScrollLength.TabIndex = 7;
            this.trackBar_WheelScrollLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_WheelScrollLength.Value = 400;
            this.trackBar_WheelScrollLength.Scroll += new System.EventHandler(this.trackBar_WheelScrollLength_Scroll);
            // 
            // textBox_WheelScrollLength
            // 
            this.textBox_WheelScrollLength.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_WheelScrollLength.Location = new System.Drawing.Point(199, 41);
            this.textBox_WheelScrollLength.MaxLength = 4;
            this.textBox_WheelScrollLength.Name = "textBox_WheelScrollLength";
            this.textBox_WheelScrollLength.Size = new System.Drawing.Size(42, 21);
            this.textBox_WheelScrollLength.TabIndex = 8;
            this.textBox_WheelScrollLength.Text = "400";
            this.textBox_WheelScrollLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_WheelScrollLength.TextChanged += new System.EventHandler(this.textBox_WheelScrollLength_TextChanged);
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "오른손",
            "왼손",
            "숫자패드 오른손",
            "숫자패드 왼손"});
            this.comboBox_Mode.Location = new System.Drawing.Point(113, 12);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(133, 20);
            this.comboBox_Mode.TabIndex = 9;
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Location = new System.Drawing.Point(12, 15);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(29, 12);
            this.label_Mode.TabIndex = 10;
            this.label_Mode.Text = "모드";
            // 
            // MouseClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(258, 115);
            this.ControlBox = false;
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.comboBox_Mode);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.textBox_WheelScrollLength);
            this.Controls.Add(this.trackBar_WheelScrollLength);
            this.Controls.Add(this.label_WheelScrollLength);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MouseClicker";
            this.Text = "마우스 클리커 설정";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.FormLoad);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WheelScrollLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OnOff;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Settings;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_WheelScrollLength;
        private System.Windows.Forms.TrackBar trackBar_WheelScrollLength;
        private System.Windows.Forms.TextBox textBox_WheelScrollLength;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.Label label_Mode;
    }
}

