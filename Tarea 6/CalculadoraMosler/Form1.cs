using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMosler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // 1. Recolectamos los datos de tus 4 tBox
            ProyectoRiesgo miRiesgo = new ProyectoRiesgo();
            miRiesgo.NombreProyecto = tBox1.Text;
            miRiesgo.Evaluador = tBox2.Text;
            miRiesgo.BienAProteger = tBox3.Text;
            miRiesgo.Amenaza = tBox4.Text;

            // 2. Creamos la segunda ventana pasando los datos
            Form2 ventana2 = new Form2(miRiesgo);

            // 3. Mostramos el Form2 y ocultamos el Form1
            ventana2.Show();
            this.Hide();
        }
    }
}
