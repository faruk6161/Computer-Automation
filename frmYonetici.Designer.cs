namespace BilgisayarOtomasyonu
{
    partial class frmYonetici
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
            this.txtYoneticiSoyad = new System.Windows.Forms.Label();
            this.txtYoneticiAd = new System.Windows.Forms.Label();
            this.txtYoneticiSifre = new System.Windows.Forms.Label();
            this.txtYoneticiKulAdi = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridViewYonetici = new System.Windows.Forms.DataGridView();
            this.txtYoneticiID = new System.Windows.Forms.Label();
            this.btnYoneticiTemizle = new System.Windows.Forms.Button();
            this.btnYoneticiSil = new System.Windows.Forms.Button();
            this.btnYoneticiGuncelle = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYoneticiSoyad
            // 
            this.txtYoneticiSoyad.AutoSize = true;
            this.txtYoneticiSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiSoyad.Location = new System.Drawing.Point(370, 102);
            this.txtYoneticiSoyad.Name = "txtYoneticiSoyad";
            this.txtYoneticiSoyad.Size = new System.Drawing.Size(73, 27);
            this.txtYoneticiSoyad.TabIndex = 133;
            this.txtYoneticiSoyad.Text = "Soyad";
            // 
            // txtYoneticiAd
            // 
            this.txtYoneticiAd.AutoSize = true;
            this.txtYoneticiAd.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiAd.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiAd.Location = new System.Drawing.Point(403, 70);
            this.txtYoneticiAd.Name = "txtYoneticiAd";
            this.txtYoneticiAd.Size = new System.Drawing.Size(40, 27);
            this.txtYoneticiAd.TabIndex = 132;
            this.txtYoneticiAd.Text = "Ad";
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.AutoSize = true;
            this.txtYoneticiSifre.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSifre.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiSifre.Location = new System.Drawing.Point(95, 102);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.Size = new System.Drawing.Size(58, 27);
            this.txtYoneticiSifre.TabIndex = 131;
            this.txtYoneticiSifre.Text = "Sifre";
            // 
            // txtYoneticiKulAdi
            // 
            this.txtYoneticiKulAdi.AutoSize = true;
            this.txtYoneticiKulAdi.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiKulAdi.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiKulAdi.Location = new System.Drawing.Point(15, 76);
            this.txtYoneticiKulAdi.Name = "txtYoneticiKulAdi";
            this.txtYoneticiKulAdi.Size = new System.Drawing.Size(138, 27);
            this.txtYoneticiKulAdi.TabIndex = 130;
            this.txtYoneticiKulAdi.Text = "Kullanıcı Adı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(449, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 22);
            this.txtSoyad.TabIndex = 129;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(449, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 22);
            this.txtAd.TabIndex = 128;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(166, 104);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 22);
            this.txtSifre.TabIndex = 127;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(166, 78);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(196, 22);
            this.txtKullaniciAdi.TabIndex = 126;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(166, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 22);
            this.txtID.TabIndex = 125;
            // 
            // dataGridViewYonetici
            // 
            this.dataGridViewYonetici.AllowUserToAddRows = false;
            this.dataGridViewYonetici.AllowUserToDeleteRows = false;
            this.dataGridViewYonetici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYonetici.Location = new System.Drawing.Point(12, 153);
            this.dataGridViewYonetici.Name = "dataGridViewYonetici";
            this.dataGridViewYonetici.ReadOnly = true;
            this.dataGridViewYonetici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYonetici.Size = new System.Drawing.Size(567, 150);
            this.dataGridViewYonetici.TabIndex = 136;
            this.dataGridViewYonetici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYonetici_CellEnter);
            // 
            // txtYoneticiID
            // 
            this.txtYoneticiID.AutoSize = true;
            this.txtYoneticiID.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiID.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiID.Location = new System.Drawing.Point(121, 51);
            this.txtYoneticiID.Name = "txtYoneticiID";
            this.txtYoneticiID.Size = new System.Drawing.Size(32, 27);
            this.txtYoneticiID.TabIndex = 142;
            this.txtYoneticiID.Text = "Id";
            // 
            // btnYoneticiTemizle
            // 
            this.btnYoneticiTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnYoneticiTemizle.Image = global::BilgisayarOtomasyonu.Properties.Resources.temizle;
            this.btnYoneticiTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiTemizle.Location = new System.Drawing.Point(584, 231);
            this.btnYoneticiTemizle.Name = "btnYoneticiTemizle";
            this.btnYoneticiTemizle.Size = new System.Drawing.Size(276, 33);
            this.btnYoneticiTemizle.TabIndex = 141;
            this.btnYoneticiTemizle.Text = "TEMİZLE";
            this.btnYoneticiTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiTemizle.UseVisualStyleBackColor = false;
            this.btnYoneticiTemizle.Click += new System.EventHandler(this.btnYoneticiTemizle_Click);
            // 
            // btnYoneticiSil
            // 
            this.btnYoneticiSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiSil.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiSil.ForeColor = System.Drawing.Color.Black;
            this.btnYoneticiSil.Image = global::BilgisayarOtomasyonu.Properties.Resources.sil;
            this.btnYoneticiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiSil.Location = new System.Drawing.Point(584, 270);
            this.btnYoneticiSil.Name = "btnYoneticiSil";
            this.btnYoneticiSil.Size = new System.Drawing.Size(276, 33);
            this.btnYoneticiSil.TabIndex = 139;
            this.btnYoneticiSil.Text = "YÖNETİCİ SİL";
            this.btnYoneticiSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiSil.UseVisualStyleBackColor = false;
            this.btnYoneticiSil.Click += new System.EventHandler(this.btnYoneticiSil_Click);
            // 
            // btnYoneticiGuncelle
            // 
            this.btnYoneticiGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnYoneticiGuncelle.Image = global::BilgisayarOtomasyonu.Properties.Resources.guncelle;
            this.btnYoneticiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiGuncelle.Location = new System.Drawing.Point(584, 192);
            this.btnYoneticiGuncelle.Name = "btnYoneticiGuncelle";
            this.btnYoneticiGuncelle.Size = new System.Drawing.Size(276, 33);
            this.btnYoneticiGuncelle.TabIndex = 138;
            this.btnYoneticiGuncelle.Text = "YÖNETİCİ GÜNCELLE";
            this.btnYoneticiGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiGuncelle.UseVisualStyleBackColor = false;
            this.btnYoneticiGuncelle.Click += new System.EventHandler(this.btnYoneticiGuncelle_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiEkle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiEkle.ForeColor = System.Drawing.Color.Black;
            this.btnYoneticiEkle.Image = global::BilgisayarOtomasyonu.Properties.Resources.ekle;
            this.btnYoneticiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(584, 153);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(276, 33);
            this.btnYoneticiEkle.TabIndex = 137;
            this.btnYoneticiEkle.Text = "YÖNETİCİ EKLE";
            this.btnYoneticiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiEkle.UseVisualStyleBackColor = false;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 319);
            this.Controls.Add(this.txtYoneticiID);
            this.Controls.Add(this.btnYoneticiTemizle);
            this.Controls.Add(this.btnYoneticiSil);
            this.Controls.Add(this.btnYoneticiGuncelle);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.dataGridViewYonetici);
            this.Controls.Add(this.txtYoneticiSoyad);
            this.Controls.Add(this.txtYoneticiAd);
            this.Controls.Add(this.txtYoneticiSifre);
            this.Controls.Add(this.txtYoneticiKulAdi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtID);
            this.Name = "frmYonetici";
            this.Text = "Yönetici İşlemleri";
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtYoneticiSoyad;
        private System.Windows.Forms.Label txtYoneticiAd;
        private System.Windows.Forms.Label txtYoneticiSifre;
        private System.Windows.Forms.Label txtYoneticiKulAdi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnYoneticiTemizle;
        private System.Windows.Forms.Button btnYoneticiSil;
        private System.Windows.Forms.Button btnYoneticiGuncelle;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.DataGridView dataGridViewYonetici;
        private System.Windows.Forms.Label txtYoneticiID;
    }
}