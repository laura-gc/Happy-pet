namespace CapaGUI
{
    partial class FrmMDI_Veterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI_Veterinaria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.RegRecetario = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.RecReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtras = new System.Windows.Forms.Button();
            this.mascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegConsulta,
            this.RegRecetario,
            this.reporteToolStripMenuItem,
            this.mascotaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 429);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegConsulta
            // 
            this.RegConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegConsulta.Name = "RegConsulta";
            this.RegConsulta.Size = new System.Drawing.Size(66, 20);
            this.RegConsulta.Text = "Consulta";
            this.RegConsulta.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // RegRecetario
            // 
            this.RegRecetario.BackColor = System.Drawing.Color.Tomato;
            this.RegRecetario.Name = "RegRecetario";
            this.RegRecetario.Size = new System.Drawing.Size(68, 20);
            this.RegRecetario.Text = "Recetario";
            this.RegRecetario.Click += new System.EventHandler(this.recetarioToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conReporte,
            this.RecReporte});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // conReporte
            // 
            this.conReporte.BackColor = System.Drawing.Color.Khaki;
            this.conReporte.Name = "conReporte";
            this.conReporte.Size = new System.Drawing.Size(128, 22);
            this.conReporte.Text = "Consultas";
            this.conReporte.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // RecReporte
            // 
            this.RecReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RecReporte.Name = "RecReporte";
            this.RecReporte.Size = new System.Drawing.Size(128, 22);
            this.RecReporte.Text = "Recetarios";
            this.RecReporte.Click += new System.EventHandler(this.recetarioToolStripMenuItem1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(0, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(52, 25);
            this.btnAtras.TabIndex = 41;
            this.btnAtras.Text = "Salir";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // mascotaToolStripMenuItem
            // 
            this.mascotaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mascotaToolStripMenuItem.Name = "mascotaToolStripMenuItem";
            this.mascotaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mascotaToolStripMenuItem.Text = "Mascota";
            this.mascotaToolStripMenuItem.Click += new System.EventHandler(this.mascotaToolStripMenuItem_Click);
            // 
            // FrmMDI_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.papeles_pintados_fondo_transparente_con_huesos_coloridos_y_patas_de_perro_sobre_fondo_blanco_adecuado_para_papel_de_regalo_papel_tapiz_y_tarjeta_jpg;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FrmMDI_Veterinaria";
            this.Text = "HappyPet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegConsulta;
        private System.Windows.Forms.ToolStripMenuItem RegRecetario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conReporte;
        private System.Windows.Forms.ToolStripMenuItem RecReporte;
        private System.Windows.Forms.ToolStripMenuItem mascotaToolStripMenuItem;
    }
}