using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ClosedXML.Excel;
using System.IO;

namespace CalculadoraMosler
{
    public partial class Form4 : Form
    {
        private ProyectoRiesgo _datos;

        public Form4(ProyectoRiesgo datosRecibidos)
        {
            InitializeComponent();
            _datos = datosRecibidos;
        }

        // Método auxiliar para leer de la base de datos y refrescar la tabla
        private void CargarHistorial()
        {
            try
            {
                using (var db = new LiteDatabase(@"RiesgosDB.db"))
                {
                    var coleccion = db.GetCollection<ProyectoRiesgo>("proyectos");

                    // Desenlazamos y volvemos a enlazar los datos frescos
                    dgvHistorial.DataSource = null;
                    dgvHistorial.DataSource = coleccion.FindAll().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el historial: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form3"].Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Cuando la pantalla se abre, carga inmediatamente los registros anteriores
            CargarHistorial();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Calculamos los valores finales para guardarlos dentro del objeto
                int importanciaDano = _datos.Funcion * _datos.Sustitucion;
                int danoProducido = _datos.Profundidad * _datos.Extencion;
                int caracterRiesgo = importanciaDano + danoProducido;
                int probabilidad = _datos.Agresion * _datos.Vulnerabilidad;

                // Guardamos el ER final
                _datos.ResultadoER = caracterRiesgo * probabilidad;

                // Guardamos el Nivel de riesgo en texto
                if (_datos.ResultadoER <= 250) _datos.NivelRiesgo = "Muy Bajo";
                else if (_datos.ResultadoER <= 500) _datos.NivelRiesgo = "Bajo";
                else if (_datos.ResultadoER <= 750) _datos.NivelRiesgo = "Medio";
                else if (_datos.ResultadoER <= 1000) _datos.NivelRiesgo = "Elevado";
                else _datos.NivelRiesgo = "Crítico";

                // 2. Insertamos el objeto en la base de datos LiteDB
                using (var db = new LiteDatabase(@"RiesgosDB.db"))
                {
                    var coleccion = db.GetCollection<ProyectoRiesgo>("proyectos");
                    coleccion.Insert(_datos);
                }

                MessageBox.Show("Proyecto guardado exitosamente en el historial.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Actualizamos la tabla para que se vea reflejado el cambio
                CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la tabla para exportar a Excel.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Historial de Riesgos");

                    // 1. Generamos los encabezados de las columnas
                    for (int col = 0; col < dgvHistorial.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dgvHistorial.Columns[col].HeaderText;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                        worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                    }

                    // 2. Transferimos los datos fila por fila
                    for (int fila = 0; fila < dgvHistorial.Rows.Count; fila++)
                    {
                        for (int col = 0; col < dgvHistorial.Columns.Count; col++)
                        {
                            var valor = dgvHistorial.Rows[fila].Cells[col].Value;
                            worksheet.Cell(fila + 2, col + 1).Value = valor != null ? valor.ToString() : "";
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    // 3. Cuadro para guardar el archivo final
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                        FileName = "Historial_Mosler.xlsx"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("¡Reporte de Excel generado correctamente!", "Exportación Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}