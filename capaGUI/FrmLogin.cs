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

namespace CapaGUI
{
    public partial class FrmLogin : Form
    {
        ClassConnection conecta = new ClassConnection();
        SqlConnection cn;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void Login(String usuario, String pass)
        {
            try
            {

                cn = conecta.ConectarBD();
                SqlCommand cmd = new SqlCommand("Select usuario, tipoUsuario from tb_Login where usuario=@usuario and password=@password", cn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "admin")
                    {
                        FrmMDI_Mantenimiento man = new FrmMDI_Mantenimiento();
                        man.Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "Veterinario")
                    {
                        FrmMDI_Veterinaria vet = new FrmMDI_Veterinaria();
                        vet.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            conecta.cerrarBD();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login(txtUser.Text, txtPass.Text);
        }
    }
}
