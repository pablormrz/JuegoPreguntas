using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge
{
    public partial class AdministrarPregunta : Form
    {
        AdministracionJuego administracion = null;
        public AdministrarPregunta()
        {
            InitializeComponent();
            administracion = new AdministracionJuego();

            //Llenar categorias
            var categorias = administracion.ObtenerCategorias();
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "NumeroCategoria";

            for (int i = 0; i < 4; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                gvOpcionesRespuesta.Rows.Add(fila);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;

            //Recorrer grid y llenar una lista

            List<OpcionRespueta> opcionesRespuesta = new List<OpcionRespueta>();

            for (int i = 0; i < gvOpcionesRespuesta.RowCount; i++)
            {
                if (gvOpcionesRespuesta.Rows[i].Cells["OpcionRespuesta"].Value == null)
                {
                    gvOpcionesRespuesta.Rows[i].Cells["OpcionRespuesta"].Style.BackColor = Color.OrangeRed;
                    MessageBox.Show("Ingrese por favor todos y solo los datos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    gvOpcionesRespuesta.Rows[i].Cells["OpcionRespuesta"].Style.BackColor = Color.White;
                }
            }

            int a = 0;
            for (int i = 0; i < gvOpcionesRespuesta.RowCount; i++)
            {
                if (gvOpcionesRespuesta.Rows[i].Cells["OpcionCorrecta"].Value != null && (bool)gvOpcionesRespuesta.Rows[i].Cells["OpcionCorrecta"].Value == true)
                {
                    a += 1;
                }
            }

            if (a == 0)
            {
                MessageBox.Show("No se ingresó una respuesta correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (a != 1)
            {
                MessageBox.Show("Solo puedes ingresar una respuesta correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtPregunta.Text))
            {
                MessageBox.Show("Ingrese por favor todos y solo los datos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow fila in gvOpcionesRespuesta.Rows)
                {
                    if (fila.Cells["OpcionRespuesta"].Value != null)
                    {
                        var opcionRespuesta = new OpcionRespueta
                        {
                            TextoRespuesta = fila.Cells["OpcionRespuesta"].Value.ToString(),
                            EsCorrecta = fila.Cells["OpcionCorrecta"].Value == null ? false : (bool)fila.Cells["OpcionCorrecta"].Value,
                        };
                        opcionesRespuesta.Add(opcionRespuesta);
                    }
                };

                Pregunta nuevaPregunta = new Pregunta
                {
                    TextoPreguntaa = txtPregunta.Text,
                    NumCategoria = categoriaSeleccionada.NumeroCategoria,
                    OpcionRespueta = opcionesRespuesta
                };

                administracion.GuardarPreguntas(nuevaPregunta);
                MessageBox.Show("Guardado Exitoso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form Guardar = new AdministrarPregunta();
                Guardar.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
