using CapaNegocios;
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
    public partial class FrmReporteRecetarioDiario : Form
    {
        ClassABC_Recetario ABC = new ClassABC_Recetario();
        public FrmReporteRecetarioDiario()
        {
            InitializeComponent();
        }

        private void FrmReporteRecetarioDiario_Load(object sender, EventArgs e)
        {
            
            ABC.LlenarDNI(cboDNI);

        }

        private void cboDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tb_RecetarioTableAdapter.Cli(this.BD_VeterinariaDataSet.tb_Recetario, cboDNI.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
