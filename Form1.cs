using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoForm
{
    public partial class Form1 : Form
    {
        double media;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1 = double.Parse(txtNota1.Text);
            double Nota2 = double.Parse(txtNota2.Text);
            double Nota3 = double.Parse(txtNota3.Text);

             media = (Nota1 + Nota2 + Nota3) / 3;

            lblMedia.Text = media.ToString("F3");
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            if ( media >= 6) 
            {
                lblSituacao.Text = "APROVADO";
                lblSituacao.ForeColor = Color.Blue;

            }
            else
            {
                lblSituacao.Text = "REPROVADO";
                lblSituacao.ForeColor = Color.Red;

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            lblMedia.Text = "0";
            lblSituacao.Text = "";
            txtNota1.Focus();
            media = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
