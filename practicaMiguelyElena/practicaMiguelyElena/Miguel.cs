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
        }
    }
}
