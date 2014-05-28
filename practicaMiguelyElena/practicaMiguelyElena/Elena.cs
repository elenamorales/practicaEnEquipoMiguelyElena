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
        
            {
String palabraOculta = "CETYS";
        String palabraConGuiones = "";

        int contadorDeFallos = 0;

        //Declaramos un Array para guardar la lista de palabras: En c# se pone primero el tipo, corchetes y nombre
        String[] listaPalabras = new String[]{ "CETYS", "HOLA", "HODOR", "LANNISTER", "BARATHEON", "STARBUCKS"};
        //Se inicializa asi, new + tipo + corchetes para indicar que es un array + entre llaves los strings del array.

        //Vamos a hacer un hashmap para coger las palabras de palabraOculta del lemario
        Hashtable lemario = new Hashtable();
        int numeroDePalabras = 0;

        private String sustituye(String palabra, int posicion, char letra)
        {
            palabra = palabra.Substring(0, posicion) + letra + palabra.Substring(posicion+1);

            return palabra;
        }
        
        
        private String quitaAcentos(String _palabrasConAcentos)
        {
            //Hacemos un for para que recorra la palabra
            for (int i = 0; i < _palabrasConAcentos.Length-1; i++)
            {
                switch (_palabrasConAcentos[i])
                {
                        //Los Strings te lo declara como constantes, asi que no te deja cambiarlo
                    case 'Á': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'A'); break;
                    case 'É': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'E'); break;
                    case 'Í': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'I'); break;
                    case 'Ó': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'O'); break;
                    case 'Ú': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'U'); break;
                    case 'Ü': _palabrasConAcentos=sustituye(_palabrasConAcentos, i, 'U'); break;

                }
            }
            return _palabrasConAcentos;
        }

        //Inicializamos la lectura del ficheroLemario:
        private void leeFicheroLemario() //Vamos a leer un fichero
        {
            try
            {
                //Un StreamReader te lee un archivo:
                StreamReader fichero = new StreamReader("../../lemario.txt");
                //StreamReader te apunta al fichero que hay que leer hasta que ya no haya mas que leer
                String linea;//No le asignamos un valor aqui porque ahora en el while le vamos a asignar un valor. 

                while ((linea = fichero.ReadLine()) != null)// en linea = fichero... no pregunta si es == sino que le asigna un valor.
                {//Se pone asi porque puede darse que haya un fichero vacio, por lo que es importante leer linea por linea y ver que no sea null. Y cuando lo sea, se acaba. 
                    lemario.Add(linea, numeroDePalabras);
                    numeroDePalabras++;
                }
            //Hay que cerrar el fichero del que se ha leido:
                fichero.Close();

                String palabraElegida = "";
                int numeroElegido = aleatorio.Next(lemario.Count);

                palabraOculta = lemario[numeroElegido].ToString();//Coge la palabraElegida del lemario con el numero random
                palabraOculta = palabraOculta.ToUpper();//Lo pone mayucula
                palabraOculta = quitaAcentos(palabraOculta);//Llama a quitaAcentos por su lo tuviera y lo guarda en palabraOculta
            }
            catch (Exception e) {
                Console.WriteLine("No se ha podido leer el archivo");
                Console.WriteLine(e.Message);
            }
       }


        Random aleatorio = new Random();

        //El public Elena es el construtor, no devuelve nada, se llama igual que la clase.

            InitializeComponent();
         public Elena()
        
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El public Elena es el construtor, no devuelve nada, se llama igual que la clase.
            InitializeComponent();
            
            //Inicializamos con la eleccion de la palabraOculta:

            palabraOculta = listaPalabras[aleatorio.Next(listaPalabras.Length)];

            //Para que me haga "_ _ _ _ _"hago un for
            for (int i=0; i<palabraOculta.Length;i++){
                palabraConGuiones += "_ ";

                }
            label1.Text = palabraConGuiones;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actualizaFallos(int _fallos)
        {
            switch (_fallos)
            {
                case 0: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_0; break;
                case 1: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_1; break;
                case 2: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_2; break;
                case 3: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_3; break;
                case 4: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_4; break;
                case 5: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_5; break;
                case 6: pictureBox1.Image = global::ahorcado.Properties.Resources.ahorcado_fin; break;
                case 100: pictureBox1.Image = global::ahorcado.Properties.Resources.acertasteTodo; break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        //Object es generico, puede ser un button, un label,.... Sender, como he llamado a la variable, es solo un puntero hacia el boton que ha disparado el evento. 
        //En sender se almacena la direccion. 
        {
            //Tenemos que castear el button1 para poder funcionar como un boton, no como un object generico:
            Button botonPulsado = (Button)sender;//Pulsas un boton
            botonPulsado.Enabled = false;//Lo ocultas
            String letra = botonPulsado.Text;
            //Ahora busco esa letra en la cadena de palabraOculta:
            if (!palabraOculta.Contains(botonPulsado.Text)){
                contadorDeFallos++;
            }
            else {
                for (int i = 0; i < palabraOculta.Length; i++) {
                    if (palabraOculta[i].Equals(letra[0]))
                    {
                        palabraConGuiones = palabraConGuiones.Substring(0, 2*i) + letra[0] + " " + palabraConGuiones.Substring(2 * i + 2);
                       
                    }
                }
                label1.Text = palabraConGuiones;
            }
            if (!palabraConGuiones.Contains("_"))
            {
                contadorDeFallos = 100;
            }
            actualizaFallos(contadorDeFallos);
        }
    }