namespace CapaGUI
{
    partial class FrmReporteCitasDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCitasDiario));
            this.tb_CitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_VeterinariaDataSet = new CapaGUI.BD_VeterinariaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbVet = new System.Windows.Forms.ComboBox();
            this.tb_CitaTableAdapter = new CapaGUI.BD_VeterinariaDataSetTableAdapters.tb_CitaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_CitaBindingSource
            // 
            this.tb_CitaBindingSource.DataMember = "tb_Cita";
            this.tb_CitaBindingSource.DataSource = this.BD_VeterinariaDataSet;
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
            reportDataSource1.Value = this.tb_CitaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaGUI.Reportes.RptCitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbVet
            // 
            this.cbVet.FormattingEnabled = true;
            this.cbVet.Location = new System.Drawing.Point(0, 0);
            this.cbVet.Name = "cbVet";
            this.cbVet.Size = new System.Drawing.Size(128, 21);
            this.cbVet.TabIndex = 2;
            this.cbVet.SelectedIndexChanged += new System.EventHandler(this.cbVet_SelectedIndexChanged);
            // 
            // tb_CitaTableAdapter
            // 
            this.tb_CitaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCitasDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 453);
            this.Controls.Add(this.cbVet);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmReporteCitasDiario";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmReporteCitasDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_CitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_CitaBindingSource;
        private BD_VeterinariaDataSet BD_VeterinariaDataSet;
        private BD_VeterinariaDataSetTableAdapters.tb_CitaTableAdapter tb_CitaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbVet;
    }
}