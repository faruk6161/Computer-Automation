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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
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
            dataAdapter = new SqlDataAdapter("SELECT * FROM musteri", baglanti);
            tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridViewMusteri.DataSource = tablo;
            baglanti.Close();
        }
        private void dataGridViewMusteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridViewMusteri.CurrentRow.Cells["musteriid"].Value.ToString();
            txtTcNo.Text = dataGridViewMusteri.CurrentRow.Cells["tcno"].Value.ToString();
            txtAd.Text = dataGridViewMusteri.CurrentRow.Cells["ad"].Value.ToString();
            txtSoyad.Text = dataGridViewMusteri.CurrentRow.Cells["soyad"].Value.ToString();
            dateTimePicker1.Text = dataGridViewMusteri.CurrentRow.Cells["dogumtarihi"].Value.ToString();           
            if (dataGridViewMusteri.CurrentRow.Cells["cinsiyet"].Value.ToString()=="Erkek")
            {
                radioButtonErkek.Checked = true;
            }
            else
            {
                radioButtonKadın.Checked = true;
            }
            txtTel.Text = dataGridViewMusteri.CurrentRow.Cells["telefon"].Value.ToString();
            txtEmail.Text = dataGridViewMusteri.CurrentRow.Cells["mail"].Value.ToString();
            txtAdres.Text = dataGridViewMusteri.CurrentRow.Cells["adres"].Value.ToString();


        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            DataGridViewAktar();
        }

        private void btnMusteriTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteri (musteriid,tcno,ad,soyad,dogumtarihi,cinsiyet,telefon,mail,adres)" +
                " VALUES(@musteriid,@tcno,@ad,@soyad,@dogumtarihi,@cinsiyet,@telefon,@mail,@adres)";

            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@musteriid",txtID.Text);
            komut.Parameters.AddWithValue("@tcno",txtTcNo.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value);
            if (radioButtonErkek.Checked==true)
            {
                komut.Parameters.AddWithValue("@cinsiyet", radioButtonErkek.Text);
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", radioButtonKadın.Text);
            }
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@mail", txtEmail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE musteri SET tcno=@tcno,ad=@ad,soyad=@soyad ,dogumtarihi=@dogumtarihi , cinsiyet=@cinsiyet , telefon=@telefon ,mail=@mail ,adres=@adres WHERE musteriid=@musteriid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriid", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@tcno", txtTcNo.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Value);
            if (radioButtonErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@cinsiyet", radioButtonErkek.Text);
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", radioButtonKadın.Text);
            }
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@mail", txtEmail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM musteri WHERE musteriid=@musteriid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriid", Convert.ToInt32(txtID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataGridViewAktar();
        }
    }
}
