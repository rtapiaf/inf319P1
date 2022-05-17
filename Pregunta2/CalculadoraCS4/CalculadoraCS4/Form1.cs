using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS4
{
    public partial class Form1 : Form
    {
        int valor;
        int primero;
        int segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
            valor = 0;
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
            pantalla.Text = valor.ToString();
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = valor;
            valor = 0;
            pantalla.Text = "+";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            segundo = valor;

            switch (operador)
            {
                case "+":
                    valor = Sumar(primero,segundo);
                    pantalla.Text = valor.ToString();
                    break;
                case "-":
                    valor = Restar(primero, segundo);
                    pantalla.Text = valor.ToString();
                    break;
                case "*":
                    valor = Multiplicar(primero, segundo);
                    pantalla.Text = valor.ToString();
                    break;
                case "/":
                    valor = Dividir(primero, segundo);
                    pantalla.Text = valor.ToString();
                    break;
            }
            
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = valor;
            valor = 0;
            pantalla.Text = "-";
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = valor;
            valor = 0;
            pantalla.Text = "*";
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = valor;
            valor = 0;
            pantalla.Text = "/";
        }

        private int Sumar(int N1, int N2)
        {
            return (N1 + N2);
        }

        private int Restar(int N1, int N2)
        {
            return (N1 - N2);
        }

        private int Multiplicar(int N1, int N2)
        {
            return (N1 * N2);
        }

        private int Dividir(int N1, int N2)
        {
            return (N1 / N2);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            valor = 0;
        }
    }
}
