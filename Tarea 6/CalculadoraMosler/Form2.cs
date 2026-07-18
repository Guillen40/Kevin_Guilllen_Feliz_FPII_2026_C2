using System;
using System.Windows.Forms;

namespace CalculadoraMosler
{
    public partial class Form2 : Form
    {
        private ProyectoRiesgo _datos;

        public Form2(ProyectoRiesgo datosRecibidos)
        {
            InitializeComponent();

            _datos = datosRecibidos;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.OpenForms["Form1"].Show();
        }

        private void bntSiguiente_Click_1(object sender, EventArgs e)
        {
            _datos.Funcion = Convert.ToInt32(cboFuncion.SelectedItem ?? 1);
            _datos.Sustitucion = Convert.ToInt32(cboSustitucion.SelectedItem ?? 1);
            _datos.Profundidad = Convert.ToInt32(cboProfundidad.SelectedItem ?? 1);
            _datos.Extencion = Convert.ToInt32(cboExtension.SelectedItem ?? 1);
            _datos.Agresion = Convert.ToInt32(cboAgresion.SelectedItem ?? 1);
            _datos.Vulnerabilidad = Convert.ToInt32(cboVulnerabilidad.SelectedItem ?? 1);

            Form3 ventana3 = new Form3(_datos);
            ventana3.Show();
            this.Hide();
        }
    }
}