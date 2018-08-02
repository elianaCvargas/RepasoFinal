using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using System.IO;

namespace _20180726___Final
{
    // Reutilizar tanto código como sea posible.
    // Primer Parcial: Agregar un atributo del tipo Muebleria e instanciarlo en el constructor.
    // Segundo Parcial y Final
    //   - Agregar un atributo del tipo Lista de Asiento e instanciarlo en el constructor.
    //   - Controlar excepciones en archivos.
    //   - Para el manejo de archivos agregar una interfaz genérica con los métodos V Guardar(string path, T elemento) y T Leer(string path)
    //   - Generar dos clases: ArchivoTexto y ArchivoXML que implementen dicha interfaz. Completar los métodos según corresponda.
    //   - Probar todos los asientos mediante un Thread. Crear un evento FinPruebaCalidad() en Asiento para que informe si la prueba pasó (true) o no (false) y mostrar el resultado por pantalla.
    public partial class FrmPpal : Form
    {
        public List<Asiento> lista;
        public Thread hilo;
        public Asiento asiento;
        public ArchivoXML archivoXML = new ArchivoXML();
        public ArchivoTexto archivoTXT= new ArchivoTexto();
        

        public FrmPpal()
        {
            InitializeComponent();

            this.lista = new List<Asiento>();
        }

        /// <summary>
        /// Primer Parcial: Agregar el elemento a la mueblería.
        /// Segundo Parcial y Final: Al presionar el botón agregar se deberá guardar la información a un archivo, anexando el nuevo Asiento al final. Agregar el elemento a la lista.
        /// Luego, leer el archivo y mostrarlo en el RichTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            short alto = short.Parse(this.nudAlto.Value.ToString());
            short ancho = short.Parse(this.nudAncho.Value.ToString());
            short profundidad = short.Parse(this.nudProfundidad.Value.ToString());
            Random random = new Random();
            int numero = random.Next(0, 4);
            ColorSofa enumerado = (ColorSofa)numero;

            //if (this.asiento is Sofa)
            //{
                this.asiento = new Sofa(alto, ancho, profundidad, enumerado);

                //archivoXML.Guardar("Sofa.txt", asiento);
                try
                {
                    archivoTXT.Guardar("Sofa.txt", asiento.ToString());
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
                 
                
                
            //}
            this.lista.Add(asiento);
            //archivoXML.Leer("Sofa.txt)";
            string lectura = archivoTXT.Leer("Sofa.txt");
            this.rtbMensaje.Text = lectura;

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lectura = archivoTXT.Leer("Sofa.txt");
            this.rtbMensaje.Text = lectura;
        }

        /// <summary>
        /// Antes de cerrar, serializar la lista en XML. Hacer las modificaciones necesarias para guardar todos los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hilo != null)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }          
            foreach (Asiento item in lista)
	        {
                archivoXML.Guardar("Sofa.xml", item);
	        }
            
            
        }

        

        private void btnProbar_Click(object sender, EventArgs e)
        {
            hilo = new Thread(BancoDePrueba);
            hilo.Start();
            foreach (Asiento item in lista)
            {
                 item.FinPruebaCalidad += Manejador;
            }
           

        }
        //BancoDePrueba llamará al método ProbarAsiento de cada elemento en la lista
        public void BancoDePrueba( )
        {
            foreach (Asiento item in this.lista)
            {
                if (item is Sofa)
                {
                    item.ProbarAsiento();
                }
                item.ProbarAsiento();
            }
        }

        public void Manejador(bool sarasa)
        {
            if (sarasa)
            {
                MessageBox.Show("Finished");
            }
        }


    }
}
