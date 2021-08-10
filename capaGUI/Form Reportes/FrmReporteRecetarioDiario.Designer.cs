namespace CapaGUI
{
    partial class FrmReporteRecetarioDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteRecetarioDiario));
            this.tb_RecetarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_VeterinariaDataSet = new CapaGUI.BD_VeterinariaDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_RecetarioTableAdapter = new CapaGUI.BD_VeterinariaDataSetTableAdapters.tb_RecetarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_RecetarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_RecetarioBindingSource
            // 
            this.tb_RecetarioBindingSource.DataMember = "tb_Recetario";
            this.tb_RecetarioBindingSource.DataSource = this.BD_VeterinariaDataSet;
            // 
            // BD_VeterinariaDataSet
            // 
            this.BD_VeterinariaDataSet.DataSetName = "BD_VeterinariaDataSet";
            this.BD_VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cboDNI
            // 
            this.cboDNI.FormattingEnabled = true;
            this.cboDNI.Location = new System.Drawing.Point(0, 0);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(124, 21);
            this.cboDNI.TabIndex = 2;
            this.cboDNI.SelectedIndexChanged += new System.EventHandler(this.cboDNI_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_RecetarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaGUI.Reportes.RptRecetario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 426);
            this.reportViewer1.TabIndex = 3;
            // 
            // tb_RecetarioTableAdapter
            // 
            this.tb_RecetarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteRecetarioDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboDNI);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteRecetarioDiario";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmReporteRecetarioDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_RecetarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VeterinariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cboDNI;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_RecetarioBindingSource;
        private BD_VeterinariaDataSet BD_VeterinariaDataSet;
        private BD_VeterinariaDataSetTableAdapters.tb_RecetarioTableAdapter tb_RecetarioTableAdapter;
    }
}