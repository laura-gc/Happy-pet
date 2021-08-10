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
    public class ClassABC_Login
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Login atriLo = new ClassEncap_Login();

	public void RegistrarLogin(ClassEncap_Login atriLo)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarLogin", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@usuario", atriLo._Usuario));
				Commando.Parameters.Add(new SqlParameter("@tipoUsuario", atriLo._TipoUsuario));
				Commando.Parameters.Add(new SqlParameter("@password", atriLo._Pass));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Usuario y contraseña Registradas...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarLogin(ClassEncap_Login atriLo)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarLogin", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodLo", atriLo._CodLog));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Usuario y contraseña Eliminadas...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarLogin(ClassEncap_Login atriLo)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarLogin", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodLo", atriLo._CodLog));
				Commando.Parameters.Add(new SqlParameter("@usuario", atriLo._Usuario));
				Commando.Parameters.Add(new SqlParameter("@tipoUsuario", atriLo._TipoUsuario));
				Commando.Parameters.Add(new SqlParameter("@password", atriLo._Pass));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Usuario y contraseña actualizados...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarLogin(int CodLog)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarLogin", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@CodLo", CodLog);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["CodLo"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtCodLog, TextBox txtUsuario, TextBox txtTipoUsuario, TextBox txtpass)
		{
			try
			{
				if (BuscarLogin(Int16.Parse(txtCodLog.Text)) != null)
				{
					txtUsuario.Text = reader.GetString(1);
					txtTipoUsuario.Text = reader.GetString(2);
					txtpass.Text = reader.GetString(3);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultarLogin(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultasLogin", cn);
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
