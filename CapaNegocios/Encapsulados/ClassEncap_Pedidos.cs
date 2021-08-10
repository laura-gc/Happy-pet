using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Pedidos
    {
        int codPedido, lote;
        DateTime fechaEntrega;
        String direccionEntrega, DNI, codMerca;

        public int _CodPedido { get => codPedido; set => codPedido = value; }
        public int _Lote { get => lote; set => lote = value; }
        public DateTime _FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string _DireccionEntrega { get => direccionEntrega; set => direccionEntrega = value; }
        public string _DNI { get => DNI; set => DNI = value; }
        public string _CodMerca { get => codMerca; set => codMerca = value; }
    }
}
