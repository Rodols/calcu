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
    public partial class Form1 : Form
    {
        double dato1;
        double dato2;
        double resultado;
        string operacion;
        String numerosP;
        int contNumeros = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            numerosP=pantalla.Text;
            contNumeros = numerosP.Length;
            if(contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Guardamos lo que hay en pantalla en la variable numerosP y con ayuda de la funcion
            Length contamos el numero de caracteres para poder limitar la cantidad de numeros 
            que podemos escribir en pantalla verificandolo con un if. */
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            numerosP = pantalla.Text;
            contNumeros = numerosP.Length;
            if (contNumeros < 10)
            {
                pantalla.Text = pantalla.Text + "9";
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            /*Guardamos el dato1 y asignamos un valor a la variable operacion
            que nos ayudara a indicar la operacion que realizaremos.*/
            operacion = "+";
            dato1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            /*Guardamos el dato1 y asignamos un valor a la variable operacion
            que nos ayudara a indicar la operacion que realizaremos.*/
            operacion = "-";
            dato1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            /*Guardamos el dato1 y asignamos un valor a la variable operacion
            que nos ayudara a indicar la operacion que realizaremos.*/
            operacion = "x";
            dato1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            /*Guardamos el dato1 y asignamos un valor a la variable operacion
            que nos ayudara a indicar la operacion que realizaremos.*/
            operacion = "/";
            dato1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            /*Al dar click en el boton igual guardamos en dato2 lo que tenemos en pantalla convertiendolo 
             a double con la funcion double.Parse(), y de acuerdo al valor de la variable operacion 
             con ayuda de un switch selecionamos la operacion que vamos a realizar.*/

            dato2 = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = dato1 + dato2;
                    pantalla.Text = resultado.ToString();
                   break;
                case "-":
                    resultado = dato1 - dato2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "x":
                    resultado = dato1 * dato2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = dato1 / dato2;
                    pantalla.Text = resultado.ToString();
                    break;
            }

           
        }

        private void punto_Click(object sender, EventArgs e)
        {
            /*Guardamos en la variable punto lo que hay en pantalla y buscamos si existe un punto 
            en caso de que no exista ninguno podemos agregar uno.*/
            String punto = pantalla.Text;
            int p;
            p = punto.IndexOf(".");
            if (p == -1)
            {
            pantalla.Text = pantalla.Text + ".";
            } 
        }
    }
}
