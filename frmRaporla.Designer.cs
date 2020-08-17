namespace BilgisayarOtomasyonu
{
    partial class frmRaporla
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BilgisayarOtomasyonuDataSet = new BilgisayarOtomasyonu.BilgisayarOtomasyonuDataSet();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter = new BilgisayarOtomasyonu.BilgisayarOtomasyonuDataSetTableAdapters.satisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BilgisayarOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SatisDataSet";
            reportDataSource1.Value = this.satisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BilgisayarOtomasyonu.SatisRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(722, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // BilgisayarOtomasyonuDataSet
            // 
            this.BilgisayarOtomasyonuDataSet.DataSetName = "BilgisayarOtomasyonuDataSet";
            this.BilgisayarOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.BilgisayarOtomasyonuDataSet;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRaporla";
            this.Text = "frmRaporla";
            this.Load += new System.EventHandler(this.frmRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilgisayarOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private BilgisayarOtomasyonuDataSet BilgisayarOtomasyonuDataSet;
        private BilgisayarOtomasyonuDataSetTableAdapters.satisTableAdapter satisTableAdapter;
    }
}