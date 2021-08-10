using CapaDato;
using CapaNegocios;
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

namespace CapaGUI
{
    public partial class FrmConsultarInfoMascota : Form
    {
        ClassCli ABC = new ClassCli();
        SqlConnection cn = new SqlConnection();
        ClassConnection conectar = new ClassConnection();
        public FrmConsultarInfoMascota()
        {
            InitializeComponent();
        }

        private void cbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmConsultarInfoMascota_Load(object sender, EventArgs e)
        {
            ABC.LlenarDNI(cbDNI);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cn = conectar.ConectarBD();

            SqlCommand cmmd = new SqlCommand("Select * from tb_Cliente where DNI = @DNI", cn);
            cmmd.Parameters.AddWithValue("@DNI", cbDNI.Text);
            SqlDataReader lector = cmmd.ExecuteReader();

            if (lector.Read())
            {
                String genero = lector["genero"].ToString();

                switch (genero)
                {
                    case "M": rbM.Checked = true; rbF.Checked = false; break;
                    case "H": rbF.Checked = true; rbM.Checked = false; break;

                }
            }

            conectar.cerrarBD();

            ABC.LlenarCampos(cbDNI, txtNom, txtEdad, txtEspecie, txtRaza, txtTelefono, txtEmail, txtDirec);
            ABC.VerImagen(pbImagen, cbDNI.Text);
        }
    }
    
}
