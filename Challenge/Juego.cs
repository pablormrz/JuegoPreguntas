using System;
using Negocio;
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
    public partial class Juego : Form
    {
        JuegoPreguntas juego = null;
        int count;
        string Nombre;
        double AcumuladorPremio;
        List<Datos.Respuestas> opcionesRespuesta = null;
        public Juego()
        {
            InitializeComponent();
            
        }

        public Juego(string nombre)
        {
            juego = new JuegoPreguntas();
            count = 1;
            InitializeComponent();
            lbNombre.Text = nombre;
            MostrarPregunta();
            Nombre = nombre;
        }

        private void MostrarPregunta()
        {
            
            var Preguntas = juego.ObtenerPreguntas(count);
            lbCategoria.Text = Convert.ToString(Preguntas.NumCategoria);
            lbPregunta.Text = Preguntas.TextoPregunta;

            opcionesRespuesta = Preguntas.Respuestas.ToList();

            rb1.Text = opcionesRespuesta[0].TextoRespuesta;
            rb2.Text = opcionesRespuesta[1].TextoRespuesta;
            rb3.Text = opcionesRespuesta[2].TextoRespuesta;
            rb4.Text = opcionesRespuesta[3].TextoRespuesta;
            rb1.Checked = true;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (count < 5) 
            {
                bool respuestaCorrecta = false;
                
                if (rb1.Checked == true && opcionesRespuesta[0].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb2.Checked == true && opcionesRespuesta[1].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb3.Checked == true && opcionesRespuesta[2].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb4.Checked == true && opcionesRespuesta[3].Correcta)
                {
                    respuestaCorrecta = true;
                }
                if (respuestaCorrecta)
                {               
                    AcumuladorPremio += juego.ObtenerPremio(count).Puntos;
                    count = count + 1;
                    MostrarPregunta();
                }
                else
                {
                    Form Perder = new GameOver(AcumuladorPremio);
                    juego.GuardarHistorial(Nombre,count,AcumuladorPremio);
                    Perder.Show();
                    this.Hide();
                }


            }
            else if (count == 5)
            {
                bool respuestaCorrecta = false;
                if (rb1.Checked == true && opcionesRespuesta[0].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb2.Checked == true && opcionesRespuesta[1].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb3.Checked == true && opcionesRespuesta[2].Correcta)
                {
                    respuestaCorrecta = true;
                }
                else if (rb4.Checked == true && opcionesRespuesta[3].Correcta)
                {
                    respuestaCorrecta = true;
                }
                if (respuestaCorrecta)
                {
                    AcumuladorPremio += juego.ObtenerPremio(count).Puntos;
                    Form Ganar = new victoria(AcumuladorPremio);
                    juego.GuardarHistorial(Nombre, count, AcumuladorPremio);
                    Ganar.Show();
                    this.Hide();
                }
                else
                {
                    Form Perder = new GameOver(AcumuladorPremio);
                    juego.GuardarHistorial(Nombre, count, AcumuladorPremio);
                    Perder.Show();
                    this.Hide();
                }
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Form Perder = new GameOver(AcumuladorPremio);
            juego.GuardarHistorial(Nombre, count, AcumuladorPremio,true);
            Perder.Show();
            this.Hide();
        }
    }
}
