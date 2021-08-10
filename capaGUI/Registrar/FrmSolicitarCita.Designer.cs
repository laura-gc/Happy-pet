namespace CapaGUI
{
    partial class FrmSolicitarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitarCita));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCodVet = new System.Windows.Forms.ComboBox();
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.HotPink;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 90);
            this.label5.TabIndex = 38;
            this.label5.Text = "En el Caso de ser su primera consulta, se selecionara el veterinario disponible e" +
    "n la fecha escogida";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.HotPink;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Seleccione el Codigo del Veterinario de preferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.HotPink;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seleccione su DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ingrese la Dirección donde sera la consulta\r\n";
            // 
            // cboCodVet
            // 
            this.cboCodVet.FormattingEnabled = true;
            this.cboCodVet.Location = new System.Drawing.Point(355, 163);
            this.cboCodVet.Name = "cboCodVet";
            this.cboCodVet.Size = new System.Drawing.Size(121, 21);
            this.cboCodVet.TabIndex = 32;
            // 
            // cboDNI
            // 
            this.cboDNI.FormattingEnabled = true;
            this.cboDNI.Location = new System.Drawing.Point(177, 113);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(121, 21);
            this.cboDNI.TabIndex = 31;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(177, 37);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seleccione el dia ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaGUI.Properties.Resources.Perro_gato_mascotas;
            this.pictureBox2.Location = new System.Drawing.Point(378, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
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
            this.btnRegistrar.Location = new System.Drawing.Point(239, 245);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(38, 31);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.HotPink;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(0, -1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(52, 25);
            this.btnAtras.TabIndex = 40;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(307, 73);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // FrmSolicitarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources.gato_lindo_fondo_inconsutil_modelo_pastel_marron_45130_407;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cboCodVet);
            this.Controls.Add(this.cboDNI);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSolicitarCita";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmSolicitarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboCodVet;
        private System.Windows.Forms.ComboBox cboDNI;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}