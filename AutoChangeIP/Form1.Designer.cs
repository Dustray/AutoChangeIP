namespace AutoChangeIP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tIP1 = new System.Windows.Forms.TextBox();
            this.tIP2 = new System.Windows.Forms.TextBox();
            this.tIP3 = new System.Windows.Forms.TextBox();
            this.tIP4 = new System.Windows.Forms.TextBox();
            this.textShowLog = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weblinkName = new System.Windows.Forms.TextBox();
            this.trackSpeedLabel = new System.Windows.Forms.Label();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.changeMode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tGateWay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tIP1
            // 
            this.tIP1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tIP1.Location = new System.Drawing.Point(94, 67);
            this.tIP1.Name = "tIP1";
            this.tIP1.Size = new System.Drawing.Size(50, 34);
            this.tIP1.TabIndex = 0;
            this.tIP1.Text = "192";
            // 
            // tIP2
            // 
            this.tIP2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tIP2.Location = new System.Drawing.Point(175, 67);
            this.tIP2.Name = "tIP2";
            this.tIP2.Size = new System.Drawing.Size(50, 34);
            this.tIP2.TabIndex = 1;
            this.tIP2.Text = "168";
            // 
            // tIP3
            // 
            this.tIP3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tIP3.Location = new System.Drawing.Point(256, 67);
            this.tIP3.Name = "tIP3";
            this.tIP3.Size = new System.Drawing.Size(50, 34);
            this.tIP3.TabIndex = 2;
            this.tIP3.Text = "31";
            // 
            // tIP4
            // 
            this.tIP4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tIP4.Location = new System.Drawing.Point(337, 67);
            this.tIP4.Name = "tIP4";
            this.tIP4.Size = new System.Drawing.Size(50, 34);
            this.tIP4.TabIndex = 3;
            this.tIP4.Text = "1";
            // 
            // textShowLog
            // 
            this.textShowLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textShowLog.Location = new System.Drawing.Point(12, 174);
            this.textShowLog.Multiline = true;
            this.textShowLog.Name = "textShowLog";
            this.textShowLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textShowLog.Size = new System.Drawing.Size(776, 264);
            this.textShowLog.TabIndex = 4;
            this.textShowLog.Text = "日志：";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.Green;
            this.startBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(647, 120);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(141, 43);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "开  始";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(150, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(312, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "连接名：";
            // 
            // weblinkName
            // 
            this.weblinkName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weblinkName.Location = new System.Drawing.Point(94, 18);
            this.weblinkName.Name = "weblinkName";
            this.weblinkName.Size = new System.Drawing.Size(293, 34);
            this.weblinkName.TabIndex = 11;
            this.weblinkName.Text = "本地连接1";
            // 
            // trackSpeedLabel
            // 
            this.trackSpeedLabel.AutoSize = true;
            this.trackSpeedLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trackSpeedLabel.Location = new System.Drawing.Point(12, 130);
            this.trackSpeedLabel.Name = "trackSpeedLabel";
            this.trackSpeedLabel.Size = new System.Drawing.Size(199, 20);
            this.trackSpeedLabel.TabIndex = 12;
            this.trackSpeedLabel.Text = "切换速度(当前1秒)：";
            // 
            // trackSpeed
            // 
            this.trackSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSpeed.Location = new System.Drawing.Point(217, 118);
            this.trackSpeed.Maximum = 60;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(424, 56);
            this.trackSpeed.TabIndex = 13;
            this.trackSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackSpeed.Value = 1;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // changeMode
            // 
            this.changeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMode.Location = new System.Drawing.Point(647, 68);
            this.changeMode.Name = "changeMode";
            this.changeMode.Size = new System.Drawing.Size(141, 33);
            this.changeMode.TabIndex = 14;
            this.changeMode.Text = "随机切换";
            this.changeMode.UseVisualStyleBackColor = true;
            this.changeMode.Click += new System.EventHandler(this.changeMode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "（适配器选项中的连接名）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "（网关为：       ）";
            // 
            // tGateWay
            // 
            this.tGateWay.Location = new System.Drawing.Point(481, 72);
            this.tGateWay.Name = "tGateWay";
            this.tGateWay.Size = new System.Drawing.Size(40, 25);
            this.tGateWay.TabIndex = 17;
            this.tGateWay.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tGateWay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changeMode);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.trackSpeedLabel);
            this.Controls.Add(this.weblinkName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.textShowLog);
            this.Controls.Add(this.tIP4);
            this.Controls.Add(this.tIP3);
            this.Controls.Add(this.tIP2);
            this.Controls.Add(this.tIP1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时改局域网IP（Developed by Dustray）";
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tIP1;
        private System.Windows.Forms.TextBox tIP2;
        private System.Windows.Forms.TextBox tIP3;
        private System.Windows.Forms.TextBox tIP4;
        private System.Windows.Forms.TextBox textShowLog;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weblinkName;
        private System.Windows.Forms.Label trackSpeedLabel;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Button changeMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tGateWay;
    }
}

