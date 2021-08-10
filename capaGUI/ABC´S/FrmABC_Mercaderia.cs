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
    public partial class FrmABC_Mercaderia : Form
    {

        ClassABC_Mercaderia ABC = new ClassABC_Mercaderia();
        ClassEncap_Mercaderia atri = new ClassEncap_Mercaderia();
        public FrmABC_Mercaderia()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.ConsultarMercaderia(dgvMerca);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            atri._CodMerca = txtCod.Text;
            atri._Tipo = txtTipo.Text;
            atri._NomMerca = txtNombre.Text;
            atri._FechaVen = dtpVenci.Value.Date;
            atri._Stock = Int16.Parse(txtStock.Text);
            atri._Precio = Int16.Parse(txtPrecio.Text);

            ABC.ActualizarMercaderia(atri);

            txtCod.Text = "";
            txtTipo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "0";
            txtPrecio.Text = "0";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ABC.LlenarCampos(txtCod, txtTipo, txtNombre, dtpVenci, txtStock, txtPrecio);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            atri._CodMerca = txtCod.Text;
            atri._Tipo = txtTipo.Text;
            atri._NomMerca = txtNombre.Text;
            atri._FechaVen = dtpVenci.Value.Date;
            atri._Stock = Int16.Parse(txtStock.Text);
            atri._Precio = Int16.Parse(txtPrecio.Text);

            ABC.RegistrarMercaderia(atri);

            txtCod.Text = "";
            txtTipo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "0";
            txtPrecio.Text = "0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            atri._CodMerca = txtCod.Text;
            ABC.EliminarMercaderia(atri);

            txtCod.Text = "";
            txtTipo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "0";
            txtPrecio.Text = "0";
        }

        private void FrmABC_Mercaderia_Load(object sender, EventArgs e)
        {

        }

        private void dgvMerca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvMerca.CurrentRow.Index;
            codigoActualizar = dgvMerca.Rows[indiceFila].Cells[0].Value.ToString();
            txtCod.Text = dgvMerca.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }
}
