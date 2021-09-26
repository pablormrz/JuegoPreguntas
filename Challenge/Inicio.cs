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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form inicio = new IngresoNombre();
            inicio.Show();
            this.Hide();
        }

        private void btnCofiguracion_Click(object sender, EventArgs e)
        {
            Form Configuracion = new AdministrarPregunta();
            Configuracion.Show();
            this.Hide();
        }
    }
}
