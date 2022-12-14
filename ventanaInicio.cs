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
    public partial class ventanaInicio : Form
    {
        public ventanaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaDoctor formDoctor=new ventanaDoctor(); 
            formDoctor.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaPaciente formPaciente = new ventanaPaciente();
            formPaciente.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaHospital formHospital = new ventanaHospital();
            formHospital.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventanaOperaciones formOperaciones = new ventanaOperaciones();
            formOperaciones.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {  
            ventanaVisitasPost formVisitasPost = new ventanaVisitasPost();
            formVisitasPost.Show();
            this.Visible = false;

        }
    }
}
