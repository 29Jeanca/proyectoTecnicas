using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoTecnicas
{
    public partial class ventanaOperaciones : Form
    {
        public ventanaOperaciones()
        {
            InitializeComponent();
        }

        private void ventanaOperaciones_Load(object sender, EventArgs e)
        {
            SqlDataReader idHospitalLector = agregarHospital.traerInformacionDB("id", "Hospital", null, null);
            SqlDataReader idPacienteLector = agregarHospital.traerInformacionDB("id", "Personas", null, null);
            SqlDataReader idDoctorLector = agregarHospital.traerInformacionDB("id", "Personas", null, null);
            while (idDoctorLector.Read())
            {
                comboDoctor.Items.Add(idDoctorLector["id"].ToString());
            }
            while (idHospitalLector.Read())
            {
                comboHospital.Items.Add(idHospitalLector["id"].ToString());
            }
            while (idPacienteLector.Read())
            {
                comboPaciente.Items.Add(idPacienteLector["id"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            operacion.idPaciente = Convert.ToInt32(comboPaciente.Text);
            operacion.idDoctor = Convert.ToInt32(comboDoctor.Text);
            operacion.idHospital = Convert.ToInt32(comboHospital.Text);
            operacion.codigoContrato = "CIR" + PacienteAgregar.generadorDeNumerosRandoms();
            operacion.valorContrato = Convert.ToDouble(txtValorContrato.Text);
            operacion.descripcion = txtDescripcion.Text;
            int resultado = agregarOperaciones.agregarOperacion(operacion);

            if (resultado > 0)
            {
                MessageBox.Show("Operacion Registrada");
                comboPaciente.Text = "";
                comboDoctor.Text = "";
                comboHospital.Text = "";
                txtValorContrato.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
