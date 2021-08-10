using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClassEncap_Login
    {
        int codLog;
        String usuario, tipoUsuario, pass;

        public int _CodLog { get => codLog; set => codLog = value; }
        public string _Usuario { get => usuario; set => usuario = value; }
        public string _TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string _Pass { get => pass; set => pass = value; }
    }
}
