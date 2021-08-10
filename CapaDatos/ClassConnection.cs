using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDato
{
    public class ClassConnection
    {
		SqlConnection cn = new SqlConnection();

		public SqlConnection ConectarBD()
		{

			try
			{
				cn = new SqlConnection("Data Source=DESKTOP-PMMFK0V\\SQLEXPRESS; Initial Catalog = BD_Veterinaria; Integrated security=True");
				cn.Open();
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Conexion Fallida", ex.Message);
			}

			return cn;

		}

		public void cerrarBD()
		{
			if (ConnectionState.Open == cn.State)
			{
				cn.Close();
			}

		}
	}
}
