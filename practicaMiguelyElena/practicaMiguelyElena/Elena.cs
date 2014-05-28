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
            InitializeComponent();



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
                label2.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorFallos = 100;
            }
            actualizaFallos(contadorFallos);

        }
    }
}
