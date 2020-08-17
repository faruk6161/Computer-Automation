namespace BilgisayarOtomasyonu
{
    partial class frmMusteri
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
            this.radioButtonKadın = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteriAdres = new System.Windows.Forms.Label();
            this.txtMusteriMail = new System.Windows.Forms.Label();
            this.txtMusteriTel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriID = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriTcNo = new System.Windows.Forms.Label();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriTemizle = new System.Windows.Forms.Button();
            this.btnMusteriDoldur = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonKadın
            // 
            this.radioButtonKadın.AutoSize = true;
            this.radioButtonKadın.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonKadın.Location = new System.Drawing.Point(542, 24);
            this.radioButtonKadın.Name = "radioButtonKadın";
            this.radioButtonKadın.Size = new System.Drawing.Size(88, 31);
            this.radioButtonKadın.TabIndex = 104;
            this.radioButtonKadın.TabStop = true;
            this.radioButtonKadın.Text = "Kadın";
            this.radioButtonKadın.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonErkek.Location = new System.Drawing.Point(463, 24);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(85, 31);
            this.radioButtonErkek.TabIndex = 103;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(366, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 99;
            this.label6.Text = "Cinsiyet";
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.AutoSize = true;
            this.txtMusteriAdres.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdres.Location = new System.Drawing.Point(382, 120);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(76, 27);
            this.txtMusteriAdres.TabIndex = 98;
            this.txtMusteriAdres.Text = "Adres ";
            // 
            // txtMusteriMail
            // 
            this.txtMusteriMail.AutoSize = true;
            this.txtMusteriMail.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriMail.Location = new System.Drawing.Point(396, 90);
            this.txtMusteriMail.Name = "txtMusteriMail";
            this.txtMusteriMail.Size = new System.Drawing.Size(57, 27);
            this.txtMusteriMail.TabIndex = 97;
            this.txtMusteriMail.Text = "Mail";
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.AutoSize = true;
            this.txtMusteriTel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTel.Location = new System.Drawing.Point(410, 58);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(43, 27);
            this.txtMusteriTel.TabIndex = 95;
            this.txtMusteriTel.Text = "Tel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 94;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.AutoSize = true;
            this.txtMusteriID.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(142, 25);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(35, 27);
            this.txtMusteriID.TabIndex = 93;
            this.txtMusteriID.Text = "ID";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(207, 119);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 22);
            this.txtSoyad.TabIndex = 91;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(207, 89);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 22);
            this.txtAd.TabIndex = 90;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcNo.Location = new System.Drawing.Point(207, 59);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(149, 22);
            this.txtTcNo.TabIndex = 89;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(207, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 22);
            this.txtID.TabIndex = 88;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.AutoSize = true;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(104, 112);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(73, 27);
            this.txtMusteriSoyad.TabIndex = 87;
            this.txtMusteriSoyad.Text = "Soyad";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.AutoSize = true;
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(137, 85);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(40, 27);
            this.txtMusteriAd.TabIndex = 86;
            this.txtMusteriAd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 85;
            this.label2.Text = "Doğum Tarihi";
            // 
            // txtMusteriTcNo
            // 
            this.txtMusteriTcNo.AutoSize = true;
            this.txtMusteriTcNo.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTcNo.Location = new System.Drawing.Point(103, 55);
            this.txtMusteriTcNo.Name = "txtMusteriTcNo";
            this.txtMusteriTcNo.Size = new System.Drawing.Size(74, 27);
            this.txtMusteriTcNo.TabIndex = 84;
            this.txtMusteriTcNo.Text = "TC No";
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AllowUserToAddRows = false;
            this.dataGridViewMusteri.AllowUserToDeleteRows = false;
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(299, 214);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.ReadOnly = true;
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(534, 237);
            this.dataGridViewMusteri.TabIndex = 128;
            this.dataGridViewMusteri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteri_CellEnter);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(463, 61);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(167, 22);
            this.txtTel.TabIndex = 91;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(463, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 22);
            this.txtEmail.TabIndex = 91;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(463, 125);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(167, 68);
            this.txtAdres.TabIndex = 91;
            // 
            // btnMusteriTemizle
            // 
            this.btnMusteriTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMusteriTemizle.Image = global::BilgisayarOtomasyonu.Properties.Resources.temizle;
            this.btnMusteriTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriTemizle.Location = new System.Drawing.Point(14, 418);
            this.btnMusteriTemizle.Name = "btnMusteriTemizle";
            this.btnMusteriTemizle.Size = new System.Drawing.Size(279, 33);
            this.btnMusteriTemizle.TabIndex = 133;
            this.btnMusteriTemizle.Text = "TEMİZLE";
            this.btnMusteriTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriTemizle.UseVisualStyleBackColor = false;
            this.btnMusteriTemizle.Click += new System.EventHandler(this.btnMusteriTemizle_Click);
            // 
            // btnMusteriDoldur
            // 
            this.btnMusteriDoldur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriDoldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriDoldur.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriDoldur.Image = global::BilgisayarOtomasyonu.Properties.Resources.göster;
            this.btnMusteriDoldur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriDoldur.Location = new System.Drawing.Point(12, 367);
            this.btnMusteriDoldur.Name = "btnMusteriDoldur";
            this.btnMusteriDoldur.Size = new System.Drawing.Size(281, 33);
            this.btnMusteriDoldur.TabIndex = 132;
            this.btnMusteriDoldur.Text = "GRİD DOLDUR";
            this.btnMusteriDoldur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriDoldur.UseVisualStyleBackColor = false;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSil.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.Image = global::BilgisayarOtomasyonu.Properties.Resources.sil;
            this.btnMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSil.Location = new System.Drawing.Point(12, 316);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(281, 33);
            this.btnMusteriSil.TabIndex = 131;
            this.btnMusteriSil.Text = "MÜSTERİ SİL";
            this.btnMusteriSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.Image = global::BilgisayarOtomasyonu.Properties.Resources.guncelle;
            this.btnMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(14, 265);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(279, 33);
            this.btnMusteriGuncelle.TabIndex = 130;
            this.btnMusteriGuncelle.Text = "MÜSTERİ GÜNCELLE";
            this.btnMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Image = global::BilgisayarOtomasyonu.Properties.Resources.ekle;
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 214);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(281, 33);
            this.btnMusteriEkle.TabIndex = 129;
            this.btnMusteriEkle.Text = "MÜSTERİ EKLE";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 468);
            this.Controls.Add(this.btnMusteriTemizle);
            this.Controls.Add(this.btnMusteriDoldur);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.radioButtonKadın);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.txtMusteriMail);
            this.Controls.Add(this.txtMusteriTel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriTcNo);
            this.Name = "frmMusteri";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonKadın;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtMusteriAdres;
        private System.Windows.Forms.Label txtMusteriMail;
        private System.Windows.Forms.Label txtMusteriTel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtMusteriID;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtMusteriSoyad;
        private System.Windows.Forms.Label txtMusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMusteriTcNo;
        private System.Windows.Forms.Button btnMusteriTemizle;
        private System.Windows.Forms.Button btnMusteriDoldur;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
    }
}