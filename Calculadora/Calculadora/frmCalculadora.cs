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
    public partial class frmCalculadora : Form
    {

        Calculos misCalculo = new Calculos();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("0");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar(".");
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            misCalculo.suma(textDispley.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            textDispley.Text = "" + misCalculo.resultado(textDispley.Text);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            misCalculo.resta(textDispley.Text);
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            misCalculo.multiplicacion(textDispley.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            misCalculo.multiplicacion(textDispley.Text);
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            textDispley.Text = misCalculo.concatenar("000");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            misCalculo.clear();
            textDispley.Text = "0";
        }


        

    }
}
