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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD_VeterinariaDataSet.tb_Mercaderia' Puede moverla o quitarla según sea necesario.
            this.tb_MercaderiaTableAdapter.FillBy(this.BD_VeterinariaDataSet.tb_Mercaderia);
          
            this.reportViewer1.RefreshReport();
        }
    }
}
