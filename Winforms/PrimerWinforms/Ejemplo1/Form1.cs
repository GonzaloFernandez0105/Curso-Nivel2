using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvElementos.Items.Add(elem);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbGenero_Enter(object sender, EventArgs e)
        {

        }

        private void chbEjemplo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTimePicker1.Value;
            string monotributista = chbEjemplo.Enabled == true ? "Es Monotributista" : "No es Monotributista";
            string genero = "Null";
            if (rdbHombre.Checked)
                genero = "Hombre";
            else if (rdbMujer.Checked)
                genero = "Mujer";
            else if (rdbNull.Checked)
                genero = "Genero indefinido";
            string estudios = cbEstudios.SelectedItem.ToString();
            string añosExp = numExp.Value.ToString();

            MessageBox.Show($" Nombre: {nombre} {Environment.NewLine} Fecha: {fecha} {Environment.NewLine} Monotributista: {monotributista} {Environment.NewLine} Genero: {genero} {Environment.NewLine} Estudios: {estudios} {Environment.NewLine} Experiencia: {añosExp} Años");

        }
    }
}
