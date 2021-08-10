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
    public class ClassABC_Consultas
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Consultas atriCon = new ClassEncap_Consultas();
		DataTable dt;
		SqlDataAdapter da;
		String CadenaSql;

		public void LlenarDNI(ComboBox cboDNI)
		{
			cn = conecta.ConectarBD();
			CadenaSql = "Select DNI from tb_Cliente";
			da = new SqlDataAdapter(CadenaSql, cn);
			dt = new DataTable();
			da.Fill(dt);

			cboDNI.DataSource = dt;
			cboDNI.DisplayMember = "DNI";

			conecta.cerrarBD();
		}

		public void LlenarCodVet(ComboBox cboCodVet)
		{
			cn = conecta.ConectarBD();
			CadenaSql = "Select codVet from tb_Veterinaria";
			da = new SqlDataAdapter(CadenaSql, cn);
			dt = new DataTable();
			da.Fill(dt);

			cboCodVet.DataSource = dt;
			cboCodVet.DisplayMember = "codVet";

			conecta.cerrarBD();

		}

		public void RegistrarConsulta(ClassEncap_Consultas atriCon)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarConsulta", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodCon", atriCon._CodCon));
				Commando.Parameters.Add(new SqlParameter("@FechaCon", atriCon._FechaCon));
				Commando.Parameters.Add(new SqlParameter("@Peso", atriCon._Peso));
				Commando.Parameters.Add(new SqlParameter("@vacunas", atriCon._Vacunas));
				Commando.Parameters.Add(new SqlParameter("@diagnostico", atriCon._Diagnostico));
				Commando.Parameters.Add(new SqlParameter("@observaciones", atriCon._Observaciones));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriCon._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriCon._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Consulta Guardada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarConsulta(ClassEncap_Consultas atriCon)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarConsulta", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodCon", atriCon._CodCon));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Consulta Eliminada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarConsulta(ClassEncap_Consultas atriCon)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarConsulta", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodCon", atriCon._CodCon));
				Commando.Parameters.Add(new SqlParameter("@FechaCon", atriCon._FechaCon));
				Commando.Parameters.Add(new SqlParameter("@Peso", atriCon._Peso));
				Commando.Parameters.Add(new SqlParameter("@vacunas", atriCon._Vacunas));
				Commando.Parameters.Add(new SqlParameter("@diagnostico", atriCon._Diagnostico));
				Commando.Parameters.Add(new SqlParameter("@observaciones", atriCon._Observaciones));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriCon._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriCon._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Consulta Actualizada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarConsulta(String CodCon)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarConsulta", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@CodCon", CodCon);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["CodCon"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtCodCon, DateTimePicker dtpfechaCon, TextBox txtPeso, TextBox txtDiagnosticos, TextBox txtObservaciones, ComboBox cboDNI, ComboBox cboCodVet)
		{
			try
			{
				if (BuscarConsulta(txtCodCon.Text) != null)
				{
					dtpfechaCon.Value = reader.GetDateTime(1);
					txtPeso.Text = reader.GetString(2);
					txtDiagnosticos.Text = reader.GetString(4);
					txtObservaciones.Text = reader.GetString(5);
					cboDNI.Text = reader.GetString(6);
					cboCodVet.Text = reader.GetString(7);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void Consultas(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("Consultas", cn);
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
