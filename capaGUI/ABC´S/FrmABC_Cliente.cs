using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmABC_Cliente : Form
    {
        ClassABC_Cliente ABC = new ClassABC_Cliente();
        SqlConnection cn = new SqlConnection();
        ClassConnection conectar = new ClassConnection();


        public FrmABC_Cliente()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABC.EliminarCliente(txtDNI.Text);

            txtDNI.Text = "";
            txtNom.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDirec.Text = "";
        }

        private void FrmABC_Cliente_Load(object sender, EventArgs e)
        {
            cboEspecie.Items.Add("Perro");
            cboEspecie.Items.Add("Gato");
            cboEspecie.Items.Add("Mini Pig");
            cboEspecie.Items.Add("Conejo");
            cboEspecie.Items.Add("Hámster");
            cboEspecie.Items.Add("Erizo");
            cboEspecie.Items.Add("Pez");
            cboEspecie.Items.Add("Ave");
        }

        private void cboRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbImagen.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbM.Checked = true)
            {

                ABC.ModificarCliente(txtDNI.Text, txtNom.Text, txtEdad.Text, cboEspecie.Text, cboRaza.Text, rbM.Text, txtTelefono.Text, txtEmail.Text, txtDirec.Text, pbImagen);
            }

            if (rbF.Checked = true)
            {

                ABC.ModificarCliente(txtDNI.Text, txtNom.Text, txtEdad.Text, cboEspecie.Text, cboRaza.Text, rbF.Text, txtTelefono.Text, txtEmail.Text, txtDirec.Text, pbImagen);
            }

            txtDNI.Text = "";
            txtNom.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDirec.Text = "";
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.ConsultaCliente(dgvMascota);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbM.Checked = true)
            {

                ABC.RegistrarMascota(txtDNI.Text, txtNom.Text, txtEdad.Text, cboEspecie.Text, cboRaza.Text, rbM.Text, txtTelefono.Text, txtEmail.Text, txtDirec.Text, pbImagen);
            }

            if (rbF.Checked = true)
            {

                ABC.RegistrarMascota(txtDNI.Text, txtNom.Text, txtEdad.Text, cboEspecie.Text, cboRaza.Text, rbF.Text, txtTelefono.Text, txtEmail.Text, txtDirec.Text, pbImagen);
            }

            txtDNI.Text = "";
            txtNom.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDirec.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cn = conectar.ConectarBD();

            SqlCommand cmmd = new SqlCommand("Select * from tb_Cliente where DNI = @DNI", cn);
            cmmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
            SqlDataReader lector = cmmd.ExecuteReader();

            if (lector.Read())
            {
                String genero = lector["genero"].ToString();

                switch (genero)
                {
                    case "M": rbM.Checked=true; rbF.Checked=false; break;
                    case "H": rbF.Checked = true; rbM.Checked = false; break;

                }
            }
            
            conectar.cerrarBD();

            ABC.LlenarCampos(txtDNI, txtNom, txtEdad, cboEspecie, cboRaza, txtTelefono, txtEmail, txtDirec);
            ABC.VerImagen(pbImagen, txtDNI.Text);
        }

        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecie.SelectedItem.ToString() == "Perro")
            {
                cboRaza.Items.Add("Labrador Retriever");
                cboRaza.Items.Add("Pastor alemán");
                cboRaza.Items.Add("Salchicha");
                cboRaza.Items.Add("Yorkshire terrier");
                cboRaza.Items.Add("Beagle");
                cboRaza.Items.Add("Golden Retriever");
                cboRaza.Items.Add("Chihuahua");
                cboRaza.Items.Add("Caniche");
                cboRaza.Items.Add("Dálmata");
                cboRaza.Items.Add("Bóxer");
                cboRaza.Items.Add("Bulldog inglés");
                cboRaza.Items.Add("Border collie");
                cboRaza.Items.Add("Pastor de Shetland");
                cboRaza.Items.Add("Dóberman");
                cboRaza.Items.Add("Rottweiler");
                cboRaza.Items.Add("Pastor ganadero australiano");
            }

            if (cboEspecie.SelectedItem.ToString() == "Gato")
            {
                cboRaza.Items.Add("Persa");
                cboRaza.Items.Add("Azul ruso");
                cboRaza.Items.Add("Maine Coon");
                cboRaza.Items.Add("Siamés");
                cboRaza.Items.Add("Abisinio");
                cboRaza.Items.Add("Ragdoll");
                cboRaza.Items.Add("Esfinge");
                cboRaza.Items.Add("american wirehair");
                cboRaza.Items.Add("pixie bob");
                cboRaza.Items.Add("tonkinés");
                cboRaza.Items.Add("LaPerm");
                cboRaza.Items.Add("burmilla");
                cboRaza.Items.Add("montés");
                cboRaza.Items.Add("burmés");
            }

            if (cboEspecie.SelectedItem.ToString() == "Mini Pig")
            {
                cboRaza.Items.Add("Juliana");
                cboRaza.Items.Add("Göttingen");
                cboRaza.Items.Add("vietnamita enano");
                cboRaza.Items.Add("Yucatán");
                cboRaza.Items.Add("Guinea americano");
            }

            if (cboEspecie.SelectedItem.ToString() == "Conejo")
            {
                cboRaza.Items.Add("Holland lop");
                cboRaza.Items.Add("Cabeza de león");
                cboRaza.Items.Add("Rex");
                cboRaza.Items.Add("Holandés enano");
                cboRaza.Items.Add("Mini Lop");
                cboRaza.Items.Add("French Lop");
                cboRaza.Items.Add("Belier Holandés");
            }

            if (cboEspecie.SelectedItem.ToString() == "Hámster")
            {
                cboRaza.Items.Add("Roborovski");
                cboRaza.Items.Add("Chino");
                cboRaza.Items.Add("Campbell");
                cboRaza.Items.Add("Ruso");
                cboRaza.Items.Add("Sirio o Dorado");
                cboRaza.Items.Add("Siamés");
                cboRaza.Items.Add("Oso Negro");
                cboRaza.Items.Add("Angora");
                cboRaza.Items.Add("Albino");
                cboRaza.Items.Add("Arlequín");
                cboRaza.Items.Add("Panda");
            }

            if (cboEspecie.SelectedItem.ToString() == "Erizo")
            {
                cboRaza.Items.Add("Egipcio");
                cboRaza.Items.Add("Europeo");
                cboRaza.Items.Add("oriental oscuro");
                cboRaza.Items.Add("Balcanes");
                cboRaza.Items.Add("Amur");
                cboRaza.Items.Add("vientre blanco");
                cboRaza.Items.Add("moruno");
                cboRaza.Items.Add("Somalí");
                cboRaza.Items.Add("Sudafricano");
            }

            if (cboEspecie.SelectedItem.ToString() == "Pez")
            {
                cboRaza.Items.Add("Ángel");
                cboRaza.Items.Add("betta");
                cboRaza.Items.Add("cebra");
                cboRaza.Items.Add("guppy");
                cboRaza.Items.Add("tetra neón");
                cboRaza.Items.Add("platy");
                cboRaza.Items.Add("molly negro");
                cboRaza.Items.Add("Corydora paleatus");
                cboRaza.Items.Add("disco");
                cboRaza.Items.Add("ramirezi");
                cboRaza.Items.Add("Guramis");
                cboRaza.Items.Add("Mollys");
                cboRaza.Items.Add("gato cristal");
                cboRaza.Items.Add("Killis");
            }

            if (cboEspecie.SelectedItem.ToString() == "Ave")
            {
                cboRaza.Items.Add("Diamante Mandarin");
                cboRaza.Items.Add("Periquito");
                cboRaza.Items.Add("Cotorra");
                cboRaza.Items.Add("Agapornis");
                cboRaza.Items.Add("Loro");
                cboRaza.Items.Add("Canario");
                cboRaza.Items.Add("pato");
                cboRaza.Items.Add("Ninfa");
                cboRaza.Items.Add("Pollito");
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvMascota.CurrentRow.Index;
            codigoActualizar = dgvMascota.Rows[indiceFila].Cells[0].Value.ToString();
            txtDNI.Text = dgvMascota.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }
}
