using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTecnicas
{
    public class conexionBD
    {
        public static SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=JEANCA;Initial Catalog=proyectoHospitales;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
