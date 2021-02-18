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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }
        private int Num1()
        {
            return int.Parse(txtNum1.Text);
        }
        private int Num2()
        {
           return int.Parse(txtNum2.Text);
        }
        private void txtResposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResposta.Text = (Num1() + Num2()).ToString();
        }
    }
}
