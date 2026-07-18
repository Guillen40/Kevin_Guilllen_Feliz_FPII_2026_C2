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
    public partial class Form3 : Form
    {
        private ProyectoRiesgo _datos;

        public Form3(ProyectoRiesgo datosRecibidos)
        {
            InitializeComponent();
            _datos = datosRecibidos;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form2"].Show();
        }

        private void bntSiguiente_Click(object sender, EventArgs e)
        {
            Form4 ventana4 = new Form4(_datos);
            ventana4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblNombre.Text = _datos.NombreProyecto;
            lblEvaluador.Text = _datos.Evaluador;
            lblBienProteger.Text = _datos.BienAProteger;
            lblAmenaza.Text = _datos.Amenaza;

            int importanciaDano = _datos.Funcion * _datos.Sustitucion;
            int danoProducido = _datos.Profundidad * _datos.Extencion;
            int caracterRiesgo = importanciaDano + danoProducido;
            int probabilidad = _datos.Agresion * _datos.Vulnerabilidad;

            int riesgoEstimado = caracterRiesgo * probabilidad;

            lblResultadoER.Text = riesgoEstimado.ToString();

            if (riesgoEstimado <= 250)
            {
                lblNivel.Text = "Nivel: Muy Bajo";
                lblNivel.ForeColor = System.Drawing.Color.Green;
            }
            else if (riesgoEstimado <= 500)
            {
                lblNivel.Text = "Nivel: Bajo";
                lblNivel.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else if (riesgoEstimado <= 750)
            {
                lblNivel.Text = "Nivel: Medio";
                lblNivel.ForeColor = System.Drawing.Color.Orange;
            }
            else if (riesgoEstimado <= 1000)
            {
                lblNivel.Text = "Nivel: Elevado";
                lblNivel.ForeColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                lblNivel.Text = "Nivel: Crítico";
                lblNivel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}