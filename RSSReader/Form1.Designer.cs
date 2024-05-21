namespace RSSReader
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lst_baslik = new System.Windows.Forms.ListBox();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rssurl);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Location = new System.Drawing.Point(-6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(6, 20);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(787, 20);
            this.txt_rssurl.TabIndex = 1;
            this.txt_rssurl.Text = "http://www.sabah.com.tr/rss/spor.xml";
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(799, 20);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(95, 23);
            this.btn_getir.TabIndex = 0;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lst_baslik
            // 
            this.lst_baslik.FormattingEnabled = true;
            this.lst_baslik.Location = new System.Drawing.Point(6, 19);
            this.lst_baslik.Name = "lst_baslik";
            this.lst_baslik.Size = new System.Drawing.Size(188, 446);
            this.lst_baslik.TabIndex = 3;
            this.lst_baslik.SelectedIndexChanged += new System.EventHandler(this.lst_baslik_SelectedIndexChanged);
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(3, 16);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(705, 454);
            this.web_browser.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_browser);
            this.groupBox3.Location = new System.Drawing.Point(200, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 473);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_baslik);
            this.groupBox2.Location = new System.Drawing.Point(-6, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 473);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.ListBox lst_baslik;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

