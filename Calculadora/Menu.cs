using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            new Exercicio1().Show();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            new Exercicio2().Show();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            new Exercicio3().Show();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            new Exercicio4().Show();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            new Exercicio5().Show();
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            new Exercicio6().Show();
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            new Exercicio7().Show();
        }

        private void btnExercicio8_Click(object sender, EventArgs e)
        {
            //new Exercicio8().Show();
        }

        private void btnExercicio9_Click(object sender, EventArgs e)
        {
            //new Exercicio9().Show();
        }

        private void btnExercicio10_Click(object sender, EventArgs e)
        {
            //new Exercicio10().Show();
        }
    }
}
