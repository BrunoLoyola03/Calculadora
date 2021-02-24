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
    public partial class Exercicio13 : Form
    {
        public Exercicio13()
        {
            InitializeComponent();
        }
        private decimal Altura()
        {
            return decimal.Parse(txtAltura.Text);
        }

        private void btnHomem_Click(object sender, EventArgs e)
        {
            txtPeso.Text = ((72.7 * (double)Altura()) - 58).ToString();
        }

        private void btnMulher_Click(object sender, EventArgs e)
        {
            txtPeso.Text = ((62.1 * (double)Altura()) - 44.7).ToString();
        }
    }
}
