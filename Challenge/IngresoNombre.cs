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
    public partial class IngresoNombre : Form
    {
        
        public IngresoNombre()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string Nombre;
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese por favor un Nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                Nombre = txtNombre.Text;
                Form Continuar = new Juego(Nombre);
                Continuar.Show();
                this.Hide();
            }
        }
    }
}
