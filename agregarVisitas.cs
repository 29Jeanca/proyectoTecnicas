using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace proyectoTecnicas
{
    public class agregarVisitas
    {
        public static int insertarVisitas(V_Operatorias visitaOperatoria)
        {
            SqlConnection conexion = conexionBD.abrirConexion();
            {
                string query = "insert into visitasPostOperatorias (idHospital, idPaciente, tipoVisita, estadoHerida, gasto,medicamento,fechaVisita,idDoctor) values(" + visitaOperatoria.idHospital + ", " + visitaOperatoria.idPaciente + ", '"+ visitaOperatoria.tipoChequeo+"', '" + visitaOperatoria.estadoHerida + "', " + visitaOperatoria.gasto + ", '" + visitaOperatoria.medicamento + "','"+ visitaOperatoria.fechaVisita+"',"+ visitaOperatoria.idDoctor+")";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
    }
}
