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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }
        private decimal Celsius()
        {
            return decimal.Parse(txtCelsius.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Text = ((Celsius() / 5 * 9) + 32).ToString();
        }
    }
}
