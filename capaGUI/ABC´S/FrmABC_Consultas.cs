using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmABC_Consultas : Form
    {
        ClassABC_Consultas ABC = new ClassABC_Consultas();
        ClassEncap_Consultas atriCon = new ClassEncap_Consultas();
        SqlConnection cn = new SqlConnection();
        ClassConnection conectar = new ClassConnection();
        public FrmABC_Consultas()
        {
            InitializeComponent();
        }

        private void FrmABC_Consultas_Load(object sender, EventArgs e)
        {
            ABC.LlenarDNI(cboDni);
            ABC.LlenarCodVet(cboVeterinario);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                if (clbVacunas.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < clbVacunas.CheckedItems.Count; i++)
                    {
                        if (str == "")
                        {
                            str = clbVacunas.CheckedItems[i].ToString();
                        }
                        else
                        {
                            str += "," + clbVacunas.CheckedItems[i].ToString();
                        }

                    }

                    atriCon._CodCon = txtCodCon.Text;
                    atriCon._FechaCon = dtpFecha.Value.Date;
                    atriCon._Peso = txtPeso.Text;
                    atriCon._Vacunas = str;
                    atriCon._Diagnostico = txtDiagnostico.Text;
                    atriCon._Observaciones = txtObser.Text;
                    atriCon._DNI = cboDni.Text;
                    atriCon._CodVet = cboVeterinario.Text;

                    ABC.ActualizarConsulta(atriCon);

                    txtCodCon.Text = "";
                    txtPeso.Text = "";
                    txtDiagnostico.Text = "";
                    txtObser.Text = "";



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            atriCon._CodCon = txtCodCon.Text;
            ABC.EliminarConsulta(atriCon);

            txtCodCon.Text = "";
            txtPeso.Text = "";
            txtDiagnostico.Text = "";
            txtObser.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                if (clbVacunas.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < clbVacunas.CheckedItems.Count; i++)
                    {
                        if (str == "")
                        {
                            str = clbVacunas.CheckedItems[i].ToString();
                        }
                        else
                        {
                            str += "," + clbVacunas.CheckedItems[i].ToString();
                        }

                    }

                    atriCon._CodCon = txtCodCon.Text;
                    atriCon._FechaCon = dtpFecha.Value.Date;
                    atriCon._Peso = txtPeso.Text;
                    atriCon._Vacunas = str;
                    atriCon._Diagnostico = txtDiagnostico.Text;
                    atriCon._Observaciones = txtObser.Text;
                    atriCon._DNI = cboDni.Text;
                    atriCon._CodVet = cboVeterinario.Text;

                    ABC.RegistrarConsulta(atriCon);

                    txtCodCon.Text = "";
                    txtPeso.Text = "";
                    txtDiagnostico.Text = "";
                    txtObser.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ABC.Consultas(dgvConsultas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cn = conectar.ConectarBD();

            SqlCommand cmmd = new SqlCommand("Select * from tb_Consultas where CodCon = @CodCon", cn);
            cmmd.Parameters.AddWithValue("@CodCon", txtCodCon.Text);
            SqlDataReader lector = cmmd.ExecuteReader();

            if (lector.Read())
            {
                String vacunas = lector["vacunas"].ToString();



            }
            conectar.cerrarBD();

            ABC.LlenarCampos(txtCodCon, dtpFecha, txtPeso, txtDiagnostico, txtObser, cboDni, cboVeterinario);
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigoActualizar;
            int indiceFila = dgvConsultas.CurrentRow.Index;
            codigoActualizar = dgvConsultas.Rows[indiceFila].Cells[0].Value.ToString();
            txtCodCon.Text = dgvConsultas.Rows[indiceFila].Cells[0].Value.ToString();
        }
    }

    }

