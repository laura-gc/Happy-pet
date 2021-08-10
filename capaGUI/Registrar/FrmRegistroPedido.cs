using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmRegistroPedido : Form
    {
        SqlConnection cn = new SqlConnection();
        ClassConnection conectar = new ClassConnection();
        ClassABC_Pedidos ABC = new ClassABC_Pedidos();
        ClassEncap_Pedidos atriPedidos = new ClassEncap_Pedidos();

        public FrmRegistroPedido()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = conectar.ConectarBD();

            SqlCommand cmmd = cn.CreateCommand();
            cmmd.CommandType = CommandType.Text;
            cmmd.CommandText = "Select * from tb_Mercaderia where tipo like ('" + cboTipo.Text + "%')";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            da.Fill(dt);

            dgvMercaderia.DataSource = dt;

            conectar.cerrarBD();
        }

        private void FrmRegistroPedido_Load(object sender, EventArgs e)
        {
            ABC.LlenarTipoMerca(cboTipo);
            ABC.LlenarCodMerca(cboCodMerca);
            ABC.LlenarDNI(cboDNI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            atriPedidos._FechaEntrega = dtpFecha.Value.Date;
            atriPedidos._DireccionEntrega = txtDireccion.Text;
            atriPedidos._Lote = Int16.Parse(txtCant.Text);
            atriPedidos._CodMerca = cboCodMerca.Text;
            atriPedidos._DNI = cboDNI.Text;

            ABC.RegistrarPedido(atriPedidos);

            txtDireccion.Text = "";
            txtCant.Text = "0";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmBienvenido bn = new FrmBienvenido();
            bn.Show();
            this.Hide();
        }
    }
}
