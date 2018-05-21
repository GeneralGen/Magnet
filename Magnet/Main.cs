using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Magnet
{
    public partial class Main : Form
    {
        private int setType = 1;

        private int visitCount = 0;

        private bool Minimized = true;

        private StringBuilder uri;

        public Main()
        {
            InitializeComponent();
        }

        private void Btant()
        {
            uri = new StringBuilder();

            uri.Append("http://www.btanf.com/search/");

            uri.Append(TextBt.Text);

            uri.Append("-hot-desc-1");

            OverRide(uri.ToString(), 12, 10);
        }

        private void Btcherry()
        {
            uri = new StringBuilder();

            uri.Append("http://www.btcerises.com/search?keyword=");

            uri.Append(TextBt.Text);

            OverRide(uri.ToString(), 9, 11);
        }

        private void Torrentkitty()
        {
            uri = new StringBuilder();

            uri.Append("");

            uri.Append(TextBt.Text);

            OverRide(uri.ToString(), 187, 1);
        }

        private void OverRide(string uri, int count, int row)
        {
            try
            {
                TextResponse.Clear();

                string response = NetHelp.WebClientGet(uri);

                string reg = @"[<].*?[>]";

                response = Regex.Replace(response, reg, "");

                TextResponse.Text = Regex.Replace(response, @"(?s)\n\s*\n", "\n");

                List<string> lines = new List<string>();

                StringBuilder text = new StringBuilder();

                lines = TextResponse.Lines.ToList();

                lines.RemoveRange(0, count);

                int i = 0;

                foreach (var item in lines)
                {
                    i += 1;

                    text.AppendLine(item);

                    if (i % row == 0)
                    {
                        text.AppendLine();
                    }
                }

                TextResponse.Text = text.ToString();
            }
            catch (Exception)
            {
                visitCount += 1;

                StringBuilder info = new StringBuilder();

                info.Append("请求超时，可能网站已经凉了(");

                info.Append(visitCount);

                info.Append("次)");

                TextResponse.Text = info.ToString();
            }
        }

        private void TextBt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (setType)
                {
                    case 1:

                        Btant(); break;

                    case 2:

                        Btcherry(); break;

                    case 3:

                        Torrentkitty(); break;

                    case 4:

                        ; break;

                    default:

                        break;
                }
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                NotifyIcon.Visible = true;

                this.Hide();

                if (Minimized)
                {
                    NotifyIcon.ShowBalloonTip(3000, "双击显示", "已隐藏到托盘", ToolTipIcon.Info);

                    Minimized = false;
                }
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            new Donate().ShowDialog();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            TextResponse.Copy();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;

            this.Show();

            this.WindowState = FormWindowState.Normal;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;

            this.Show();

            this.WindowState = FormWindowState.Normal;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GcHelp.ClearMemory();
        }

        private void BTantMenuItem_Click(object sender, EventArgs e)
        {
            setType = 1;
        }

        private void BtcherryMenuItem_Click(object sender, EventArgs e)
        {
            setType = 2;
        }
    }
}
