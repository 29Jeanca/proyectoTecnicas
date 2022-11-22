using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoTecnicas
{
    public partial class ventanaPaciente : Form
    {
        public ventanaPaciente()
        {
            InitializeComponent();
        }

        private void ventanaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.correo = txtCorreo.Text;
            paciente.estadoCivil = selectEstado.Text;
            paciente.patologia = checkPatologia.Checked;
            paciente.contrato = checkContrato.Checked;
            paciente.tipo = "Paciente";

            if (paciente.patologia && paciente.contrato)
            {
                paciente.activo = true;
            }

            int resultado = PacienteAgregar.agregarPaciente(paciente);

            if (resultado > 0)
            {
                MessageBox.Show("exito al guardar");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                checkContrato.Checked = false;
                checkPatologia.Checked = false;
                selectEstado.Text = "";
            }
            else
            {
                MessageBox.Show("No se puedo guardar");
            }
        }
    }
}
