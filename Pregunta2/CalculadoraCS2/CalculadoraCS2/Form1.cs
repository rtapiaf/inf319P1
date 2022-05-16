using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS2
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        public double Sumar(double N1, double N2)
        {
            double S;
            S = N1 + N2;
            return S;
        }

        public double Restar(double N1, double N2)
        {
            double R;
            R = N1 - N2;
            return R;
        }

        public double Multiplicar(double N1, double N2)
        {
            double M;
            M = N1 * N2;
            return M;
        }

        public double Dividir(double N1, double N2)
        {
            double D;
            D = N1 / N2;
            return D;
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = Sumar((primero), (segundo));
                    pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = Restar((primero), (segundo));
                    pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = Multiplicar((primero), (segundo));
                    pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = Dividir((primero), (segundo));
                    pantalla.Text = Div.ToString();
                    break;
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }
    }
}
