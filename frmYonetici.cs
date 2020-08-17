//////////////////////////////////////////////////////////////////
//    					     			                        //
//                	Coded by Faruk OKSUZ			            //
//                              				                //
//////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgisayarOtomasyonu
{
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.; Initial Catalog=BilgisayarOtomasyonu; Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataAdapter dataAdapter;
        DataTable tablo;

        private void DataGridViewAktar()
        {
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM yonetici", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewYonetici.DataSource = tablo;
            baglanti.Close();
        }
        private void frmYonetici_Load(object sender, EventArgs e)
        {
            DataGridViewAktar();
        }

        private void dataGridViewYonetici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridViewYonetici.CurrentRow.Cells["yoneticiid"].Value.ToString();
            txtKullaniciAdi.Text = dataGridViewYonetici.CurrentRow.Cells["kuladi"].Value.ToString();
            txtSifre.Text = dataGridViewYonetici.CurrentRow.Cells["sifre"].Value.ToString();
            txtAd.Text = dataGridViewYonetici.CurrentRow.Cells["ad"].Value.ToString();
            txtSoyad.Text = dataGridViewYonetici.CurrentRow.Cells["soyad"].Value.ToString();
        }
        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO yonetici(yoneticiid,kuladi,sifre,ad,soyad,resim) VALUES(@yoneticiid,@kuladi,@sifre,@ad,@soyad,@resim)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yoneticiid", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@kuladi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            DataGridViewAktar();

        }
        private void btnYoneticiTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }
        private void btnYoneticiSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM yonetici WHERE yoneticiid=@yoneticiid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yoneticiid", Convert.ToInt32(txtID.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            DataGridViewAktar();
        }
        private void btnYoneticiGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE yonetici SET kuladi=@kuladi,sifre=@sifre,ad=@ad,soyad=@soyad WHERE yoneticiid=@yoneticiid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yoneticiid", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@kuladi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }
       
    }
}
