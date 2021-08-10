namespace CapaGUI
{
    partial class FrmRegistroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroCliente));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDirec = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.btnRegistrar.Location = new System.Drawing.Point(474, 376);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(38, 31);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese la Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione la Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccione la Raza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingrese su teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ingrese su Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Selecione una imagen de su mascota";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Location = new System.Drawing.Point(579, 109);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(25, 23);
            this.btnImagen.TabIndex = 10;
            this.btnImagen.Text = "...";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(375, 141);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(240, 192);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(190, 40);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(111, 20);
            this.txtDNI.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(227, 79);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(181, 20);
            this.txtNom.TabIndex = 13;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(190, 117);
            this.txtEdad.MaxLength = 9;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(111, 20);
            this.txtEdad.TabIndex = 14;
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(190, 166);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(132, 21);
            this.cboEspecie.TabIndex = 15;
            this.cboEspecie.SelectedIndexChanged += new System.EventHandler(this.cboEspecie_SelectedIndexChanged);
            // 
            // cboRaza
            // 
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(190, 215);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(132, 21);
            this.cboRaza.TabIndex = 16;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(190, 309);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 358);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDirec.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.Location = new System.Drawing.Point(315, 43);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(132, 15);
            this.lblDirec.TabIndex = 20;
            this.lblDirec.Text = "Ingrese su Direccion";
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(457, 39);
            this.txtDirec.MaxLength = 50;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(209, 20);
            this.txtDirec.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el Nombre de la Mascota";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaGUI.Properties.Resources.Perro_gato_mascotas;
            this.pictureBox2.Location = new System.Drawing.Point(545, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seleccione EL Genero";
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbH.Location = new System.Drawing.Point(205, 262);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(33, 17);
            this.rbH.TabIndex = 24;
            this.rbH.TabStop = true;
            this.rbH.Text = "H";
            this.rbH.UseVisualStyleBackColor = false;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbM.Location = new System.Drawing.Point(247, 262);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 25;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.defaultLookAndFeel1.LookAndFeel.TouchUI = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(-2, -3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(52, 25);
            this.btnAtras.TabIndex = 26;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.thumb2_paws_patterns_creative_footprints_patterns_abstract_backgrounds_dog_footprints__1_;
            this.ClientSize = new System.Drawing.Size(687, 434);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.rbH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.btnRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroCliente";
            this.Text = "Happy Pet";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FrmRegistroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbM;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Button btnAtras;
    }
}

