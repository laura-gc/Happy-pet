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
    public class ClassABC_Citas
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Citas atriCitas = new ClassEncap_Citas();
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
		public void SolicitarCita(ClassEncap_Citas atriCitas)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarCita", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@fechaConsulta", atriCitas._FechaCita1));
				Commando.Parameters.Add(new SqlParameter("@direccion", atriCitas._Direccion));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriCitas._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriCitas._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Cita Registrada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarCita(ClassEncap_Citas atriCitas)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarCita", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codCita", atriCitas._CodCitas));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Cita Eliminada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarCita(ClassEncap_Citas atriCitas)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarCita", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codCita", atriCitas._CodCitas));
				Commando.Parameters.Add(new SqlParameter("@fechaConsulta", atriCitas._FechaCita1));
				Commando.Parameters.Add(new SqlParameter("@direccion", atriCitas._Direccion));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriCitas._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriCitas._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Cita actualizada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarCita(int codCita)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarCita", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@codCita", codCita);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["codCita"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtcodCita, DateTimePicker dtpfechaCita, TextBox txtDireccion, ComboBox cboDNI, ComboBox cboCodVet)
		{
			try
			{
				if (BuscarCita(Int16.Parse(txtcodCita.Text)) != null)
				{
					dtpfechaCita.Value = reader.GetDateTime(1);
					txtDireccion.Text = reader.GetString(2);
					cboDNI.Text = reader.GetString(3);
					cboCodVet.Text = reader.GetString(4);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultarCita(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultaCitas", cn);
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
