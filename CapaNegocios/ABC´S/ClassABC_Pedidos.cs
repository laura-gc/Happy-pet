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
	public class ClassABC_Pedidos
	{
		SqlCommand Commando;
		SqlConnection cn;
		SqlDataReader reader;
		ClassConnection conecta = new ClassConnection();
		ClassEncap_Pedidos atriPe = new ClassEncap_Pedidos();
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

		public void LlenarCodMerca(ComboBox cboCodMerca)
		{
			cn = conecta.ConectarBD();
			CadenaSql = "Select codMerca from tb_Mercaderia";
			da = new SqlDataAdapter(CadenaSql, cn);
			dt = new DataTable();
			da.Fill(dt);

			cboCodMerca.DataSource = dt;
			cboCodMerca.DisplayMember = "codMerca";

			conecta.cerrarBD();

		}

		public void LlenarTipoMerca(ComboBox cboTipoMerca)
		{
			cn = conecta.ConectarBD();
			CadenaSql = "Select tipo from tb_Mercaderia";
			da = new SqlDataAdapter(CadenaSql, cn);
			dt = new DataTable();
			da.Fill(dt);

			cboTipoMerca.DataSource = dt;
			cboTipoMerca.DisplayMember = "tipo";

			conecta.cerrarBD();

		}

		public void RegistrarPedido(ClassEncap_Pedidos atriPe)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("RegistrarPedido", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@fechaEntrega", atriPe._FechaEntrega));
				Commando.Parameters.Add(new SqlParameter("@DireccionEntrega", atriPe._DireccionEntrega));
				Commando.Parameters.Add(new SqlParameter("@lote", atriPe._Lote));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriPe._DNI));
				Commando.Parameters.Add(new SqlParameter("@codMerca", atriPe._CodMerca));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Pedido Registrado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void EliminarPedido(ClassEncap_Pedidos atriPe)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("EliminarPedido", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codPedido", atriPe._CodPedido));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Pedido Eliminado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		public void ActualizarPedido(ClassEncap_Pedidos atriPe)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ActualizarPedido", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.Add(new SqlParameter("@codPedido", atriPe._CodPedido));
				Commando.Parameters.Add(new SqlParameter("@fechaEntrega", atriPe._FechaEntrega));
				Commando.Parameters.Add(new SqlParameter("@DireccionEntrega", atriPe._DireccionEntrega));
				Commando.Parameters.Add(new SqlParameter("@lote", atriPe._Lote));
				Commando.Parameters.Add(new SqlParameter("@DNI", atriPe._DNI));
				Commando.Parameters.Add(new SqlParameter("@codMerca", atriPe._CodMerca));
				Commando.ExecuteNonQuery();
				conecta.cerrarBD();

				MessageBox.Show("Pedido Actualizado...!!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string BuscarPedido(int codPedido)
		{
			cn = conecta.ConectarBD();
			string datobuscar = "";
			try
			{
				Commando = new SqlCommand("BuscarPedido", cn);
				Commando.CommandType = CommandType.StoredProcedure;
				Commando.Parameters.AddWithValue("@codPedido", codPedido);
				reader = Commando.ExecuteReader();
				if (reader.Read())
				{
					datobuscar = reader["codPedido"].ToString();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error no Encontrado" + ex.Message);
			}
			return datobuscar;
		}
		public void LlenarCampos(TextBox txtcodPedido, DateTimePicker dtpfechaEntrega, TextBox txtDireccion, TextBox txtLote, ComboBox cboDNI, ComboBox cboCodMerca)
		{
			try
			{
				if (BuscarPedido(Int16.Parse(txtcodPedido.Text)) != null)
				{
					dtpfechaEntrega.Value = reader.GetDateTime(1);
					txtDireccion.Text = reader.GetString(2);
					txtLote.Text = reader.GetInt32(3).ToString();
					cboDNI.Text = reader.GetString(4);
					cboCodMerca.Text = reader.GetString(5);

					MessageBox.Show("Datos encontrados");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			conecta.cerrarBD();

		}

		public void ConsultarPedido(DataGridView dtgdatos)
		{
			cn = conecta.ConectarBD();

			try
			{
				Commando = new SqlCommand("ConsultaPedidos", cn);
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
