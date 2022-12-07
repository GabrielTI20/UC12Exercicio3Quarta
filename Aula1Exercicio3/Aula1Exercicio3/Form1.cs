using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            mensagem1.Text = "Escola";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            mensagem2.Text = "Mercado";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botao3_Click(object sender, EventArgs e)
        {
            mensagem3.Text = "Prefeitura";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
