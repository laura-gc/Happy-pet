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
    public partial class FrmReportePedidos : Form
    {
        public FrmReportePedidos()
        {
            InitializeComponent();
        }

        private void FrmReportePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_VeterinariaDataSet.tb_Pedidos' Puede moverla o quitarla según sea necesario.
            this.tb_PedidosTableAdapter.FechaNow(this.BD_VeterinariaDataSet.tb_Pedidos);
           

            this.reportViewer1.RefreshReport();
        }
    }
}
