namespace CapaGUI
{
    partial class FrmABC_Veterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABC_Veterinario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvVet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaCon = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTlfn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaGUI.Properties.Resources.b986a0fdc106df160e6f7d1a351d2b9f;
            this.pictureBox1.Location = new System.Drawing.Point(635, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(635, 76);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(34, 31);
            this.btnConsulta.TabIndex = 71;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::CapaGUI.Properties.Resources.descarga;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(688, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(27, 31);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaGUI.Properties.Resources.images__1_;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(617, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 30);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaGUI.Properties.Resources._841381;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(654, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(28, 31);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::CapaGUI.Properties.Resources._1026471;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(589, 36);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(22, 31);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvVet
            // 
            this.dgvVet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVet.Location = new System.Drawing.Point(12, 240);
            this.dgvVet.Name = "dgvVet";
            this.dgvVet.Size = new System.Drawing.Size(706, 198);
            this.dgvVet.TabIndex = 73;
            this.dgvVet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVet_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Código:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(145, 62);
            this.txtNom.MaxLength = 25;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 75;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(145, 23);
            this.txtCod.MaxLength = 8;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 76;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(145, 145);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 77;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(145, 188);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 78;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(145, 108);
            this.txtApe.MaxLength = 25;
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 79;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(341, 108);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(182, 20);
            this.txtDireccion.TabIndex = 80;
            // 
            // dtpFechaCon
            // 
            this.dtpFechaCon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCon.Location = new System.Drawing.Point(421, 63);
            this.dtpFechaCon.Name = "dtpFechaCon";
            this.dtpFechaCon.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaCon.TabIndex = 81;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(339, 26);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 82;
            // 
            // txtTlfn
            // 
            this.txtTlfn.Location = new System.Drawing.Point(421, 142);
            this.txtTlfn.MaxLength = 9;
            this.txtTlfn.Name = "txtTlfn";
            this.txtTlfn.Size = new System.Drawing.Size(100, 20);
            this.txtTlfn.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Fecha de Contratación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 91;
            this.label9.Text = "Telefóno:";
            // 
            // FrmABC_Veterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.fc1d3c601df8682264c4a3a4b2dbbd94_fondo_abstracto_del_engranaje;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTlfn);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpFechaCon);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABC_Veterinario";
            this.Text = "Mantenimiento Veterinario";
            this.Load += new System.EventHandler(this.FrmABC_Veterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvVet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaCon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTlfn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}