﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Magnet
{
    public partial class Main : Form
    {
        int setType = 1;

        int visitCount = 0;

        bool Minimized = true;

        StringBuilder uri;

        public Main()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
        }

        void Btant()
        {
            uri = new StringBuilder();

            uri.Append("http://www.btanf.com/search/");

            uri.Append(TextBt.Text);

            uri.Append("-hot-desc-1");

            OverRide(uri.ToString(), 12, 10);
        }

        void Btcherry()
        {
            uri = new StringBuilder();

            uri.Append("http://www.btcerises.net/search?keyword=");
            
            uri.Append(TextBt.Text);

            OverRide(uri.ToString(), 9, 11);
        }

        void Torrentkittyzw()
        {
            uri = new StringBuilder();

            uri.Append("http://www.torrentkittyzw.info/s/");

            uri.Append(TextBt.Text);

            OverRide(uri.ToString(), 28, 3);
        }

        void Feikebt()
        {
            uri = new StringBuilder();

            uri.Append("http://feikebt.org/s/");

            uri.Append(TextBt.Text);

            uri.Append(".html");

            FixEx(uri.ToString(), 1, 7);
        }

        void OverRide(string uri, int count, int row)
        {

#if DEBUG
            Fix(uri, count, row);
#else
            try
            {
                Fix(uri, count, row);
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
#endif

        }

        void Fix(string uri, int count, int row)
        {
            TextResponse.Clear();

            try
            {
                string response = NetHelp.WebClientGet(uri);

                string reg = @"[<].*?[>]";

                response = Regex.Replace(response, reg, "");

                TextResponse.Text = Regex.Replace(response, @"(?s)\n\s*\n", "\n");
            }
            catch (Exception e)
            {
                TextResponse.Text = e.ToString(); return;
            }

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

        void FixEx(string uri, int count, int row)
        {
            TextResponse.Clear();

            try
            {
                string response = NetHelp.WebClientGet(uri);

                TextResponse.Text = MyRegex.Span(response);
            }
            catch (Exception e)
            {
                TextResponse.Text = e.ToString(); return;
            }

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

                        Torrentkittyzw(); break;

                    case 4:

                        Feikebt(); break;

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

        private void BTantMenuItem_Click(object sender, EventArgs e)
        {
            setType = 1;
        }

        private void BtcherryMenuItem_Click(object sender, EventArgs e)
        {
            setType = 2;
        }

        private void TorrentkittyzwMenuItem_Click(object sender, EventArgs e)
        {
            setType = 3;
        }

        private void FeikebtMenuItem_Click(object sender, EventArgs e)
        {
            setType = 4;
        }
    }
}
