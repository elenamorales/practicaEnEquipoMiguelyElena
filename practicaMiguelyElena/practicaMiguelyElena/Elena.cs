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
    public partial class Elena : Form
    {
        String palabraOculta = "CETYS";
        String palabraConGuiones = "";
        int contadorFallos = 0;
        Random aleatorio = new Random();

        String[] listaPalabras = new String[] { "JORGE", "NO", "ESTA", "MAS", "CURRADO", "PORQUE", "SOY", "UN", "PAQUETE", 
                                                "QUE", "SE", "HA", "ORGANIZADO", "FATAL", "SORRY" };

        int numeroDePalabras = 0;
        
        private String sustiye(String palabra, int posicion, char letra)
        {
            palabra = palabra.Substring(0, posicion) + letra + palabra.Substring(posicion);
            return palabra;
        }



        public Elena()
        {
            {//El public Form1 es el construtor, no devuelve nada, se llama igual que la clase.
                InitializeComponent();

                //Inicializamos con la eleccion de la palabraOculta:

                palabraOculta = listaPalabras[aleatorio.Next(listaPalabras.Length)];

                //Para que me haga "_ _ _ _ _"hago un for
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    palabraConGuiones += "_ ";

                }
                label1.Text = palabraConGuiones;
            }

        }

        private void actualizaFallos(int _fallos)
        {
            switch (_fallos)
            {
                case 0: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_0; break;
                case 1: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_1; break;
                case 2: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_2; break;
                case 3: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_3; break;
                case 4: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_4; break;
                case 5: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_5; break;
                case 6: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.ahorcado_fin; break;
                case 100: pictureBox1.Image = global::practicaMiguelyElena.Properties.Resources.acertasteTodo; break;


            }


        }


        private void A_Click(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;   //casteamos el objeto buton a sender 

            botonPulsado.Enabled = false; // cuadno pulsamos botonPulsado lo desabilitamos
            String letra = botonPulsado.Text;
            if (!palabraOculta.Contains(letra))
            {
                contadorFallos++;
            }
            else
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i].Equals(botonPulsado.Text[0]))
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2 * i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                    }

                }
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);

        }
    }
}
