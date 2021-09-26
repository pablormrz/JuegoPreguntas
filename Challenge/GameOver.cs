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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(double Premio)
        {
            InitializeComponent();
            lbPuntos.Text = Convert.ToString(Premio);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form salir = new Inicio();
            salir.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
