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
    public partial class FrmReporteConsultaDiario : Form
    {
        ClassABC_Consultas ABC = new ClassABC_Consultas();
        public FrmReporteConsultaDiario()
        {
            InitializeComponent();
        }

        private void FrmReporteConsultaDiario_Load(object sender, EventArgs e)
        {          
            ABC.LlenarDNI(cboDNI);

        }

        private void cboDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tb_ConsultasTableAdapter.Cli(this.BD_VeterinariaDataSet.tb_Consultas, cboDNI.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
