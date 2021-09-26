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
    public partial class victoria : Form
    {
        public victoria()
        {
            InitializeComponent();
        }

        public victoria(double Premio)
        {
            InitializeComponent();
            lbPuntos.Text = Convert.ToString(Premio);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form cerrar = new Inicio();
            cerrar.Show();
            this.Hide();
        }
    }
}
