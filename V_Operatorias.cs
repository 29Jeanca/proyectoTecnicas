using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoTecnicas
{
    public class V_Operatorias
    {
        public int idHospital { get; set; }
        public int idPaciente { get; set; }
        public string tipoChequeo { get; set; }
        public string estadoHerida { get; set; }
        public string gasto { get; set; }
        public string medicamento { get; set; }
        public string fechaVisita { get; set; }
        public int idDoctor { get; set; }

        public V_Operatorias()
        {

        }
        public V_Operatorias(int idHospital, int idPaciente, string tipoChequeo, string estadoHerida, string gasto, string medicamento, string fechaVisita, int idDoctor)
        {
            this.idHospital = idHospital;
            this.idPaciente = idPaciente;
            this.tipoChequeo = tipoChequeo;
            this.estadoHerida = estadoHerida;
            this.gasto = gasto;
            this.medicamento = medicamento;
            this.fechaVisita = fechaVisita;
            this.idDoctor = idDoctor;
        }
    }
}
