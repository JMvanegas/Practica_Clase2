using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace ClaseProgra2
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        Restas ingresoR;
        Multiplicacion ingresoM;
        Division ingresoD;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValorA.Text);
            ingreso.V2 = double.Parse(txtValorB.Text);
            lblResul.Text = ingreso.Calcular().ToString();
        }

        private void lblResul_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ingresoR = new Restas();
            ingresoR.R1 = double.Parse(txtValorA.Text);
            ingresoR.R2 = double.Parse(txtValorB.Text);
            lblResul.Text = ingresoR.CalcularR().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingresoM = new Multiplicacion();
            ingresoM.M1 = double.Parse(txtValorA.Text);
            ingresoM.M2 = double.Parse(txtValorB.Text);
            lblResul.Text = ingresoM.CalcularM().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresoD = new Division();
            ingresoD.D1 = double.Parse(txtValorA.Text);
            ingresoD.D2 = double.Parse(txtValorB.Text);
            lblResul.Text = ingresoD.CalcularD().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
