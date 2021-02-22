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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }
        private decimal N1()
        {
            return decimal.Parse(txtN1.Text);
        }
        private decimal N2()
        {
            return decimal.Parse(txtN2.Text);
        }
        private decimal N3()
        {
            return decimal.Parse(txtN3.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtA.Text = (N1() * 2 + N2() / 2).ToString();
            txtB.Text = (N1() * 3 + N3()).ToString();
            txtC.Text = Math.Pow((double) N3(), 3).ToString();
        }
    }
}
