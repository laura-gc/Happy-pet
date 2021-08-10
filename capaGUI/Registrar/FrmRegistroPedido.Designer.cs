namespace CapaGUI
{
    partial class FrmRegistroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroPedido));
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboCodMerca = new System.Windows.Forms.ComboBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMercaderia = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDNI
            // 
            this.cboDNI.FormattingEnabled = true;
            this.cboDNI.Location = new System.Drawing.Point(188, 386);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(121, 21);
            this.cboDNI.TabIndex = 37;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(390, 274);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 35;
            // 
            // cboCodMerca
            // 
            this.cboCodMerca.FormattingEnabled = true;
            this.cboCodMerca.Location = new System.Drawing.Point(355, 233);
            this.cboCodMerca.Name = "cboCodMerca";
            this.cboCodMerca.Size = new System.Drawing.Size(121, 21);
            this.cboCodMerca.TabIndex = 34;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(186, 350);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(128, 20);
            this.txtCant.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Seleccione su DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ingrese la Cantidad ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Seleccione la fecha que desea recivir el producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ingrese el Codigo del producto que desea";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(394, 24);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 27;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione el Tipo de Producto que desea";
            // 
            // dgvMercaderia
            // 
            this.dgvMercaderia.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercaderia.Location = new System.Drawing.Point(2, 66);
            this.dgvMercaderia.Name = "dgvMercaderia";
            this.dgvMercaderia.Size = new System.Drawing.Size(589, 159);
            this.dgvMercaderia.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaGUI.Properties.Resources.Perro_gato_mascotas;
            this.pictureBox2.Location = new System.Drawing.Point(454, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ingrese la Dirección de la Entrega";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(299, 313);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(261, 20);
            this.txtDireccion.TabIndex = 39;
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
            this.btnRegistrar.Location = new System.Drawing.Point(364, 441);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(38, 31);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.LightCoral;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(-1, -1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(52, 25);
            this.btnAtras.TabIndex = 41;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 60);
            this.label7.TabIndex = 42;
            this.label7.Text = "Los detalles de su pedido seran enviados a su correo";
            // 
            // FrmRegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaGUI.Properties.Resources._0573dcda3e126ff47d34a53e7742dc36_diseno_lindo_del_patron_de_conejos_de_pascua;
            this.ClientSize = new System.Drawing.Size(595, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboDNI);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCodMerca);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMercaderia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroPedido";
            this.Text = "Happy Pet";
            this.Load += new System.EventHandler(this.FrmRegistroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercaderia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDNI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboCodMerca;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMercaderia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label7;
    }
}