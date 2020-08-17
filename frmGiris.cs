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
    public partial class frmGiris : Form
    {        
        public frmGiris()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti=new SqlConnection("Server=.; Initial Catalog=BilgisayarOtomasyonu; Integrated Security=SSPI");
        public SqlCommand komut;
        public SqlDataReader veriOkuyucu;
        public frmAna anaSayfa = new frmAna();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {                
                baglanti.Open();
                string sorgu = "SELECT *FROM yonetici WHERE kuladi='" + txtKullaniciAdi.Text + "' and sifre='" + txtSifre.Text + "'";
                komut = new SqlCommand(sorgu, baglanti);
                veriOkuyucu = komut.ExecuteReader();
                if (veriOkuyucu.Read())
                {
                    MessageBox.Show("Otomasyona başarıyla giriş yaptınız ...HOŞGELDİNİZ :)", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    anaSayfa.Show();
                    this.Hide();                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }        
        }
    }
}
