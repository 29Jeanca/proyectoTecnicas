using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTecnicas
{
    public class agregarOperaciones
    {
        public static int agregarOperacion(Operaciones operacion)
        {
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Operacion (idPaciente, idDoctor, idHospital, codigoContrato, valorContrato, descripcion) values('" + operacion.idPaciente + "', '" + operacion.idDoctor + "', " + operacion.idHospital + ", '" + operacion.codigoContrato + "', '" + operacion.valorContrato + "', '" + operacion.descripcion + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
    }
}
