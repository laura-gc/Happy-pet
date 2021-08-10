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
    public partial class FrmSolicitarCita : Form
    {
        ClassABC_Citas abc = new ClassABC_Citas();
        ClassEncap_Citas atriCitas = new ClassEncap_Citas();
        public FrmSolicitarCita()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            atriCitas._FechaCita1 = dtpFecha.Value.Date;
            atriCitas._Direccion = txtDireccion.Text;
            atriCitas._DNI = cboDNI.Text;
            atriCitas._CodVet = cboCodVet.Text;
            abc.SolicitarCita(atriCitas);

            txtDireccion.Text = "";
        }

        private void FrmSolicitarCita_Load(object sender, EventArgs e)
        {
            abc.LlenarDNI(cboDNI);
            abc.LlenarCodVet(cboCodVet);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmBienvenido bn = new FrmBienvenido();
            bn.Show();
            this.Hide();
        }
    }
}
