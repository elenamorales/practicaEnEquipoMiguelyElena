using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace practicaMiguelyElena
{
    public partial class Miguel : Form
    {

        double operando1 = 0;
        String operador = "";

        
        public Miguel()
        {
            InitializeComponent();
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "9";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "9";
            }
            else
            {
                pantalla.Text += "9";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "8";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "8";
            }
            else
            {
                pantalla.Text += "8";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "7";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "7";
            }
            else
            {
                pantalla.Text += "7";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "6";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "6";
            }
            else
            {
                pantalla.Text += "6";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "5";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "5";
            }
            else
            {
                pantalla.Text += "5";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "4";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "4";
            }
            else
            {
                pantalla.Text += "4";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "3";
            }
            if (pantalla.Text == "0")
            {
                pantalla.Text = "3";
            }
            else
            {
                pantalla.Text += "3";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "2";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "2";
            }
            else
            {
                pantalla.Text += "2";
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "1";
            }

            if (pantalla.Text == "0")
            {
                pantalla.Text = "1";
            }
            else
            {
                pantalla.Text += "1";
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            if (pantalla2.Text != "")
            {
                pantalla2.Text = pantalla2.Text + "0";
            }
            if (pantalla.Text == "0")
            {
                pantalla.Text = "0";
            }
            else
            {
                pantalla.Text += "0";
            }
        }

        private void botonac_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            pantalla2.Text = "";
        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            operando1 = double.Parse(pantalla.Text);
            operador = "+";
            pantalla2.Text = pantalla.Text+"+";
            pantalla.Text = "0";
            
        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            operando1 = double.Parse(pantalla.Text);
            operador = "-";
            pantalla2.Text = pantalla.Text + "-";
            pantalla.Text = "0";
        }

        private void botondivide_Click(object sender, EventArgs e)
        {
            operando1 = double.Parse(pantalla.Text);
            operador = "/";
            pantalla2.Text = pantalla.Text + "/";
            pantalla.Text = "0";
        }

        private void botonmultiplica_Click(object sender, EventArgs e)
        {
            operando1 = double.Parse(pantalla.Text);
            operador = "x";
            pantalla2.Text = pantalla.Text + "x";
            pantalla.Text = "0";
        }

        private void botonigual_Click(object sender, EventArgs e)
        {
            double operando2 = Double.Parse(pantalla.Text);
            if (operador == "+")
            {
                operando1 = operando1 + operando2;
            }
            else if (operador == "-")
            {

                operando1 = operando1 - operando2;


            }
            else if (operador == "x")
            {
                operando1 = operando1 * operando2;
            }

            //if (operando2 != 0)
            //{
            //    operando1 = operando1 / operando2;

            //    pantalla.Text = "E";
            //}
            else if (operador == "/")
            {

                operando1 = operando1 / operando2;
            }

            else if (operador == "sqr")
            {

                operando1 = System.Math.Sqrt(operando2);
            }
            else if (operador == "elev")
            {

                operando1 = System.Math.Pow(operando1,operando2);
            }
            else if (operador == "mod")
            {

                operando1 = ;
            }

            pantalla.Text = Convert.ToString(operando1);
            pantalla2.Text = "";

        }

        private void botonraiz_Click(object sender, EventArgs e)
        {
            operador = "sqr";
            pantalla2.Text =  "Raiz de: ";
            pantalla.Text = "0";
        }

        private void botonpotencia_Click(object sender, EventArgs e)
        {
            operando1 = double.Parse(pantalla.Text);
            operador = "elev";
            pantalla2.Text = pantalla.Text + " elev a ";
            pantalla.Text = "0";
        }

        private void botonmod_Click(object sender, EventArgs e)
        {
            operador = "mod";
            pantalla2.Text = "MOD de: ";
            pantalla.Text = "0";
        }
    }
}
