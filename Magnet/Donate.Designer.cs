namespace Magnet
{
    partial class Donate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.Alipay = new System.Windows.Forms.PictureBox();
            this.Wechat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Alipay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wechat)).BeginInit();
            this.SuspendLayout();
            // 
            // Alipay
            // 
            this.Alipay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Alipay.Image = global::Magnet.Properties.Resources.Alipay;
            this.Alipay.Location = new System.Drawing.Point(52, 73);
            this.Alipay.Name = "Alipay";
            this.Alipay.Size = new System.Drawing.Size(246, 228);
            this.Alipay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alipay.TabIndex = 0;
            this.Alipay.TabStop = false;
            // 
            // Wechat
            // 
            this.Wechat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Wechat.Image = ((System.Drawing.Image)(resources.GetObject("Wechat.Image")));
            this.Wechat.Location = new System.Drawing.Point(405, 73);
            this.Wechat.Name = "Wechat";
            this.Wechat.Size = new System.Drawing.Size(228, 228);
            this.Wechat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Wechat.TabIndex = 1;
            this.Wechat.TabStop = false;
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 392);
            this.Controls.Add(this.Wechat);
            this.Controls.Add(this.Alipay);
            this.Name = "Donate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "捐助";
            ((System.ComponentModel.ISupportInitialize)(this.Alipay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wechat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Alipay;
        private System.Windows.Forms.PictureBox Wechat;
    }
}