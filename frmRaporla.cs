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
    public partial class frmRaporla : Form
    {
        public frmRaporla()
        {
            InitializeComponent();
        }
        private void frmRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BilgisayarOtomasyonuDataSet.satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.BilgisayarOtomasyonuDataSet.satis);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
