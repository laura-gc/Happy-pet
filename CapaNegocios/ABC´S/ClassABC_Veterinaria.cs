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
    public class ClassABC_Veterinaria
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Veterinario atriVet = new ClassEncap_Veterinario();

		public void RegistrarVeterinario(ClassEncap_Veterinario atriVet)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarVeterinaria", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codVet", atriVet._CodVet));
				Commando.Parameters.Add(new SqlParameter("@NomVete", atriVet._NomVete));
				Commando.Parameters.Add(new SqlParameter("@ApeVete", atriVet._ApeVete));
				Commando.Parameters.Add(new SqlParameter("@fechaNac", atriVet._FechaNac));
				Commando.Parameters.Add(new SqlParameter("@edad", atriVet._Edad));
				Commando.Parameters.Add(new SqlParameter("@Email", atriVet._Email));
				Commando.Parameters.Add(new SqlParameter("@FechaCon", atriVet._FechaCon));
				Commando.Parameters.Add(new SqlParameter("@direccion", atriVet._Direccion));
				Commando.Parameters.Add(new SqlParameter("@tlfn", atriVet._Tlfn));
				Commando.ExecuteNonQuery(); 
				conecta.cerrarBD();

				MessageBox.Show("Veterinari@ Registrado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarVeterinario(ClassEncap_Veterinario atriVet)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarVeterinaria", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codVet", atriVet._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Veterinari@ Eliminado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarVeterinario(ClassEncap_Veterinario atriVet)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarVeterinaria", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codVet", atriVet._CodVet));
				Commando.Parameters.Add(new SqlParameter("@NomVete", atriVet._NomVete));
				Commando.Parameters.Add(new SqlParameter("@ApeVete", atriVet._ApeVete));
				Commando.Parameters.Add(new SqlParameter("@fechaNac", atriVet._FechaNac));
				Commando.Parameters.Add(new SqlParameter("@edad", atriVet._Edad));
				Commando.Parameters.Add(new SqlParameter("@Email", atriVet._Email));
				Commando.Parameters.Add(new SqlParameter("@FechaCon", atriVet._FechaCon));
				Commando.Parameters.Add(new SqlParameter("@direccion", atriVet._Direccion));
				Commando.Parameters.Add(new SqlParameter("@tlfn", atriVet._Tlfn));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Veterinari@ Actualizad@...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarVeterinario(String CodVet)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarVeterinaria", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@codVet", CodVet);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["codVet"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtcodVet, TextBox txtnom, TextBox txtape, DateTimePicker dtpfechaNac, TextBox txtedad, TextBox txtemail, DateTimePicker dtpFechaCon, TextBox txtDireccion, TextBox txtTlfn)
		{
			try
			{
				if (BuscarVeterinario(txtcodVet.Text) != null)
				{
					txtnom.Text = reader.GetString(1);
					txtape.Text = reader.GetString(2);
					dtpfechaNac.Value = reader.GetDateTime(3);
					txtedad.Text = reader.GetInt32(4).ToString();
					txtemail.Text = reader.GetString(5);
					dtpFechaCon.Value = reader.GetDateTime(6);
					txtDireccion.Text = reader.GetString(7);
					txtTlfn.Text = reader.GetString(8);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultarVeterinarios(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultaVeterinaria", cn);
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
