using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Y_YReservas.Data
{
   public class Conexion
    {
        public static string COnexion()
        {
            return ConfigurationManager.ConnectionStrings["SQLserver"].ConnectionString;
        }
    }
}
