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
    public partial class Exercicio16 : Form
    {
        public Exercicio16()
        {
            InitializeComponent();
        }
        private decimal Metros()
        {
            return decimal.Parse(txtMetros.Text);
        }
        private int QntdLatas()
        {
            return int.Parse(txtQntdLatas.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtQntdLatas.Text = Math.Ceiling(Metros() / 54).ToString();
            txtPreço.Text = (QntdLatas() * 80).ToString();
        }
    }
}
