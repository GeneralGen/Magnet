namespace Magnet
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TextResponse = new System.Windows.Forms.RichTextBox();
            this.FormMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBt = new System.Windows.Forms.TextBox();
            this.NotifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Choice = new System.Windows.Forms.ToolStripMenuItem();
            this.BtantMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtcherryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TorrentkittyzwMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.FormMenuStrip.SuspendLayout();
            this.NotifyMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextResponse
            // 
            this.TextResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextResponse.ContextMenuStrip = this.FormMenuStrip;
            this.TextResponse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextResponse.Location = new System.Drawing.Point(12, 58);
            this.TextResponse.Name = "TextResponse";
            this.TextResponse.Size = new System.Drawing.Size(889, 481);
            this.TextResponse.TabIndex = 5;
            this.TextResponse.Text = "";
            // 
            // FormMenuStrip
            // 
            this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy});
            this.FormMenuStrip.Name = "MenuStrip";
            this.FormMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(100, 22);
            this.Copy.Text = "复制";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(212, 31);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(149, 12);
            this.LabelSearch.TabIndex = 4;
            this.LabelSearch.Text = "（回车搜索）输入关键字：";
            // 
            // TextBt
            // 
            this.TextBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBt.Location = new System.Drawing.Point(367, 28);
            this.TextBt.Name = "TextBt";
            this.TextBt.Size = new System.Drawing.Size(308, 21);
            this.TextBt.TabIndex = 3;
            this.TextBt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBt_KeyPress);
            // 
            // NotifyMenuStrip
            // 
            this.NotifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMenuItem,
            this.ExitMenuItem});
            this.NotifyMenuStrip.Name = "NotifyMenuStrip";
            this.NotifyMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Name = "ShowMenuItem";
            this.ShowMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ShowMenuItem.Text = "显示";
            this.ShowMenuItem.Click += new System.EventHandler(this.ShowMenuItem_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.Choice});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(913, 25);
            this.MenuStrip.TabIndex = 6;
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(44, 21);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Choice
            // 
            this.Choice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtantMenuItem,
            this.BtcherryMenuItem,
            this.TorrentkittyzwMenuItem});
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(92, 21);
            this.Choice.Text = "更换搜索引擎";
            // 
            // BtantMenuItem
            // 
            this.BtantMenuItem.Name = "BtantMenuItem";
            this.BtantMenuItem.Size = new System.Drawing.Size(158, 22);
            this.BtantMenuItem.Text = "BTant";
            this.BtantMenuItem.Click += new System.EventHandler(this.BTantMenuItem_Click);
            // 
            // BtcherryMenuItem
            // 
            this.BtcherryMenuItem.Name = "BtcherryMenuItem";
            this.BtcherryMenuItem.Size = new System.Drawing.Size(158, 22);
            this.BtcherryMenuItem.Text = "Btcherry";
            this.BtcherryMenuItem.Click += new System.EventHandler(this.BtcherryMenuItem_Click);
            // 
            // TorrentkittyzwMenuItem
            // 
            this.TorrentkittyzwMenuItem.Name = "TorrentkittyzwMenuItem";
            this.TorrentkittyzwMenuItem.Size = new System.Drawing.Size(158, 22);
            this.TorrentkittyzwMenuItem.Text = "Torrentkittyzw";
            this.TorrentkittyzwMenuItem.Click += new System.EventHandler(this.TorrentkittyzwMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 551);
            this.ContextMenuStrip = this.NotifyMenuStrip;
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TextResponse);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "飙车党出品";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.FormMenuStrip.ResumeLayout(false);
            this.NotifyMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextResponse;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBt;
        private System.Windows.Forms.ContextMenuStrip NotifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip FormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Choice;
        private System.Windows.Forms.ToolStripMenuItem BtantMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtcherryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem TorrentkittyzwMenuItem;
    }
}

