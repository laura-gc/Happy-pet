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
    public class ClassABC_Recetario
    {
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Recetario atriRec = new ClassEncap_Recetario();
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

		public void RegistrarRecetario(ClassEncap_Recetario atriRec)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarRecetario", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodRecetario", atriRec._CodRecetario));
				Commando.Parameters.Add(new SqlParameter("@viaAdm", atriRec._ViaAdm));
				Commando.Parameters.Add(new SqlParameter("@dosisporUnidad", atriRec._DosisporUnidad));
				Commando.Parameters.Add(new SqlParameter("@duraciondeltratamiento", atriRec._Duraciondeltratamiento));
				Commando.Parameters.Add(new SqlParameter("@indicaciones", atriRec._Indicaciones));
				Commando.Parameters.Add(new SqlParameter("@medicamentos", atriRec._Medicamentos));
				Commando.Parameters.Add(new SqlParameter("@observaciones", atriRec._Observaciones));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriRec._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriRec._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Recetario Guardada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarRecetario(ClassEncap_Recetario atriRec)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarRecetario", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodRecetario", atriRec._CodRecetario));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Recetario Eliminado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarRecetario(ClassEncap_Recetario atriRec)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarRecetario", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@CodRecetario", atriRec._CodRecetario));
				Commando.Parameters.Add(new SqlParameter("@viaAdm", atriRec._ViaAdm));
				Commando.Parameters.Add(new SqlParameter("@dosisporUnidad", atriRec._DosisporUnidad));
				Commando.Parameters.Add(new SqlParameter("@duraciondeltratamiento", atriRec._Duraciondeltratamiento));
				Commando.Parameters.Add(new SqlParameter("@indicaciones", atriRec._Indicaciones));
				Commando.Parameters.Add(new SqlParameter("@medicamentos", atriRec._Medicamentos));
				Commando.Parameters.Add(new SqlParameter("@observaciones", atriRec._Observaciones));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriRec._DNI));
				Commando.Parameters.Add(new SqlParameter("@codVet", atriRec._CodVet));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Recetario Actualizada...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarRecetario(String CodRecetario)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarRecetario", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@CodRecetario", CodRecetario);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["CodRecetario"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtCodRecetario, ComboBox cboViaAdm, TextBox txtDosis, TextBox txtDuracion, TextBox txtIndicaciones, TextBox txtMedicamentos, TextBox txtObservaciones, ComboBox cboDNI, ComboBox cboCodVet)
		{
			try
			{
				if (BuscarRecetario(txtCodRecetario.Text) != null)
				{
					cboViaAdm.Text = reader.GetString(1);
					txtDosis.Text = reader.GetString(2);
					txtDuracion.Text = reader.GetString(3);
					txtIndicaciones.Text = reader.GetString(4);
					txtMedicamentos.Text = reader.GetString(5);
					txtObservaciones.Text = reader.GetString(6);
					cboDNI.Text = reader.GetString(7);
					cboCodVet.Text = reader.GetString(8);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultaRecetarios(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultaRecetarios", cn);
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
