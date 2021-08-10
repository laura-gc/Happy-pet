namespace CapaGUI
{
    partial class FrmRegistrarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCon = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtObser = new System.Windows.Forms.TextBox();
            this.cboDni = new System.Windows.Forms.ComboBox();
            this.cboVeterinario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.clbVacunas = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodCon
            // 
            this.txtCodCon.Location = new System.Drawing.Point(174, 13);
            this.txtCodCon.Name = "txtCodCon";
            this.txtCodCon.Size = new System.Drawing.Size(100, 20);
            this.txtCodCon.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(174, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(174, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDiagnostico.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(465, 34);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(464, 138);
            this.txtDiagnostico.TabIndex = 26;
            // 
            // txtObser
            // 
            this.txtObser.BackColor = System.Drawing.Color.SkyBlue;
            this.txtObser.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObser.Location = new System.Drawing.Point(612, 307);
            this.txtObser.Multiline = true;
            this.txtObser.Name = "txtObser";
            this.txtObser.Size = new System.Drawing.Size(317, 134);
            this.txtObser.TabIndex = 27;
            // 
            // cboDni
            // 
            this.cboDni.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDni.FormattingEnabled = true;
            this.cboDni.Location = new System.Drawing.Point(662, 199);
            this.cboDni.Name = "cboDni";
            this.cboDni.Size = new System.Drawing.Size(121, 24);
            this.cboDni.TabIndex = 28;
            // 
            // cboVeterinario
            // 
            this.cboVeterinario.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeterinario.FormattingEnabled = true;
            this.cboVeterinario.Location = new System.Drawing.Point(662, 247);
            this.cboVeterinario.Name = "cboVeterinario";
            this.cboVeterinario.Size = new System.Drawing.Size(121, 24);
            this.cboVeterinario.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Peso del Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vacunas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Diagnostico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "DNI del dueño:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Veterinario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Observaciones:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = global::CapaGUI.Properties.Resources.dsBuffer_bmp;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(465, 393);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(38, 31);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // clbVacunas
            // 
            this.clbVacunas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clbVacunas.BackColor = System.Drawing.Color.SkyBlue;
            this.clbVacunas.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVacunas.FormattingEnabled = true;
            this.clbVacunas.HorizontalScrollbar = true;
            this.clbVacunas.Items.AddRange(new object[] {
            "Hepatitis",
            "Parvovirus",
            "Adenovirus",
            "Bordetella",
            "Rinotraqueitis",
            "Distemper",
            "Rabia",
            "Calicivirus",
            "Microsporum",
            "Chlamydophila",
            "Letospira",
            "Mixomatosis",
            "Aujeszly",
            "Hemorragia Viril",
            "Pasteurelosis",
            "Influenza Tipo 2",
            "Coronavirus Canino",
            "Panleucopenia",
            "Porcina Africana"});
            this.clbVacunas.Location = new System.Drawing.Point(143, 147);
            this.clbVacunas.Name = "clbVacunas";
            this.clbVacunas.Size = new System.Drawing.Size(263, 292);
            this.clbVacunas.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaGUI.Properties.Resources.b986a0fdc106df160e6f7d1a351d2b9f;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.vector_el_modelo_inconsútil_con_huellas_del_gato_o_del_perro_colorfu_lindo_82517658;
            this.ClientSize = new System.Drawing.Size(941, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clbVacunas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboVeterinario);
            this.Controls.Add(this.cboDni);
            this.Controls.Add(this.txtObser);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCodCon);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarConsulta";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmRegistrarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCon;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtObser;
        private System.Windows.Forms.ComboBox cboDni;
        private System.Windows.Forms.ComboBox cboVeterinario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckedListBox clbVacunas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}