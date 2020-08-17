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
    public partial class frmUrun : Form
    {
        public frmUrun()
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
            dataAdapter = new SqlDataAdapter("SELECT * FROM urun", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewUrun.DataSource = tablo;
            baglanti.Close();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string sorgu = "INSERT INTO urun " +
                "(urunid,marka,model,isletimsistemi,ekrankartımodeli,ekrancozunurlugu,ram,islemci,depolama,optiksürücü,bluetooth,ekranboyutu,fiyat,ekozellik,resim)" +
                "VALUES(@urunid,@marka,@model,@isletimsistemi,@ekrankartımodeli,@ekrancozunurlugu,@ram,@islemci,@depolama,@optiksürücü,@bluetooth,@ekranboyutu,@fiyat,@ekozellik,@resim)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@isletimsistemi", txtOS.Text);
            komut.Parameters.AddWithValue("@ekrankartımodeli", txtGPU.Text);
            komut.Parameters.AddWithValue("@ekrancozunurlugu", txtCozunurluk.Text);
            komut.Parameters.AddWithValue("@ram", txtRam.Text);
            komut.Parameters.AddWithValue("@islemci", txtCPU.Text);
            komut.Parameters.AddWithValue("@depolama", txtDiskTip.Text);
            komut.Parameters.AddWithValue("@optiksürücü", txtOptikSurucu.Text);
            komut.Parameters.AddWithValue("@bluetooth", txtBluetooth.Text);
            komut.Parameters.AddWithValue("@ekranboyutu", txtEkranBoyutu.Text);
            komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtFiyat.Text));
            komut.Parameters.AddWithValue("@ekozellik", txtEkOzellik.Text);
            komut.Parameters.AddWithValue("@resim", lblFotoYolu.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            DataGridViewAktar();

        }
        private void frmUrun_Load(object sender, EventArgs e)
        {
            DataGridViewAktar();
        }
        private void dataGridViewUrun_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dataGridViewUrun.CurrentRow.Cells["urunid"].Value.ToString();
            cmbMarka.Text = dataGridViewUrun.CurrentRow.Cells["marka"].Value.ToString();
            txtModel.Text = dataGridViewUrun.CurrentRow.Cells["model"].Value.ToString();
            txtOS.Text = dataGridViewUrun.CurrentRow.Cells["isletimsistemi"].Value.ToString();
            txtGPU.Text = dataGridViewUrun.CurrentRow.Cells["ekrankartımodeli"].Value.ToString();
            txtCozunurluk.Text = dataGridViewUrun.CurrentRow.Cells["ekrancozunurlugu"].Value.ToString();
            txtRam.Text = dataGridViewUrun.CurrentRow.Cells["ram"].Value.ToString();
            txtCPU.Text = dataGridViewUrun.CurrentRow.Cells["islemci"].Value.ToString();
            txtDiskTip.Text = dataGridViewUrun.CurrentRow.Cells["depolama"].Value.ToString();
            txtOptikSurucu.Text = dataGridViewUrun.CurrentRow.Cells["optiksürücü"].Value.ToString();
            txtBluetooth.Text = dataGridViewUrun.CurrentRow.Cells["bluetooth"].Value.ToString();
            txtEkranBoyutu.Text = dataGridViewUrun.CurrentRow.Cells["ekranboyutu"].Value.ToString();
            txtFiyat.Text = dataGridViewUrun.CurrentRow.Cells["fiyat"].Value.ToString();
            txtEkOzellik.Text = dataGridViewUrun.CurrentRow.Cells["ekozellik"].Value.ToString();
            pictureBoxPC.ImageLocation= dataGridViewUrun.CurrentRow.Cells["resim"].Value.ToString();

        }      
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM urun WHERE urunid=@urunid";
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtID.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();           
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //string sorgu = "UPDATE urun SET marka=@marka,model=@model,isletimsistemi=@isletimsistemi" +
            //    "ekrankartımodeli=@ekrankartımodeli,ekrancozunurlugu=@ekrancozunurlugu,ram=@ram,islemci=@islemci" +
            //    "depolama=@depolama,optiksürücü=@optiksürücü,bluetooth=@bluetooth,ekranboyutu=@ekranboyutu" +
            //    "fiyat=@fiyat,ekozellik=@ekozellik WHERE urunid=@urunid";
            string sorgu = "UPDATE urun SET marka='"+cmbMarka.Text+"',model='"+txtModel.Text+"'" +
                ",isletimsistemi='"+txtOS.Text+"',ekrankartımodeli='"+txtGPU.Text+"'" +
                ",ram='"+txtRam.Text+"',islemci='"+txtCPU.Text+"' " +
                ", depolama='"+txtDiskTip.Text+"',optiksürücü='"+txtOptikSurucu.Text+"'" +
                ",bluetooth='"+txtBluetooth.Text+"',ekranboyutu='"+txtEkranBoyutu.Text+"'" +
                ",ekrancozunurlugu='"+txtCozunurluk.Text+"',ekozellik='"+txtEkOzellik.Text+"'" +
                ",fiyat='"+Convert.ToInt32(txtFiyat.Text)+"',resim='"+lblFotoYolu.Text+"' WHERE urunid="+txtID.Text+"";
            komut = new SqlCommand(sorgu, baglanti);       
            //komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
            //komut.Parameters.AddWithValue("@model", txtModel.Text);
            //komut.Parameters.AddWithValue("@isletimsistemi", txtOS.Text);
            //komut.Parameters.AddWithValue("@ekrankartımodeli", txtGPU.Text);
            //komut.Parameters.AddWithValue("@ekrancozunurlugu", txtCozunurluk.Text);
            //komut.Parameters.AddWithValue("@ram", txtRam.Text);
            //komut.Parameters.AddWithValue("@islemci", txtCPU.Text);
            //komut.Parameters.AddWithValue("@depolama", txtDiskTip.Text);
            //komut.Parameters.AddWithValue("@optiksürücü", txtOptikSurucu.Text);
            //komut.Parameters.AddWithValue("@bluetooth", txtBluetooth.Text);
            //komut.Parameters.AddWithValue("@ekranboyutu", txtEkranBoyutu.Text);
            //komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtFiyat.Text));
            //komut.Parameters.AddWithValue("@ekozellik", txtEkOzellik.Text);       
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }
        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM urun where marka like '%"+txtAramaYap.Text+"%'",baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewUrun.DataSource = tablo;
            baglanti.Close();           
        }
        private void btnGridDoldur_Click(object sender, EventArgs e)
        {
            DataGridViewAktar();
        }
        public static string _resimsakla;
        private void pictureBoxPC_Click(object sender, EventArgs e)
        {
            //Image image = Image.FromFile(@"..\..\bilgisayarlar\" + text + ".png");
            //this.pictureBox1.Image = image;

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Dosya Türü |*.jpg;*.jpeg; *.PNG; *.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName; //dosya yolu seçildi .
            lblFotoYolu.Text = dosyayolu;//dosya yolu label a aktarıldı .
            pictureBoxPC.ImageLocation = dosyayolu; //dosya yolu ımagelocation özelliğine aktarıldı
            lblFotoYolu.Visible = true;

        }
    }
}
