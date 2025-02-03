using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_FP_GRUPO9
{
    public partial class Enunciado1 : Form
    {
        public Enunciado1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Enunciado1_Load(object sender, EventArgs e)
        {
            //Se ajusta el tamaño del formulario para una mejor visualizacion 
            Size = new Size(550,600);
        }
        //Variable que sirve para almacenar la cantidad de palabras que el usuario ingresara
        private int G9_npalabras;
        //Aqui se almacenaran las palabras que el usuario ingresara.
        private string[] G9_palabras;
        //Aqui se llevara la cuenta de cuantas palabras ha ingresado el usuario.
        private int G9_cantpal = 0;
        private void txt_list_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_npal_Click(object sender, EventArgs e)
        {
            //Si el usuario ingresa otros valores que no sean números, saltara un mensaje de error.
            if (!int.TryParse(txt_npalabra.Text, out G9_npalabras))
            {
                MessageBox.Show("Error: Por favor, ingresa un número válido.");
                txt_npalabra.Text = "";
                return;
            }
            // Almacena la cantidad de palabras que el usuario va a ingresar
            G9_palabras = new string[G9_npalabras];
            // Limpia el box_list_pal para que el usuario pueda ingresar las palabras
            txt_palabra_add.Clear();
            box_list_pal.Items.Clear();
            txt_palabra_add.Focus();
            // Hace que el TextBox sea de solo lectura
            txt_npalabra.ReadOnly = true;
            //Desactiva el btn_npal para evitar errores.
            btn_npal.Enabled = false;
        }

        private void btn_palabra_add_Click(object sender, EventArgs e)
        {

            // Verifica si el usuario ha ingresado todas las palabras
            if (G9_cantpal >= G9_npalabras)
            {
                MessageBox.Show("Ya has ingresado todas las palabras.");
                //Se limpia el txt_palabra_add
                txt_palabra_add.Text = "";
                return;
            }
            // Verifica si la entrada del usuario contiene solo letras y espacios
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_palabra_add.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Por favor, ingresa solo palabras.");
                //Se limpia el txt_palabra_add
                txt_palabra_add.Text = "";
                return;
            }
            // Agrega la palabra que el usuario ingresó al arreglo
            G9_palabras[G9_cantpal] = txt_palabra_add.Text;
            G9_cantpal++;
            // Agrega la palabra que el usuario ingresó al box_list_pal
            box_list_pal.Items.Add(G9_palabras[G9_cantpal - 1]);
            // Limpia el TextBox para que el usuario pueda ingresar la siguiente palabra
            txt_palabra_add.Clear();
            txt_palabra_add.Focus();
        }

        private void btn_ord_Click(object sender, EventArgs e)
        {

            // Ordena el arreglo
            QuickSort(G9_palabras, 0, G9_palabras.Length - 1);

            // Limpia el ListBox y agrega los elementos ordenados
            box_list_pal.Items.Clear();
            box_list_pal.Items.AddRange(G9_palabras);
        }
        //Esta funcion es donde se utilizara el metodo QuickSort, de ahi su nombre.
        //G9_izq y G9_der representan el índice inicial y final del segmento del arreglo que se va a ordenar.   
        private void QuickSort(string[] G9_palabras, int G9_izq, int G9_der)
        {
            if (G9_izq < G9_der)
            {
                int G9_pivot = Partition(G9_palabras, G9_izq, G9_der);

                if (G9_pivot > 1)
                {
                    QuickSort(G9_palabras, G9_izq, G9_pivot - 1);
                }
                if (G9_pivot + 1 < G9_der)
                {
                    QuickSort(G9_palabras, G9_pivot + 1, G9_der);
                }
            }
        }
        private int Partition(string[] G9_palabras, int G9_izq, int G9_der)
        {
            string G9_pivot = G9_palabras[G9_izq];
            while (true)
            {
                while (string.Compare(G9_palabras[G9_izq], G9_pivot) < 0)
                {
                    G9_izq++;
                }

                while (string.Compare(G9_palabras[G9_der], G9_pivot) > 0)
                {
                    G9_der--;
                }

                if (G9_izq < G9_der)
                {
                    if (G9_palabras[G9_izq] == G9_palabras[G9_der]) return G9_der;

                    string G9_temp = G9_palabras[G9_izq];
                    G9_palabras[G9_izq] = G9_palabras[G9_der];
                    G9_palabras[G9_der] = G9_temp;
                }
                else
                {
                    return G9_der;
                }
            }
        }

        private void btn_eli_Click(object sender, EventArgs e)
        {
            // Borra todas las palabras del arreglo
            Array.Clear(G9_palabras, 0, G9_palabras.Length);
            G9_cantpal = 0;

            // Borra todas las palabras del ListBox
            box_list_pal.Items.Clear();

            // Hace que el TextBox sea editable nuevamente
            txt_npalabra.ReadOnly = false;
            txt_npalabra.Text = "";
            txt_palabra_add.Text = "";
            //Activa nuevamente al btn_npal
            btn_npal.Enabled = true;
        }
    }
}
