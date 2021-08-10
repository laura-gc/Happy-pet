using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmABC_Veterinario : Form
    {
        ClassABC_Veterinaria ABC = new ClassABC_Veterinaria();

        ClassEncap_Veterinario vet = new ClassEncap_Veterinario();
        public FrmABC_Veterinario()
        {
            InitializeComponent();
        }

        private void FrmABC_Veterinario_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;

            DateTime año = dtpFechaNac.Value.Date;

            txtEdad.Text = hoy.Year - año.Year +"";
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.ConsultarVeterinarios(dgvVet);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vet._CodVet = txtCod.Text;
            vet._NomVete = txtNom.Text;
            vet._ApeVete = txtApe.Text;
            vet._FechaNac = dtpFechaNac.Value.Date;
            vet._Edad = Int16.Parse(txtEdad.Text);
            vet._Email = txtEmail.Text;
            vet._FechaCon = dtpFechaCon.Value.Date;
            vet._Direccion = txtDireccion.Text;
            vet._Tlfn = txtTlfn.Text;

            ABC.RegistrarVeterinario(vet);

            txtCod.Text = "";
            txtNom.Text = "";
            txtApe.Text = "";
            txtEdad.Text = "0";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTlfn.Text = "";

        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            vet._CodVet = txtCod.Text;
            vet._NomVete = txtNom.Text;
            vet._ApeVete = txtApe.Text;
            vet._FechaNac = dtpFechaNac.Value.Date;
            vet._Edad = Int16.Parse(txtEdad.Text);
            vet._Email = txtEmail.Text;
            vet._FechaCon = dtpFechaCon.Value.Date;
            vet._Direccion = txtDireccion.Text;
            vet._Tlfn = txtTlfn.Text;

            ABC.ActualizarVeterinario(vet);

            txtCod.Text = "";
            txtNom.Text = "";
            txtApe.Text = "";
            txtEdad.Text = "0";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTlfn.Text = "";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ABC.LlenarCampos(txtCod, txtNom, txtApe, dtpFechaNac, txtEdad, txtEmail, dtpFechaCon, txtDireccion, txtTlfn);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vet._CodVet = txtCod.Text;
            ABC.EliminarVeterinario(vet);

            txtCod.Text = "";
            txtNom.Text = "";
            txtApe.Text = "";
            txtEdad.Text = "0";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTlfn.Text = "";
        }

        private void dgvVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvVet.CurrentRow.Index;
            codigoActualizar = dgvVet.Rows[indiceFila].Cells[0].Value.ToString();
            txtCod.Text = dgvVet.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }
}
