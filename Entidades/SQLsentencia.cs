using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SQLsentencia
    {

        // Insert into Usuario (cedula,nombre, pass) Value (parametros)
        public string Peticion { get; set; }

        public List<SqlParameter> listaParametro { get; set; }

        public SQLsentencia()
        {

        }
    }
}
