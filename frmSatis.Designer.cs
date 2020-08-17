namespace BilgisayarOtomasyonu
{
    partial class frmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.dataGridViewUrun = new System.Windows.Forms.DataGridView();
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.btnSatisGoster = new System.Windows.Forms.Button();
            this.btnSatisRaporla = new System.Windows.Forms.Button();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.btnUrunGoster = new System.Windows.Forms.Button();
            this.btnMusteriGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 145;
            this.label1.Text = "Satış ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 144;
            this.label3.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 143;
            this.label2.Text = "Ürün ID";
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(169, 22);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(178, 29);
            this.txtSatisID.TabIndex = 146;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(169, 57);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(178, 29);
            this.txtUrunID.TabIndex = 146;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(169, 92);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(178, 29);
            this.txtMusteriID.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(379, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 143;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 27);
            this.label5.TabIndex = 144;
            this.label5.Text = "Saat";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(462, 56);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(261, 29);
            this.txtSaat.TabIndex = 146;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(462, 21);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(261, 29);
            this.dateTimePickerTarih.TabIndex = 147;
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AllowUserToAddRows = false;
            this.dataGridViewMusteri.AllowUserToDeleteRows = false;
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(271, 163);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.ReadOnly = true;
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(686, 111);
            this.dataGridViewMusteri.TabIndex = 153;
            // 
            // dataGridViewUrun
            // 
            this.dataGridViewUrun.AllowUserToAddRows = false;
            this.dataGridViewUrun.AllowUserToDeleteRows = false;
            this.dataGridViewUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrun.Location = new System.Drawing.Point(271, 280);
            this.dataGridViewUrun.Name = "dataGridViewUrun";
            this.dataGridViewUrun.ReadOnly = true;
            this.dataGridViewUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrun.Size = new System.Drawing.Size(686, 111);
            this.dataGridViewUrun.TabIndex = 153;
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.AllowUserToAddRows = false;
            this.dataGridViewSatis.AllowUserToDeleteRows = false;
            this.dataGridViewSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(271, 397);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.ReadOnly = true;
            this.dataGridViewSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSatis.Size = new System.Drawing.Size(686, 111);
            this.dataGridViewSatis.TabIndex = 153;
            this.dataGridViewSatis.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSatis_CellEnter);
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnSatisGuncelle.Image = global::BilgisayarOtomasyonu.Properties.Resources.guncelle;
            this.btnSatisGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisGuncelle.Location = new System.Drawing.Point(38, 475);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(227, 33);
            this.btnSatisGuncelle.TabIndex = 154;
            this.btnSatisGuncelle.Text = "SATIŞ GÜNCELLE";
            this.btnSatisGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisGuncelle.UseVisualStyleBackColor = false;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisSil.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisSil.ForeColor = System.Drawing.Color.Black;
            this.btnSatisSil.Image = global::BilgisayarOtomasyonu.Properties.Resources.sil;
            this.btnSatisSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisSil.Location = new System.Drawing.Point(38, 436);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(227, 33);
            this.btnSatisSil.TabIndex = 154;
            this.btnSatisSil.Text = "SATIŞ SİL";
            this.btnSatisSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisSil.UseVisualStyleBackColor = false;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // btnSatisGoster
            // 
            this.btnSatisGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatisGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisGoster.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisGoster.ForeColor = System.Drawing.Color.Black;
            this.btnSatisGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisGoster.Image")));
            this.btnSatisGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisGoster.Location = new System.Drawing.Point(38, 397);
            this.btnSatisGoster.Name = "btnSatisGoster";
            this.btnSatisGoster.Size = new System.Drawing.Size(227, 33);
            this.btnSatisGoster.TabIndex = 152;
            this.btnSatisGoster.Text = "SATIŞ GÖSTER";
            this.btnSatisGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisGoster.UseVisualStyleBackColor = false;
            this.btnSatisGoster.Click += new System.EventHandler(this.btnSatisGoster_Click);
            // 
            // btnSatisRaporla
            // 
            this.btnSatisRaporla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatisRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisRaporla.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisRaporla.ForeColor = System.Drawing.Color.Black;
            this.btnSatisRaporla.Image = global::BilgisayarOtomasyonu.Properties.Resources.rapor;
            this.btnSatisRaporla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisRaporla.Location = new System.Drawing.Point(271, 514);
            this.btnSatisRaporla.Name = "btnSatisRaporla";
            this.btnSatisRaporla.Size = new System.Drawing.Size(225, 33);
            this.btnSatisRaporla.TabIndex = 151;
            this.btnSatisRaporla.Text = "SATIŞ RAPORLA";
            this.btnSatisRaporla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisRaporla.UseVisualStyleBackColor = false;
            this.btnSatisRaporla.Click += new System.EventHandler(this.btnSatisRaporla_Click);
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSatisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisEkle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSatisEkle.Image = global::BilgisayarOtomasyonu.Properties.Resources.ekle;
            this.btnSatisEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisEkle.Location = new System.Drawing.Point(462, 124);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(172, 33);
            this.btnSatisEkle.TabIndex = 150;
            this.btnSatisEkle.Text = "SATIŞ YAP";
            this.btnSatisEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisEkle.UseVisualStyleBackColor = false;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // btnUrunGoster
            // 
            this.btnUrunGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGoster.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGoster.ForeColor = System.Drawing.Color.Black;
            this.btnUrunGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunGoster.Image")));
            this.btnUrunGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGoster.Location = new System.Drawing.Point(38, 280);
            this.btnUrunGoster.Name = "btnUrunGoster";
            this.btnUrunGoster.Size = new System.Drawing.Size(227, 33);
            this.btnUrunGoster.TabIndex = 149;
            this.btnUrunGoster.Text = "ÜRÜN GÖSTER";
            this.btnUrunGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGoster.UseVisualStyleBackColor = false;
            this.btnUrunGoster.Click += new System.EventHandler(this.btnUrunGoster_Click);
            // 
            // btnMusteriGoster
            // 
            this.btnMusteriGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMusteriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGoster.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGoster.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGoster.Image")));
            this.btnMusteriGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriGoster.Location = new System.Drawing.Point(38, 163);
            this.btnMusteriGoster.Name = "btnMusteriGoster";
            this.btnMusteriGoster.Size = new System.Drawing.Size(227, 33);
            this.btnMusteriGoster.TabIndex = 148;
            this.btnMusteriGoster.Text = "MÜŞTERİ GÖSTER";
            this.btnMusteriGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGoster.UseVisualStyleBackColor = false;
            this.btnMusteriGoster.Click += new System.EventHandler(this.btnMusteriGoster_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 552);
            this.Controls.Add(this.btnSatisGuncelle);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.dataGridViewSatis);
            this.Controls.Add(this.dataGridViewUrun);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.btnSatisGoster);
            this.Controls.Add(this.btnSatisRaporla);
            this.Controls.Add(this.btnSatisEkle);
            this.Controls.Add(this.btnUrunGoster);
            this.Controls.Add(this.btnMusteriGoster);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtSatisID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSatis";
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button btnSatisGoster;
        private System.Windows.Forms.Button btnSatisRaporla;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.Button btnUrunGoster;
        private System.Windows.Forms.Button btnMusteriGoster;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.DataGridView dataGridViewUrun;
        private System.Windows.Forms.DataGridView dataGridViewSatis;
        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.Button btnSatisGuncelle;
    }
}