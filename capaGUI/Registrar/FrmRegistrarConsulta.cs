using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaGUI
{
    public partial class FrmRegistrarConsulta : Form
    {
        ClassABC_Consultas ABC = new ClassABC_Consultas();

        ClassEncap_Consultas atriCon = new ClassEncap_Consultas();
        public FrmRegistrarConsulta()
        {
            InitializeComponent();
        }

        private void FrmRegistrarConsulta_Load(object sender, EventArgs e)
        {
            ABC.LlenarDNI(cboDni);
            ABC.LlenarCodVet(cboVeterinario);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
