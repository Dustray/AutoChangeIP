using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoChangeIP
{
    public partial class Form1 : Form
    {
        bool loopEnd = true, started = false, randomChange = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (tIP1.Text == "" || tIP2.Text == "" || tIP3.Text == "" || tIP4.Text == "")
            {
                MessageBox.Show("请填写IP");
                return;
            }
            else if (tGateWay.Text == "")
            {
                MessageBox.Show("请填写网关");
                return;
            }
            if (!started)
            {
                loopEnd = true;
                started = true;
                startBtn.Text = "停  止";
                startBtn.BackColor = Color.FromArgb(255, 192, 0, 0);

                tGateWay.Enabled = false;
                tIP1.Enabled = false;
                tIP2.Enabled = false;
                tIP3.Enabled = false;
                tIP4.Enabled = false;

                Thread thread = new Thread(loop);
                thread.IsBackground = true;//后台进程，随主线程关闭消亡
                thread.Start();
            }
            else
            {
                loopEnd = false;
                started = false;
                startBtn.Text = "继  续";
                startBtn.BackColor = Color.Green;


                tGateWay.Enabled = true;
                tIP1.Enabled = true;
                tIP2.Enabled = true;
                tIP3.Enabled = true;
                tIP4.Enabled = true;
            }
            //setIPaddress();
        }

        public void loop()
        {
            Random r = new Random();
            int rStart = 1, rEnd = 255;
            for (; loopEnd;)
            {
                int rs = 1;
                if (randomChange)
                {
                    //随机切换
                    rs = r.Next(rStart, rEnd);
                }
                else
                {
                    rs = Convert.ToInt32(tIP4.Text.ToString());
                    rs++;
                    if (rs > 255)
                    {
                        rs = 1;
                    }
                }
                tIP4.Text = "" + rs;
                if (rs == Convert.ToInt32(tGateWay.Text.ToString()))
                {

                    continue;
                }
                setIPaddress(rs);
                Thread.Sleep(1000 * Convert.ToInt32(trackSpeed.Value.ToString()));
            }
        }

        private void trackSpeed_Scroll(object sender, EventArgs e)
        {

            trackSpeedLabel.Text = "切换速度(当前" + trackSpeed.Value.ToString() + "秒)：";
        }

        private void changeMode_Click(object sender, EventArgs e)
        {
            if (randomChange)
            {
                //顺序切换
                changeMode.Text = "顺序切换";
                randomChange = false;
            }
            else
            {
                //随机切换
                changeMode.Text = "随机切换";
                randomChange = false;
            }
        }

        private void setIPaddress(int ip4)
        {
            string t1 = tIP1.Text.ToString(),
                t2 = tIP2.Text.ToString(),
                t3 = tIP3.Text.ToString();
            string ipAdd = t1 + "." + t2 + "." + t3 + "." + ip4;
            string subMark = "255.255.255.0";
            string gateWay = t1 + "." + t2 + "." + t3 + "." + tGateWay.Text.ToString();
            string dns = "202.102.154.3";
            //netsh interface ip set address WLAN static 192.168.31.2 255.255.255.0 192.168.31.1 1
            string docCMD = "netsh interface ip set address " + weblinkName.Text.ToString() + " static " + ipAdd + " " + subMark + " " + gateWay + " 1";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(docCMD.ToString());
            docCMD = "netsh interface ip set dns " + weblinkName.Text.ToString() + " static " + dns;
            //p.StandardInput.WriteLine(docCMD.ToString());

            p.StandardInput.WriteLine("exit");
            textShowLog.Text += "\r\n修改成功，当前：" + ipAdd + "\t我也不知道修改成功没，反正不报错...";
            textShowLog.Select(textShowLog.TextLength, 0);
            textShowLog.ScrollToCaret();
        }
    }
}
