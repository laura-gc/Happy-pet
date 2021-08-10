namespace CapaGUI
{
    partial class FrmABC_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABC_Cliente));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.lblDirec = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMascota = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaGUI.Properties.Resources.Perro_gato_mascotas;
            this.pictureBox2.Location = new System.Drawing.Point(190, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(105, 310);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(209, 20);
            this.txtDirec.TabIndex = 43;
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.Transparent;
            this.lblDirec.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.Location = new System.Drawing.Point(2, 315);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(65, 15);
            this.lblDirec.TabIndex = 42;
            this.lblDirec.Text = "Direccion";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(105, 231);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 40;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbM.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbM.Location = new System.Drawing.Point(182, 191);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(39, 20);
            this.rbM.TabIndex = 1;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = false;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbF.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbF.Location = new System.Drawing.Point(105, 192);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(37, 20);
            this.rbF.TabIndex = 0;
            this.rbF.TabStop = true;
            this.rbF.Text = "H";
            this.rbF.UseVisualStyleBackColor = false;
            // 
            // cboRaza
            // 
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(105, 158);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(132, 21);
            this.cboRaza.TabIndex = 38;
            this.cboRaza.SelectedIndexChanged += new System.EventHandler(this.cboRaza_SelectedIndexChanged);
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(105, 118);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(132, 21);
            this.cboEspecie.TabIndex = 37;
            this.cboEspecie.SelectedIndexChanged += new System.EventHandler(this.cboEspecie_SelectedIndexChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(105, 84);
            this.txtEdad.MaxLength = 9;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(111, 20);
            this.txtEdad.TabIndex = 36;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(105, 50);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(181, 20);
            this.txtNom.TabIndex = 35;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(105, 21);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(111, 20);
            this.txtDNI.TabIndex = 34;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen.Location = new System.Drawing.Point(332, 26);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(240, 192);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 33;
            this.pbImagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Location = new System.Drawing.Point(105, 352);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(25, 23);
            this.btnImagen.TabIndex = 32;
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Foto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Genero";
            // 
            // dgvMascota
            // 
            this.dgvMascota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascota.Location = new System.Drawing.Point(332, 237);
            this.dgvMascota.Name = "dgvMascota";
            this.dgvMascota.Size = new System.Drawing.Size(515, 211);
            this.dgvMascota.TabIndex = 46;
            this.dgvMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascota_CellContentClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(708, 102);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(34, 31);
            this.btnConsulta.TabIndex = 55;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::CapaGUI.Properties.Resources.descarga;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(761, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(27, 31);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaGUI.Properties.Resources._841381;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(727, 62);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(28, 31);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaGUI.Properties.Resources.images__1_;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(690, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 30);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::CapaGUI.Properties.Resources._1026471;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(662, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(22, 31);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmABC_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.fc1d3c601df8682264c4a3a4b2dbbd94_fondo_abstracto_del_engranaje;
            this.ClientSize = new System.Drawing.Size(847, 448);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvMascota);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cboRaza);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABC_Cliente";
            this.Text = "Mantenimiento Cliente";
            this.Load += new System.EventHandler(this.FrmABC_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMascota;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}