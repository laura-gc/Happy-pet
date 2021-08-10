namespace CapaGUI
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.tb_MercaderiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_VeterinariaDataSet = new CapaGUI.BD_VeterinariaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_MercaderiaTableAdapter = new CapaGUI.BD_VeterinariaDataSetTableAdapters.tb_MercaderiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MercaderiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MercaderiaBindingSource
            // 
            this.tb_MercaderiaBindingSource.DataMember = "tb_Mercaderia";
            this.tb_MercaderiaBindingSource.DataSource = this.BD_VeterinariaDataSet;
            // 
            // BD_VeterinariaDataSet
            // 
            this.BD_VeterinariaDataSet.DataSetName = "BD_VeterinariaDataSet";
            this.BD_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_MercaderiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaGUI.Reportes.RptInventaria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_MercaderiaTableAdapter
            // 
            this.tb_MercaderiaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventario";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_MercaderiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_MercaderiaBindingSource;
        private BD_VeterinariaDataSet BD_VeterinariaDataSet;
        private BD_VeterinariaDataSetTableAdapters.tb_MercaderiaTableAdapter tb_MercaderiaTableAdapter;
    }
}