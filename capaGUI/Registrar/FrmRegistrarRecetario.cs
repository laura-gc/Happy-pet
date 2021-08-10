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
    public partial class FrmRegistrarRecetario : Form
    {
        ClassABC_Recetario ABC = new ClassABC_Recetario();

        ClassEncap_Recetario atriRec = new ClassEncap_Recetario();

        public FrmRegistrarRecetario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            atriRec._CodRecetario = txtCod.Text;
            atriRec._ViaAdm = cboVia.Text;
            atriRec._DosisporUnidad = txtDosis.Text;
            atriRec._Duraciondeltratamiento = txtDuracion.Text;
            atriRec._Indicaciones = txtIndicaciones.Text;
            atriRec._Medicamentos = txtMed.Text;
            atriRec._Observaciones = txtObser.Text;
            atriRec._DNI = cboDNI.Text;
            atriRec._CodVet = cboVet.Text;

            ABC.RegistrarRecetario(atriRec);

        }

        private void FrmRegistrarRecetario_Load(object sender, EventArgs e)
        {
            cboVia.Items.Add("Oral");
            cboVia.Items.Add("Sublingual");
            cboVia.Items.Add("Tópica");
            cboVia.Items.Add("Trandérmica");
            cboVia.Items.Add("Oftálmica");
            cboVia.Items.Add("Ótica");
            cboVia.Items.Add("Intranasal");
            cboVia.Items.Add("Inhalatoria");
            cboVia.Items.Add("Rectal");
            cboVia.Items.Add("Vaginal");
            cboVia.Items.Add("Parental");
            cboVia.Items.Add("Tópica");

            ABC.LlenarDNI(cboDNI);
            ABC.LlenarCodVet(cboVet);

        }
    }
}
