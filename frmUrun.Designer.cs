namespace BilgisayarOtomasyonu
{
    partial class frmUrun
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtAramaYap = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtOptikSurucu = new System.Windows.Forms.TextBox();
            this.txtDiskTip = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtEkranBoyutu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUrun = new System.Windows.Forms.DataGridView();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.btnGridDoldur = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCozunurluk = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEkOzellik = new System.Windows.Forms.TextBox();
            this.txtBluetooth = new System.Windows.Forms.TextBox();
            this.lblFotoYolu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(279, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 22);
            this.label15.TabIndex = 153;
            this.label15.Text = "Marka Üzerinden Arama Yap";
            // 
            // txtAramaYap
            // 
            this.txtAramaYap.Location = new System.Drawing.Point(525, 216);
            this.txtAramaYap.Name = "txtAramaYap";
            this.txtAramaYap.Size = new System.Drawing.Size(150, 20);
            this.txtAramaYap.TabIndex = 18;
            this.txtAramaYap.TextChanged += new System.EventHandler(this.txtAramaYap_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Image = global::BilgisayarOtomasyonu.Properties.Resources.temizle;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(683, 203);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(149, 35);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(188, 171);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(150, 20);
            this.txtRam.TabIndex = 6;
            // 
            // txtOptikSurucu
            // 
            this.txtOptikSurucu.Location = new System.Drawing.Point(523, 67);
            this.txtOptikSurucu.Name = "txtOptikSurucu";
            this.txtOptikSurucu.Size = new System.Drawing.Size(151, 20);
            this.txtOptikSurucu.TabIndex = 9;
            // 
            // txtDiskTip
            // 
            this.txtDiskTip.Location = new System.Drawing.Point(523, 40);
            this.txtDiskTip.Name = "txtDiskTip";
            this.txtDiskTip.Size = new System.Drawing.Size(151, 20);
            this.txtDiskTip.TabIndex = 8;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(524, 13);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(151, 20);
            this.txtCPU.TabIndex = 7;
            // 
            // txtEkranBoyutu
            // 
            this.txtEkranBoyutu.Location = new System.Drawing.Point(523, 126);
            this.txtEkranBoyutu.Name = "txtEkranBoyutu";
            this.txtEkranBoyutu.Size = new System.Drawing.Size(151, 20);
            this.txtEkranBoyutu.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(405, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 152;
            this.label7.Text = "Depolama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(53, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 151;
            this.label9.Text = "Ram Miktarı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(407, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 22);
            this.label12.TabIndex = 150;
            this.label12.Text = "Bluetooth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(382, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 22);
            this.label14.TabIndex = 149;
            this.label14.Text = "Optik Sürücü";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(380, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 22);
            this.label11.TabIndex = 148;
            this.label11.Text = "Ekran Boyutu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(396, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 147;
            this.label8.Text = "İşlemci Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(135, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 22);
            this.label5.TabIndex = 146;
            this.label5.Text = "ID";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "DELL",
            "CASPER",
            "LENOVO",
            "ASUS",
            "MSI",
            "MONSTER",
            "HP",
            "SAMSUNG",
            "TOSHIBA",
            "APPLE",
            "SONY"});
            this.cmbMarka.Location = new System.Drawing.Point(188, 40);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(151, 21);
            this.cmbMarka.TabIndex = 1;
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(188, 119);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.Size = new System.Drawing.Size(151, 20);
            this.txtGPU.TabIndex = 4;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(188, 93);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(151, 20);
            this.txtOS.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(188, 67);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(523, 152);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(151, 20);
            this.txtFiyat.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 145;
            this.label6.Text = "Ekran Kartı Modeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(101, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 143;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 142;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 141;
            this.label2.Text = "İşletim Sistemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(449, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 140;
            this.label1.Text = "Fiyat";
            // 
            // dataGridViewUrun
            // 
            this.dataGridViewUrun.AllowUserToAddRows = false;
            this.dataGridViewUrun.AllowUserToDeleteRows = false;
            this.dataGridViewUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewUrun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUrun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrun.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUrun.Location = new System.Drawing.Point(221, 253);
            this.dataGridViewUrun.Name = "dataGridViewUrun";
            this.dataGridViewUrun.ReadOnly = true;
            this.dataGridViewUrun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrun.Size = new System.Drawing.Size(843, 198);
            this.dataGridViewUrun.TabIndex = 158;
            this.dataGridViewUrun.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrun_CellEnter);
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPC.Location = new System.Drawing.Point(846, 12);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(218, 226);
            this.pictureBoxPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPC.TabIndex = 159;
            this.pictureBoxPC.TabStop = false;
            this.pictureBoxPC.Click += new System.EventHandler(this.pictureBoxPC_Click);
            // 
            // btnGridDoldur
            // 
            this.btnGridDoldur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGridDoldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridDoldur.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGridDoldur.Image = global::BilgisayarOtomasyonu.Properties.Resources.göster;
            this.btnGridDoldur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGridDoldur.Location = new System.Drawing.Point(12, 406);
            this.btnGridDoldur.Name = "btnGridDoldur";
            this.btnGridDoldur.Size = new System.Drawing.Size(203, 45);
            this.btnGridDoldur.TabIndex = 17;
            this.btnGridDoldur.Text = "GRİD DOLDUR";
            this.btnGridDoldur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGridDoldur.UseVisualStyleBackColor = false;
            this.btnGridDoldur.Click += new System.EventHandler(this.btnGridDoldur_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Image = global::BilgisayarOtomasyonu.Properties.Resources.sil;
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSil.Location = new System.Drawing.Point(12, 355);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(203, 45);
            this.btnUrunSil.TabIndex = 16;
            this.btnUrunSil.Text = "ÜRÜN SİL";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.Image = global::BilgisayarOtomasyonu.Properties.Resources.guncelle;
            this.btnUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(12, 304);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(203, 45);
            this.btnUrunGuncelle.TabIndex = 15;
            this.btnUrunGuncelle.Text = "ÜRÜN GÜNCELLE";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Image = global::BilgisayarOtomasyonu.Properties.Resources.ekle;
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunEkle.Location = new System.Drawing.Point(12, 253);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(203, 45);
            this.btnUrunEkle.TabIndex = 14;
            this.btnUrunEkle.Text = "ÜRÜN EKLE";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(0, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 22);
            this.label10.TabIndex = 145;
            this.label10.Text = "Ekran Cözünürlüğü";
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(188, 145);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(151, 20);
            this.txtCozunurluk.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(679, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 22);
            this.label13.TabIndex = 148;
            this.label13.Text = "Özellik ve Port Bil.";
            // 
            // txtEkOzellik
            // 
            this.txtEkOzellik.Location = new System.Drawing.Point(681, 40);
            this.txtEkOzellik.Multiline = true;
            this.txtEkOzellik.Name = "txtEkOzellik";
            this.txtEkOzellik.Size = new System.Drawing.Size(151, 99);
            this.txtEkOzellik.TabIndex = 12;
            // 
            // txtBluetooth
            // 
            this.txtBluetooth.Location = new System.Drawing.Point(523, 97);
            this.txtBluetooth.Name = "txtBluetooth";
            this.txtBluetooth.Size = new System.Drawing.Size(151, 20);
            this.txtBluetooth.TabIndex = 10;
            // 
            // lblFotoYolu
            // 
            this.lblFotoYolu.AutoSize = true;
            this.lblFotoYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoYolu.Location = new System.Drawing.Point(522, 178);
            this.lblFotoYolu.Name = "lblFotoYolu";
            this.lblFotoYolu.Size = new System.Drawing.Size(0, 13);
            this.lblFotoYolu.TabIndex = 160;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 469);
            this.Controls.Add(this.lblFotoYolu);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.dataGridViewUrun);
            this.Controls.Add(this.btnGridDoldur);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAramaYap);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtEkOzellik);
            this.Controls.Add(this.txtOptikSurucu);
            this.Controls.Add(this.txtDiskTip);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtBluetooth);
            this.Controls.Add(this.txtEkranBoyutu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtCozunurluk);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUrun";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAramaYap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtOptikSurucu;
        private System.Windows.Forms.TextBox txtDiskTip;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtEkranBoyutu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGridDoldur;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DataGridView dataGridViewUrun;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCozunurluk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEkOzellik;
        private System.Windows.Forms.TextBox txtBluetooth;
        private System.Windows.Forms.Label lblFotoYolu;
    }
}