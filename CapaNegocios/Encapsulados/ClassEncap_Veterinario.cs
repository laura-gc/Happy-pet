using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Veterinario
    {
        String codVet, nomVete, apeVete, email, direccion, tlfn;
        DateTime fechaNac, fechaCon;
        int edad;

        public string _CodVet { get => codVet; set => codVet = value; }
        public string _NomVete { get => nomVete; set => nomVete = value; }
        public string _ApeVete { get => apeVete; set => apeVete = value; }
        public string _Email { get => email; set => email = value; }
        public string _Direccion { get => direccion; set => direccion = value; }
        public string _Tlfn { get => tlfn; set => tlfn = value; }
        public DateTime _FechaNac { get => fechaNac; set => fechaNac = value; }
        public DateTime _FechaCon { get => fechaCon; set => fechaCon = value; }
        public int _Edad { get => edad; set => edad = value; }
    }
}
