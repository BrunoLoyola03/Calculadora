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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }
        private int Num1()
        {
            return int.Parse(txtNota1.Text);
        }
        private int Num2()
        {
            return int.Parse(txtNota2.Text);
        }
        private int Num3()
        {
            return int.Parse(txtNota3.Text);
        }
        private int Num4()
        {
            return int.Parse(txtNota4.Text);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtMedia.Text = (((Num1() + Num2() + Num3() + Num4())/4).ToString());
        }
    }
}
