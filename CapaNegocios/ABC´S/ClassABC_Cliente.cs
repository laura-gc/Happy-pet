using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;

namespace CapaNegocios
{
    public class ClassABC_Cliente
    {
        SqlDataReader reader;
        ClassConnection conectar = new ClassConnection();
        SqlConnection cn;
        SqlCommand Commando;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;

        public String RegistrarMascota(String DNI, String nomMas, String edad, String especie, String raza, String genero, String tlfn, String email, String direccion, PictureBox pbimagen)
        {
            cn = conectar.ConectarBD();
            String mensaje = "Registrado";


            try
            {
                Commando = new SqlCommand("RegistrarCliente", cn);
                Commando.CommandType = CommandType.StoredProcedure;
                Commando.Parameters.Add("@DNI", SqlDbType.Char);
                Commando.Parameters.Add("@nomMas", SqlDbType.VarChar);
                Commando.Parameters.Add("@edad", SqlDbType.Char);
                Commando.Parameters.Add("@especie", SqlDbType.VarChar);
                Commando.Parameters.Add("@raza", SqlDbType.VarChar);
                Commando.Parameters.Add("@genero", SqlDbType.Char);
                Commando.Parameters.Add("@tlfn", SqlDbType.Char);
                Commando.Parameters.Add("@email", SqlDbType.NVarChar);
                Commando.Parameters.Add("@direccion", SqlDbType.NVarChar);
                Commando.Parameters.Add("@img", SqlDbType.Image);
                Commando.Parameters["@DNI"].Value = DNI;
                Commando.Parameters["@nomMas"].Value = nomMas;
                Commando.Parameters["@edad"].Value = edad;
                Commando.Parameters["@especie"].Value = especie;
                Commando.Parameters["@raza"].Value = raza;
                Commando.Parameters["@genero"].Value = genero;
                Commando.Parameters["@tlfn"].Value = tlfn;
                Commando.Parameters["@email"].Value = email;
                Commando.Parameters["@direccion"].Value = direccion;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Commando.Parameters["@img"].Value = ms.GetBuffer();
                Commando.ExecuteNonQuery();
                conectar.cerrarBD(); ;

                MessageBox.Show("...¡¡¡Registrado!!!");

            }
            catch (Exception ex)
            {
                mensaje = "No se pudo registrar" + ex.ToString();
            }

            return mensaje;

        }

        public String EliminarCliente(String DNI)
        {
            cn = conectar.ConectarBD();
            String mensaje = "Se elimino el cliente";
            try
            {
                Commando = new SqlCommand("EliminarCliente", cn);
                Commando.CommandType = CommandType.StoredProcedure;
                Commando.Parameters.Add("@DNI", SqlDbType.Char);
                Commando.Parameters["@DNI"].Value=DNI;
                Commando.ExecuteNonQuery();
                conectar.cerrarBD();

                MessageBox.Show("Cliente Eliminado...");

            }
            catch (Exception ex)
            {
                mensaje = "No se pudo eliminar el cliente: " + ex.ToString();
            }

            return mensaje;

        }

        public String ModificarCliente(String DNI, String nomMas, String edad, String especie, String raza, String genero, String tlfn, String email, String direccion, PictureBox pbimagen)
        {
            cn = conectar.ConectarBD();
            String mensaje = "";


            try
            {
                Commando = new SqlCommand("ActualizarCliente", cn);
                Commando.CommandType = CommandType.StoredProcedure;
                Commando.Parameters.Add("@DNI", SqlDbType.Char);
                Commando.Parameters.Add("@nomMas", SqlDbType.VarChar);
                Commando.Parameters.Add("@edad", SqlDbType.Char);
                Commando.Parameters.Add("@especie", SqlDbType.VarChar);
                Commando.Parameters.Add("@raza", SqlDbType.VarChar);
                Commando.Parameters.Add("@genero", SqlDbType.Char);
                Commando.Parameters.Add("@tlfn", SqlDbType.Char);
                Commando.Parameters.Add("@email", SqlDbType.NVarChar);
                Commando.Parameters.Add("@direccion", SqlDbType.NVarChar);
                Commando.Parameters.Add("@img", SqlDbType.Image);
                Commando.Parameters["@DNI"].Value = DNI;
                Commando.Parameters["@nomMas"].Value = nomMas;
                Commando.Parameters["@edad"].Value = edad;
                Commando.Parameters["@especie"].Value = especie;
                Commando.Parameters["@raza"].Value = raza;
                Commando.Parameters["@genero"].Value = genero;
                Commando.Parameters["@tlfn"].Value = tlfn;
                Commando.Parameters["@email"].Value = email;
                Commando.Parameters["@direccion"].Value = direccion;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Commando.Parameters["@img"].Value = ms.GetBuffer();
                Commando.ExecuteNonQuery();
                conectar.cerrarBD(); ;

                MessageBox.Show("Se modifico el Cliente");


            }
            catch (Exception ex)
            {
                mensaje = "No se pudo modificar el cliente " + ex.ToString();
            }

            return mensaje;
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

        public void LlenarCampos(TextBox txtDNI, TextBox txtNomMas, TextBox txtedad, ComboBox cboespecie, ComboBox cboraza,TextBox txtTlfn, TextBox txtEmail, TextBox txtDireccion)
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

        public void ConsultaCliente(DataGridView dtgdatos)
        {
            cn = conectar.ConectarBD();

            try
            {
                Commando = new SqlCommand("ConsultaCliente", cn);
                Commando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(Commando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgdatos.DataSource = dt;
                conectar.cerrarBD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
