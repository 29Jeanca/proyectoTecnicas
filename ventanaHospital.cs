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
    public partial class ventanaHospital : Form
    {
        public ventanaHospital()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crearHospital_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital();
            hospital.valorFiscal = txtValorFiscal.Text;
            hospital.areaTerreno = txtAreaTerreno.Text;
            hospital.direcExacta = txtDirecExacta.Text;
            hospital.provincia = comboPronvincia.Text;
            hospital.canton = comboCanton.Text;
            hospital.distrito = comboDistrito.Text;
            hospital.cantNiveles = txtCantNiveles.Text;
            hospital.color = txtColor.Text;
            hospital.cantConsultorios = txtCantConsultorios.Text;
            hospital.tiposdCirugia = txtTiposdCirugia.Text;
            hospital.anoConstruccion = txtFecha.Text;
            hospital.imagen = txtImagen.Text;
            int resultado = agregarHospital.insertarHospital(hospital);

            if (resultado > 0)
            {
                MessageBox.Show("Hospital almacenado en la base de datos");
                txtValorFiscal.Text = "";
                txtAreaTerreno.Text = "";
                txtDirecExacta.Text = "";
                comboPronvincia.Text = "";
                comboCanton.Text = "";
                comboDistrito.Text = "";
                txtCantNiveles.Text = "";
                txtColor.Text = "";
                txtCantConsultorios.Text = "";
                txtTiposdCirugia.Text = "";
                txtFecha.Text = "";
                txtImagen.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void crearHospital_MouseHover(object sender, EventArgs e)
        {
            this.crearHospital.BackColor = Color.FromArgb(46, 80, 135);
        }

        private void crearHospital_MouseLeave(object sender, EventArgs e)
        {
            this.crearHospital.BackColor = Color.FromArgb(255, 255, 255); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValorFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            e.Handled = true;
            return;
        }

        private void txtAreaTerreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            e.Handled = true;
            return;
        }

        private void txtCantNiveles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            e.Handled = true;
            return;
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantConsultorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTiposdCirugia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
