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
    public partial class ventanaVisitasPost : Form
    {
        public ventanaVisitasPost()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ventanaVisitasPost_Load(object sender, EventArgs e)
        {
            SqlDataReader idHospitalLector = agregarHospital.traerInformacionDB("idHospital","Operacion",null,null);
            SqlDataReader idPacienteLector = agregarHospital.traerInformacionDB("idPaciente", "Operacion", null, null);
            SqlDataReader idDoctorLector = agregarHospital.traerInformacionDB("idDoctor", "Operacion", null, null);
            while (idHospitalLector.Read()) 
            {
                comboNumHospital.Items.Add(idHospitalLector["idHospital"].ToString());
            }
         while (idPacienteLector.Read())
          {
              comboIDPaciente.Items.Add(idPacienteLector["idPaciente"].ToString());
            }
            while (idDoctorLector.Read())
            {
                comboIdDoctor.Items.Add(idDoctorLector["idDoctor"].ToString());
            }


        }

        private void btnRegistrarVisita_Click(object sender, EventArgs e)
        {
            V_Operatorias visitaOperatoria = new V_Operatorias();
            visitaOperatoria.idHospital = Convert.ToInt32(comboNumHospital.Text);
            visitaOperatoria.idPaciente = Convert.ToInt32(comboIDPaciente.Text);
            visitaOperatoria.tipoChequeo = comboTipodChequeo.Text;
            visitaOperatoria.estadoHerida = comboEstadoHerida.Text;
            visitaOperatoria.gasto = txtValorContrato.Text;
            visitaOperatoria.medicamento = txtMedicamento.Text;
            visitaOperatoria.fechaVisita = txtFecha.Text;
            visitaOperatoria.idDoctor = Convert.ToInt32(comboIdDoctor.Text);

            int resultado = agregarVisitas.insertarVisitas(visitaOperatoria);
            if (resultado > 0)
            {
                MessageBox.Show("Se guardó en la base de datos con exito.");
                txtValorContrato.Text = "";
                comboNumHospital.Text = "";
                comboIDPaciente.Text = "";
                comboTipodChequeo.Text = "";
                comboEstadoHerida.Text = "";
                comboIdDoctor.Text = "";
                txtMedicamento.Text = "";
            }
            else
            {
                MessageBox.Show("No se puedo guardar");
            }
        }
        private void comboNumHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaInicio inicio = new ventanaInicio();
            inicio.Show();
            this.Visible = false;
        }
    }
}
