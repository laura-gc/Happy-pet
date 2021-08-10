using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Citas
    {
        int codCitas;
        DateTime FechaCita;
        String direccion, DNI, codVet;

        public int _CodCitas { get => codCitas; set => codCitas = value; }
        public DateTime _FechaCita1 { get => FechaCita; set => FechaCita = value; }
        public string _Direccion { get => direccion; set => direccion = value; }
        public string _DNI { get => DNI; set => DNI = value; }
        public string _CodVet { get => codVet; set => codVet = value; }
    }
}
