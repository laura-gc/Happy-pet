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
    public partial class FrmReporteClientes : Form
    {
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_VeterinariaDataSet.tb_Cliente' Puede moverla o quitarla según sea necesario.
            this.tb_ClienteTableAdapter.FillBy(this.BD_VeterinariaDataSet.tb_Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
