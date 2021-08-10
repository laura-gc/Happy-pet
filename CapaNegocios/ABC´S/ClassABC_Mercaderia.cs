using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;

namespace CapaNegocios
{
    public class ClassABC_Mercaderia
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Mercaderia atriMerca = new ClassEncap_Mercaderia();

		public void RegistrarMercaderia(ClassEncap_Mercaderia atriMerca)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarMercaderia", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codMerca", atriMerca._CodMerca));
				Commando.Parameters.Add(new SqlParameter("@tipo", atriMerca._Tipo));
				Commando.Parameters.Add(new SqlParameter("@nomMerca", atriMerca._NomMerca));
				Commando.Parameters.Add(new SqlParameter("@fechaVen", atriMerca._FechaVen));
				Commando.Parameters.Add(new SqlParameter("@stock", atriMerca._Stock));
				Commando.Parameters.Add(new SqlParameter("@precio", atriMerca._Precio));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Producto Registrado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarMercaderia(ClassEncap_Mercaderia atriMerca)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarMercaderia", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codMerca", atriMerca._CodMerca));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Producto Eliminado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarMercaderia(ClassEncap_Mercaderia atriMerca)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarMercaderia", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codMerca", atriMerca._CodMerca));
				Commando.Parameters.Add(new SqlParameter("@tipo", atriMerca._Tipo));
				Commando.Parameters.Add(new SqlParameter("@nomMerca", atriMerca._NomMerca));
				Commando.Parameters.Add(new SqlParameter("@fechaVen", atriMerca._FechaVen));
				Commando.Parameters.Add(new SqlParameter("@stock", atriMerca._Stock));
				Commando.Parameters.Add(new SqlParameter("@precio", atriMerca._Precio));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Producto Actualizado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarMercaderia(String CodMerca)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarMercaderia", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@codMerca", CodMerca);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["codMerca"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtcodMerca, TextBox cboTipo, TextBox txtNom, DateTimePicker dtpfechaVen, TextBox txtStock, TextBox txtprecio)
		{
			try
			{
				if (BuscarMercaderia(txtcodMerca.Text) != null)
				{
					cboTipo.Text = reader.GetString(1);
					txtNom.Text = reader.GetString(2);
					dtpfechaVen.Value = reader.GetDateTime(3);
					txtStock.Text = reader.GetInt32(4).ToString();
					txtprecio.Text = reader.GetInt32(5).ToString();
					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultarMercaderia(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultaMercaderia", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter adapter = new SqlDataAdapter(Commando);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dtgdatos.DataSource = dt;
				conecta.cerrarBD();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
