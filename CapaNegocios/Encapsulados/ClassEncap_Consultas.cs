using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Consultas
    {
        String CodCon, vacunas, diagnostico, observaciones, DNI, codVet;
        DateTime fechaCon;
        String peso;

        public string _CodCon { get => CodCon; set => CodCon = value; }
        public string _Vacunas { get => vacunas; set => vacunas = value; }
        public string _Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string _Observaciones { get => observaciones; set => observaciones = value; }
        public string _DNI { get => DNI; set => DNI = value; }
        public string _CodVet { get => codVet; set => codVet = value; }
        public DateTime _FechaCon { get => fechaCon; set => fechaCon = value; } 
        public string _Peso { get => peso; set => peso = value; }
    }
}
