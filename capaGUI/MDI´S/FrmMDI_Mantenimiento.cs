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
    public partial class FrmMDI_Mantenimiento : Form
    {
        public FrmMDI_Mantenimiento()
        {
            InitializeComponent();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmABC_Cliente man = new FrmABC_Cliente();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Veterinario man = new FrmABC_Veterinario();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Pedido man = new FrmABC_Pedido();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Citas man = new FrmABC_Citas();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Consultas man = new FrmABC_Consultas();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void recetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Recetario man = new FrmABC_Recetario();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void mercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABC_Mercaderia  man = new FrmABC_Mercaderia();

            man.MdiParent = this;

            man.Visible = true;
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCitasDiario rep = new FrmReporteCitasDiario();

            rep.MdiParent = this;

            rep.Visible = true;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteClientes rep = new FrmReporteClientes();

            rep.MdiParent = this;

            rep.Visible = true;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportePedidos rep = new FrmReportePedidos();

            rep.MdiParent = this;

            rep.Visible = true;
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario rep = new FrmInventario();

            rep.MdiParent = this;

            rep.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBienvenido bien = new FrmBienvenido();

            bien.Show();

            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
