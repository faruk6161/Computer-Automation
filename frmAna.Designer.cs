namespace BilgisayarOtomasyonu
{
    partial class frmAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yoneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAnaSayfa = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yoneticiToolStripMenuItem,
            this.musteriToolStripMenuItem,
            this.urunToolStripMenuItem,
            this.satisToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yoneticiToolStripMenuItem
            // 
            this.yoneticiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yoneticiToolStripMenuItem.Name = "yoneticiToolStripMenuItem";
            this.yoneticiToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.yoneticiToolStripMenuItem.Text = "Yönetici İşlemleri";
            this.yoneticiToolStripMenuItem.Click += new System.EventHandler(this.yoneticiToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.musteriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.urunToolStripMenuItem.Text = "Ürün İşlemleri";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // satisToolStripMenuItem
            // 
            this.satisToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satisToolStripMenuItem.Name = "satisToolStripMenuItem";
            this.satisToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.satisToolStripMenuItem.Text = "Satış İşlemleri";
            this.satisToolStripMenuItem.Click += new System.EventHandler(this.satisToolStripMenuItem_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.cikisYapToolStripMenuItem.Text = "Otomasyondan Çıkış Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.cikisYapToolStripMenuItem_Click);
            // 
            // lblAnaSayfa
            // 
            this.lblAnaSayfa.AutoSize = true;
            this.lblAnaSayfa.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaSayfa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAnaSayfa.Location = new System.Drawing.Point(56, 43);
            this.lblAnaSayfa.Name = "lblAnaSayfa";
            this.lblAnaSayfa.Size = new System.Drawing.Size(683, 36);
            this.lblAnaSayfa.TabIndex = 3;
            this.lblAnaSayfa.Text = "BİLGİSAYAR OTOMASAYONUNA HOŞGELDİNİZ...";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::BilgisayarOtomasyonu.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 422);
            this.Controls.Add(this.lblAnaSayfa);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yoneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.Label lblAnaSayfa;
    }
}

