using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Cliente
    {
        String DNI, nomMas, edad, especie, raza, genero, tlfn, email, direccion;
        Byte[] imagen;

        public string _DNI { get => DNI; set => DNI = value; }
        public string _NomMas { get => nomMas; set => nomMas = value; }
        public string _Edad { get => edad; set => edad = value; }
        public string _Especie { get => especie; set => especie = value; }
        public string _Raza { get => raza; set => raza = value; }
        public string _Genero { get => genero; set => genero = value; }
        public string _Tlfn { get => tlfn; set => tlfn = value; }
        public string _Email { get => email; set => email = value; }
        public string _Direccion { get => direccion; set => direccion = value; }
        public byte[] _Imagen { get => imagen; set => imagen = value; }
    }
}
