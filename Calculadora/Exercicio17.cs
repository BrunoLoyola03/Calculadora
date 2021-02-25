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
    public partial class Exercicio17 : Form
    {
        public Exercicio17()
        {
            InitializeComponent();
        }
        private decimal Metros()
        {
            return decimal.Parse(txtMetros.Text);
        }
        private decimal Latas()
        {
            return decimal.Parse(txtLatas.Text);
        }
        private decimal Galoes()
        {
            return decimal.Parse(txtGaloes.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtLatas.Text = Math.Ceiling(Metros() / 108).ToString();
            txtPreço.Text= (Latas() * 80).ToString();
        }

        private void btnGaloes_Click(object sender, EventArgs e)
        {
            txtGaloes.Text = Math.Ceiling(Metros() / (decimal)21.6).ToString();
            txtPreço.Text = (Galoes() * 25).ToString();
        }

        private void btnLatasGaloes_Click(object sender, EventArgs e)
        {
            txtLatas.Text= Math.Ceiling(Metros() / 108).ToString();
            txtGaloes.Text = Math.Ceiling((Metros()-Latas()) / (decimal)21.6).ToString();
            txtPreço.Text = ((Latas() * 80)+ (Galoes() * 25)).ToString();
        }
    }
}
