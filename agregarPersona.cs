using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTecnicas
{
    public class PacienteAgregar
    {
        public static int agregarPaciente(Paciente paciente)
        {

            using (SqlConnection conexion = conexionBD.abrirConexion()
)
            {
                string query = "insert into Personas (nombre, apellido, telefono, correo, estadoCivil,activo, tipo) values('" + paciente.nombre + "', '" + paciente.apellido + "', " + paciente.telefono + ", '" + paciente.correo + "', '" + paciente.estadoCivil + "', '" + paciente.activo + "', '" + paciente.tipo + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }

        public static int agregarDoctor(Doctor doctor)
        {
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Personas (nombre, apellido, telefono,correo,especialidad,gradoAcademico,estadoCivil,tipo) values('" + doctor.nombre + "', '" + doctor.apellido + "', '" + doctor.telefono + "', '" + doctor.correo + "','" + doctor.especialidad + "', '" + doctor.gradoAcademico + "','" + doctor.estadoCivil + "', '" + doctor.tipo + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
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
        public static int generadorDeNumerosRandoms()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return numero;
        }
    }
}
