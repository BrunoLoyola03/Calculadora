﻿using System;
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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Exercicio2_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNum.Text);
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
         
        }
    }
}
