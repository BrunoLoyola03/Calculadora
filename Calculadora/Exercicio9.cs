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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }
        private decimal Fahrenheit()
        {
            return decimal.Parse(txtFahrenheit.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = (5 * ((Fahrenheit() - 32) / 9)).ToString();
        }
    }
}
