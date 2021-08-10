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
    public partial class FrmReporteCitasDiario : Form
    {
        ClassABC_Citas ABC = new ClassABC_Citas();
        public FrmReporteCitasDiario()
        {
            InitializeComponent();
        }

        private void FrmReporteCitasDiario_Load(object sender, EventArgs e)
        {
           
            ABC.LlenarCodVet(cbVet);      
        }

        private void cbVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tb_CitaTableAdapter.Fecha(this.BD_VeterinariaDataSet.tb_Cita, cbVet.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
