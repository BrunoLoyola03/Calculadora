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
    public partial class Exercicio14 : Form
    {
        public Exercicio14()
        {
            InitializeComponent();
        }
        private int Peso()
        {
            return int.Parse(txtPeso.Text);
        }
        private int Excesso()
        {
            if (Peso() > 50)
            {
                return Peso() - 50;
            }
            else
            {
                return Peso() * 0;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtMulta.Text = (Excesso() * 4).ToString();
        }
    }
}
