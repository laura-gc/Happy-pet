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
    public partial class FrmMDI_Veterinaria : Form
    {
        public FrmMDI_Veterinaria()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarConsulta con = new FrmRegistrarConsulta();

            con.MdiParent = this;

            con.Visible = true;
        }

        private void recetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarRecetario rec = new FrmRegistrarRecetario();

            rec.MdiParent = this;

            rec.Visible = true;
        }

        private void recetarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteRecetarioDiario rec = new FrmReporteRecetarioDiario();

            rec.MdiParent = this;

            rec.Visible = true;
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteConsultaDiario con = new FrmReporteConsultaDiario();

            con.MdiParent = this;

            con.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmBienvenido bn = new FrmBienvenido();
            bn.Show();
            this.Hide();
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarInfoMascota con = new FrmConsultarInfoMascota();

            con.MdiParent = this;

            con.Visible = true;
        }
    }
}
