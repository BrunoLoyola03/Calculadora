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
    public partial class Exercicio15 : Form
    {
        public Exercicio15()
        {
            InitializeComponent();
        }
        private int Reaisporhora()
        {
            return int.Parse(txtReaisporHora.Text);
        }
        private int Horas()
        {
            return int.Parse(txtHoras.Text);
        }
        private int SalarioBruto()
        {
            return int.Parse(txtSalarioBruto.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSalarioBruto.Text = (Reaisporhora() * Horas()).ToString();
            txtIR.Text = (SalarioBruto() * 0.11).ToString();
            txtINSS.Text = (SalarioBruto() * 0.08).ToString();
            txtSindicato.Text = (SalarioBruto() * 0.05).ToString();
            txtSalarioLiquido.Text = (SalarioBruto() * 0.76).ToString();
        }
    }
}
