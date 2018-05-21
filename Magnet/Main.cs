using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Magnet;

namespace Magnet
{
    public partial class Main : Form
    {
        int setType = 1;

        int visitCount = 0;

        bool Minimized = true;

        public Main()
        {
            InitializeComponent();
        }

        private void Btant()
        {
            string uri = "http://www.btanf.com/search/" + TextBt.Text + "-hot-desc-1";

            OverRide(uri, 12, 10);
        }

        private void Torrentkittyzw()
        {
            string uri = "http://www.torrentkittyzw.info/s/" + TextBt.Text;

            OverRide(uri, 28, 3);
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

                TextResponse.Text = "请求超时，可能网站已经凉了(" + visitCount + "次)";
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

                        Torrentkittyzw(); break;

                    case 3:

                        ; break;

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

        private void BTantMenuItem_Click(object sender, EventArgs e)
        {
            setType = 1;
        }

        private void TorrentkittyzwMenuItem_Click(object sender, EventArgs e)
        {
            setType = 2;
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
    }
}
