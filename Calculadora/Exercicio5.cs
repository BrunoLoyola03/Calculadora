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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }
        private decimal Metro()
        {
            return decimal.Parse(txtMetro.Text); 
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtCentimetro.Text = (Metro() * 100).ToString();
        }
    }
}
