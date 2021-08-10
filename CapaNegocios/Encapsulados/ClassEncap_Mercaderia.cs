using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Mercaderia
    {
        String codMerca, tipo, nomMerca;
        DateTime fechaVen;
	    int stock, precio;

        public string _CodMerca { get => codMerca; set => codMerca = value; }
        public string _Tipo { get => tipo; set => tipo = value; }
        public string _NomMerca { get => nomMerca; set => nomMerca = value; }
        public DateTime _FechaVen { get => fechaVen; set => fechaVen = value; }
        public int _Stock { get => stock; set => stock = value; }
        public int _Precio { get => precio; set => precio = value; }
    }
}
