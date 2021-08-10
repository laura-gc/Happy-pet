using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmABC_Pedido : Form
    {
        ClassABC_Pedidos ABC = new ClassABC_Pedidos();
        ClassEncap_Pedidos atriPe = new ClassEncap_Pedidos();

        
        public FrmABC_Pedido()
        {
            InitializeComponent();
        }

        private void FrmABC_Pedido_Load(object sender, EventArgs e)
        {
            ABC.LlenarDNI(cboDNI);
            ABC.LlenarCodMerca(cboCodMerca);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.ConsultarPedido(dgvPedido);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            atriPe._FechaEntrega = dtpFecha.Value.Date;
            atriPe._DireccionEntrega = txtDireccion.Text;
            atriPe._Lote = Int16.Parse(txtCant.Text);
            atriPe._CodMerca = cboCodMerca.Text;
            atriPe._DNI = cboDNI.Text;

            ABC.RegistrarPedido(atriPe);

            txtDireccion.Text = "";
            txtCant.Text = "0";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            atriPe._CodPedido = Int16.Parse(txtCodPed.Text);
            atriPe._FechaEntrega = dtpFecha.Value.Date;
            atriPe._DireccionEntrega = txtDireccion.Text;
            atriPe._Lote = Int16.Parse(txtCant.Text);
            atriPe._CodMerca = cboCodMerca.Text;
            atriPe._DNI = cboDNI.Text;

            ABC.ActualizarPedido(atriPe);

            txtDireccion.Text = "";
            txtCant.Text = "0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            atriPe._CodPedido = Int16.Parse(txtCodPed.Text);
            ABC.EliminarPedido(atriPe);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ABC.LlenarCampos(txtCodPed, dtpFecha, txtDireccion, txtCant, cboDNI, cboCodMerca);
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvPedido.CurrentRow.Index;
            codigoActualizar = dgvPedido.Rows[indiceFila].Cells[0].Value.ToString();
            txtCodPed.Text = dgvPedido.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }
}
