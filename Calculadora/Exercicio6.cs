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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }
        private int Raio()
        {
            return int.Parse(txtRaio.Text);
        }
                private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtArea.Text = (Math.PI*(Raio()^2)).ToString();
        }
    } 
}
