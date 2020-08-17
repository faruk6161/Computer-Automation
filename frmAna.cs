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

namespace BilgisayarOtomasyonu
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }             
        frmMusteri musteri = new frmMusteri();
        frmSatis satis = new frmSatis();
        frmUrun urun = new frmUrun();
        frmYonetici yonetici = new frmYonetici();       
        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAnaSayfa.Text = "";
            urun.MdiParent = this;
            urun.Show();
        }
        private void satisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAnaSayfa.Text = "";
            satis.MdiParent = this;
            satis.Show();
        }
        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAnaSayfa.Text = "";
            musteri.MdiParent = this;
            musteri.Show();
        }
        private void yoneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAnaSayfa.Text = "";
            yonetici.MdiParent = this;
            yonetici.Show();
        }
    }
}
