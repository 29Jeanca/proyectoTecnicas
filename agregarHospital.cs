using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace proyectoTecnicas
{
    public class agregarHospital
    {
        public static int insertarHospital(Hospital hospital)
        {
            { 
            SqlConnection conexion = conexionBD.abrirConexion();
            string cadenaInsertar = "INSERT Into Hospital(valorFiscal,areaTerreno,direcExacta,provincia,canton,distrito,cantNiveles,color,cantConsultorios,tiposdCirugia,anoConstruccion,imagen )values('" + hospital.valorFiscal + "','" + hospital.areaTerreno + "','" + hospital.direcExacta + "','" + hospital.provincia + "','" + hospital.canton + "','"+hospital.distrito+"','"+hospital.cantNiveles+"','"+hospital.color+"','"+hospital.cantConsultorios+"','"+hospital.tiposdCirugia+"','"+hospital.anoConstruccion+"','"+hospital.imagen+"')";
            SqlCommand comando = new SqlCommand(cadenaInsertar, conexion);
            comando.ExecuteNonQuery();
            }
            return 1;
        }
        public static SqlDataReader traerInformacionDB(string columnas, string tabla, string filtrar, string dato)
        {
            if (filtrar == null && dato == null)
            {
                SqlConnection conexion = conexionBD.abrirConexion();
                string query = "select " + columnas + " from " + tabla + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }
            else
            {
                SqlConnection conexion = conexionBD.abrirConexion();
                string query = "select " + columnas + " from " + tabla + "  where " + filtrar + " = '" + dato + "';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }

        }
    }
}
