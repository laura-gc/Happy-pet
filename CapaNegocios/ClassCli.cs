using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
     public class ClassCli
    {
        SqlDataReader reader;
        ClassConnection conectar = new ClassConnection();
        SqlConnection cn;
        SqlCommand Commando;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        DataTable dt;
        String CadenaSql;

        public void LlenarDNI(ComboBox cboDNI)
        {
            cn = conectar.ConectarBD();
            CadenaSql = "Select DNI from tb_Cliente";
            da = new SqlDataAdapter(CadenaSql, cn);
            dt = new DataTable();
            da.Fill(dt);

            cboDNI.DataSource = dt;
            cboDNI.DisplayMember = "DNI";

            conectar.cerrarBD();
        }

        public String BuscarCliente(String DNI)
        {
            cn = conectar.ConectarBD();
            String buscar = "";
            try
            {

                Commando = new SqlCommand("BuscarCliente", cn);
                Commando.CommandType = CommandType.StoredProcedure;
                Commando.Parameters.AddWithValue("@DNI", DNI);
                reader = Commando.ExecuteReader();
                if (reader.Read())
                {
                    buscar = reader["DNI"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo Encontrar" + ex.Message);
            }

            return buscar;
        }


        public void LlenarCampos(ComboBox txtDNI, TextBox txtNomMas, TextBox txtedad, TextBox cboespecie, TextBox cboraza, TextBox txtTlfn, TextBox txtEmail, TextBox txtDireccion)
        {

            try
            {

                if (BuscarCliente(txtDNI.Text) != null)
                {
                    txtNomMas.Text = reader.GetString(1);
                    txtedad.Text = reader.GetString(2);
                    cboespecie.Text = reader.GetString(3);
                    cboraza.Text = reader.GetString(4);
                    txtTlfn.Text = reader.GetString(6);
                    txtEmail.Text = reader.GetString(7);
                    txtDireccion.Text = reader.GetString(8);

                    MessageBox.Show("Datos encontrados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectar.cerrarBD();


        }

        public void VerImagen(PictureBox pbFoto, string DNI)
        {
            try
            {
                da = new SqlDataAdapter("Select img from tb_Cliente where DNI = '" + DNI + "'", cn);
                ds = new DataSet();
                da.Fill(ds, "tb_Cliente");
                byte[] datos = new byte[0];
                dr = ds.Tables["tb_Cliente"].Rows[0];
                datos = (byte[])dr["img"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }


        }
    }
}
