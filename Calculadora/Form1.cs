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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Num1()
        {
            return int.Parse(txtNumero1.Text);
        }
        private int Num2()
        {
            return int.Parse(txtNumero2.Text);
        }

        private string Soma(int n1,int n2)
        {
            return (n1 + n2).ToString();

        }
        private string Subtracao(int n1, int n2)
        {
            return (n1 - n2).ToString();

        }

        private string Calcula(int n1, Button botao, int n2)
        {
            if (botao.Text == "+")
            {
                return Soma(Num1(), Num2());

            }
            if (botao.Text == "-")
            {
                return Subtracao(Num1(), Num2());
            }

            if (botao.Text == "x")
            {
                return (Num1()* Num2()).ToString();
            }
            return null;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            txtResposta.Text = Calcula(Num1(), btn, Num2());

            lstResultados.Items.Add(txtResposta.Text);
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResposta.Text = Soma(Num1(), Num2());
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            txtResposta.Text = (Num1() - Num2()).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtResposta.Text = (Num1() * Num2()).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResposta.Text = (Num1() / Num2()).ToString();
        }

       
    }
}
