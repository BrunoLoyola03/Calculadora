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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }
        private int Lado()
        {
            return int.Parse(txtLado.Text);
        }
        private int Area()
        {
            return int.Parse(txtArea.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtArea.Text = (Lado() * Lado()).ToString();
            txtArea2.Text = (Area() * 2).ToString();
        }
    }
}
