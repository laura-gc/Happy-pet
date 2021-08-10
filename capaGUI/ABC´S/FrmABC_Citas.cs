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
    public partial class FrmABC_Citas : Form
    {
        ClassABC_Citas ABC = new ClassABC_Citas();

        ClassEncap_Citas atriCitas = new ClassEncap_Citas();
        public FrmABC_Citas()
        {
            

            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.ConsultarCita(dgvDatos);
        }

        private void FrmABC_Citas_Load(object sender, EventArgs e)
        {
            ABC.LlenarDNI(cboDNI);
            ABC.LlenarCodVet(cboCodVet);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            atriCitas._CodCitas = Int16.Parse(txtCodCita.Text);

            ABC.EliminarCita(atriCitas);

            txtCodCita.Text = "0";
            txtDireccion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            atriCitas._FechaCita1 = dtpFecha.Value.Date;
            atriCitas._Direccion = txtDireccion.Text;
            atriCitas._DNI = cboDNI.Text;
            atriCitas._CodVet = cboCodVet.Text;
            ABC.SolicitarCita(atriCitas);

            txtDireccion.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            atriCitas._CodCitas = Int16.Parse(txtCodCita.Text);
            atriCitas._FechaCita1 = dtpFecha.Value.Date;
            atriCitas._Direccion = txtDireccion.Text;
            atriCitas._DNI = cboDNI.Text;
            atriCitas._CodVet = cboCodVet.Text;
            ABC.ActualizarCita(atriCitas);

            txtDireccion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ABC.LlenarCampos(txtCodCita,dtpFecha,txtDireccion,cboDNI,cboCodVet);
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvDatos.CurrentRow.Index;
            codigoActualizar = dgvDatos.Rows[indiceFila].Cells[0].Value.ToString();
            txtCodCita.Text = dgvDatos.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }
}
