using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente reg = new FrmRegistroCliente();
            reg.Show();
            this.Hide();

        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            FrmSolicitarCita reg = new FrmSolicitarCita();
            reg.Show();
            this.Hide();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmRegistroPedido reg = new FrmRegistroPedido();
            reg.Show();
            this.Hide();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmLogin man = new FrmLogin();
            man.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
