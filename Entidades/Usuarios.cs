using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Usuarios
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string pass { get; set; }
    }
}
