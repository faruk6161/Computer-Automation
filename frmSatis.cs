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
    public partial class frmSatis : Form
    {
        public frmSatis()
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
            dataAdapter = new SqlDataAdapter("SELECT * FROM satis", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewSatis.DataSource = tablo;
            baglanti.Close();
        }
        private void frmSatis_Load(object sender, EventArgs e)
        {

        }
        private void btnMusteriGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM musteri", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewMusteri.DataSource = tablo;
            baglanti.Close();
        }

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM urun", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewUrun.DataSource = tablo;
            baglanti.Close();
        }

        private void btnSatisGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM satis", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewSatis.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridViewSatis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisID.Text = dataGridViewSatis.CurrentRow.Cells["satisid"].Value.ToString();
            txtMusteriID.Text = dataGridViewSatis.CurrentRow.Cells["musteriid"].Value.ToString();
            txtUrunID.Text = dataGridViewSatis.CurrentRow.Cells["urunid"].Value.ToString();
            dateTimePickerTarih.Text = dataGridViewSatis.CurrentRow.Cells["tarih"].Value.ToString();
            txtSaat.Text = dataGridViewSatis.CurrentRow.Cells["saat"].Value.ToString();
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM satis WHERE satisid=@satisid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@satisid", Convert.ToInt32(txtSatisID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE satis SET musteriid=@musteriid , urunid=@urunid , tarih=@tarih saat=@saat WHERE satisid=@satisid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@satisid", Convert.ToInt32(txtSatisID.Text));
            komut.Parameters.AddWithValue("@musteriid", Convert.ToInt32(txtMusteriID.Text));
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtUrunID.Text));
            komut.Parameters.AddWithValue("@tarih", dateTimePickerTarih.Value);
            komut.Parameters.AddWithValue("@saat", txtSaat.Text);  
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO satis(satisid,musteriid,urunid,tarih,saat) VALUES(@satisid,@musteriid,@urunid,@tarih,@saat)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@satisid", Convert.ToInt32(txtSatisID.Text));
            komut.Parameters.AddWithValue("@musteriid", Convert.ToInt32(txtMusteriID.Text));
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtUrunID.Text));
            komut.Parameters.AddWithValue("@tarih", dateTimePickerTarih.Value);
            komut.Parameters.AddWithValue("@saat", txtSaat.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }

        private void btnSatisRaporla_Click(object sender, EventArgs e)
        {
            frmRaporla raporFormu = new frmRaporla();
            this.Hide();
            raporFormu.Show();
        }
    }
}
