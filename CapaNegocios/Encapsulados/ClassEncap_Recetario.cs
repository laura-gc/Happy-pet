using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Recetario
    {
		String codRecetario, viaAdm,dosisporUnidad,duraciondeltratamiento,indicaciones,medicamentos,observaciones,DNI, codVet;

        public string _CodRecetario { get => codRecetario; set => codRecetario = value; }
        public string _ViaAdm { get => viaAdm; set => viaAdm = value; }
        public string _DosisporUnidad { get => dosisporUnidad; set => dosisporUnidad = value; }
        public string _Duraciondeltratamiento { get => duraciondeltratamiento; set => duraciondeltratamiento = value; }
        public string _Indicaciones { get => indicaciones; set => indicaciones = value; }
        public string _Medicamentos { get => medicamentos; set => medicamentos = value; }
        public string _Observaciones { get => observaciones; set => observaciones = value; }
        public string _DNI { get => DNI; set => DNI = value; }
        public string _CodVet { get => codVet; set => codVet = value; }
    }
}
