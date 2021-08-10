namespace CapaGUI
{
    partial class FrmABC_Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABC_Consultas));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboVeterinario = new System.Windows.Forms.ComboBox();
            this.cboDni = new System.Windows.Forms.ComboBox();
            this.txtObser = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCodCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clbVacunas = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Veterinario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Diagnostico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Vacunas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Fecha:";
            // 
            // cboVeterinario
            // 
            this.cboVeterinario.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeterinario.FormattingEnabled = true;
            this.cboVeterinario.Location = new System.Drawing.Point(645, 162);
            this.cboVeterinario.Name = "cboVeterinario";
            this.cboVeterinario.Size = new System.Drawing.Size(121, 24);
            this.cboVeterinario.TabIndex = 52;
            // 
            // cboDni
            // 
            this.cboDni.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDni.FormattingEnabled = true;
            this.cboDni.Location = new System.Drawing.Point(394, 162);
            this.cboDni.Name = "cboDni";
            this.cboDni.Size = new System.Drawing.Size(121, 24);
            this.cboDni.TabIndex = 51;
            // 
            // txtObser
            // 
            this.txtObser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtObser.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObser.Location = new System.Drawing.Point(868, 11);
            this.txtObser.Multiline = true;
            this.txtObser.Name = "txtObser";
            this.txtObser.Size = new System.Drawing.Size(317, 134);
            this.txtObser.TabIndex = 50;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDiagnostico.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(302, 7);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(464, 138);
            this.txtDiagnostico.TabIndex = 49;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(110, 64);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 48;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(110, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 47;
            // 
            // txtCodCon
            // 
            this.txtCodCon.Location = new System.Drawing.Point(110, 9);
            this.txtCodCon.MaxLength = 9;
            this.txtCodCon.Name = "txtCodCon";
            this.txtCodCon.Size = new System.Drawing.Size(100, 20);
            this.txtCodCon.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Código:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(901, 209);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(34, 31);
            this.btnConsulta.TabIndex = 67;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::CapaGUI.Properties.Resources.descarga;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(954, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(27, 31);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaGUI.Properties.Resources.images__1_;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(883, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 30);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaGUI.Properties.Resources._841381;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(920, 169);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(28, 31);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::CapaGUI.Properties.Resources._1026471;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(855, 169);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(22, 31);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(363, 256);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(801, 180);
            this.dgvConsultas.TabIndex = 68;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaGUI.Properties.Resources.b986a0fdc106df160e6f7d1a351d2b9f;
            this.pictureBox1.Location = new System.Drawing.Point(1085, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "DNI del dueño:";
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
            this.clbVacunas.Location = new System.Drawing.Point(79, 97);
            this.clbVacunas.Name = "clbVacunas";
            this.clbVacunas.Size = new System.Drawing.Size(170, 346);
            this.clbVacunas.TabIndex = 70;
            // 
            // FrmABC_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.fc1d3c601df8682264c4a3a4b2dbbd94_fondo_abstracto_del_engranaje;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.clbVacunas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
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
            this.Name = "FrmABC_Consultas";
            this.Text = "Mantenimiento Consultas";
            this.Load += new System.EventHandler(this.FrmABC_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboVeterinario;
        private System.Windows.Forms.ComboBox cboDni;
        private System.Windows.Forms.TextBox txtObser;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCodCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbVacunas;
    }
}