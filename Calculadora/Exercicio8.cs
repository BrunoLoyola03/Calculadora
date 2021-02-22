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
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }
        private int Reais()
        {
            return int.Parse(txtReais.Text);
        }
        private int Horas()
        {
            return int.Parse(txtHoras.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSalario.Text = (Reais() * Horas()).ToString();
        }
    }
}
