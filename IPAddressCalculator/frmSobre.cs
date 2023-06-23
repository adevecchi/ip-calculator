using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPAdressCalculator
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {
            label1.Text = "Projeto proposto pelo prof. Eder\n" +
                          "da disciplina de Redes de Computadores\n" +
                          "para implementar uma Calculadora IP.\n\n" +
                          "por ©Andre Devecchi\n" +
                          "cursando 1º semestre de Ciência da Computação\n" +
                          "em 01/12/2011";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
