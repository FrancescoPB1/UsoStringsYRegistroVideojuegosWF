using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_GRUPO9
{
    public partial class Enunciado2 : Form
    {
        public Enunciado2()
        {
            InitializeComponent();
        }
        private void cmb_dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Creamos la lista para los datos de la actividad hecha en el videojuego
        List<Datos> listDatos = new List<Datos>();
        //Variable donde se almacena el puntaje total.
        public int G9_PT=0;
        private void Enunciado2_Load(object sender, EventArgs e)
        {
            //Modifica el tamaño del formulario
            Size = new Size(850, 500);
            //Modifica el tamaño de las columnas del dgv_datos
            dgv_datos.Columns[0].Width = 85;
            dgv_datos.Columns[1].Width = 85;
            dgv_datos.Columns[2].Width = 85;
            dgv_datos.Columns[3].Width = 85;
            //Agrega elementos para elegir en el cmb_dia
            cmb_dia.Items.Add("Lunes");
            cmb_dia.Items.Add("Martes");
            cmb_dia.Items.Add("Miercoles");
            cmb_dia.Items.Add("Jueves");
            cmb_dia.Items.Add("Viernes");
            cmb_dia.Items.Add("Sabado");
            cmb_dia.Items.Add("Domingo");
            //Impide que el usuario ingrese datos al cmb_dia
            cmb_dia.DropDownStyle = ComboBoxStyle.DropDownList;
            //Agrega elementos para elegir en el cmb_result
            cmb_result.Items.Add("Victoria");
            cmb_result.Items.Add("Derrota");
            //Impide que el usuario ingrese datos al cmb_result
            cmb_result.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_videojuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            try
            {
                //Si no se ingresa ningún valor en los datos solicitados, se le pedirá al usuario que ingrese los que se indican.
                if (string.IsNullOrWhiteSpace(cmb_dia.Text) || string.IsNullOrWhiteSpace(txt_videojuego.Text) || string.IsNullOrWhiteSpace(cmb_result.Text))
                {
                    throw new Exception("Por favor, ingresa todos los valores requeridos.");
                }
                // Crea una nueva instancia de Datos
                Datos G9_datos = new Datos();
                G9_datos.G9_dia = cmb_dia.Text;
                G9_datos.G9_juego = txt_videojuego.Text;
                G9_datos.G9_result = cmb_result.SelectedItem.ToString();
                //Si datos.G9_result es igual a "Victoria", datos.G9_p se establece en 100, de lo contrario se establece en -20
                G9_datos.G9_p = G9_datos.G9_result == "Victoria" ? 100:-20;
                // Agrega la instancia de Datos a la lista
                listDatos.Add(G9_datos);

                // Actualiza el puntaje total
                G9_PT += G9_datos.G9_p;
                txt_puntajetotal.Text = G9_PT.ToString();
                //Se llama a la funcion donde se almacenaran los datos en el dgv_datos
                Actualizardgv();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message+ MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }
        private void Actualizardgv()
        {
            // Limpia el dgv_datos
            dgv_datos.Rows.Clear();

            // Agrega los datos de la lista al dgv_datos
            foreach (Datos listDatos in listDatos)
            {
                dgv_datos.Rows.Add(listDatos.G9_dia, listDatos.G9_juego, listDatos.G9_result, listDatos.G9_p);
            }


        }
        //Se crea esta variable para almacenar la ubicacion del archivo
        string G9_archivoUbicacion = null;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Si se ha registrado una actividad de un videojuego, se procedera a guardar el archivo
            if(listDatos.Count() != 0)
            {
                //Si se ha seleccionado una carpeta de destino para el archivo, se podra guardar el archivo.
                if (G9_archivoUbicacion != null)
                {
                    using (StreamWriter G9_a= new StreamWriter(G9_archivoUbicacion))
                    {
                        G9_a.WriteLine("Datos de mi actividad en los videojuegos");
                        int G9_registro = 1;
                        //Se utiliza el foreach para que se se agregue la informacion de una nueva actividad registrada.
                        foreach (var G9_dato in listDatos)
                        {
                            G9_a.WriteLine($"\nRegistro {G9_registro++}: ");
                            G9_a.WriteLine($"Dia: {G9_dato.G9_dia}");
                            G9_a.WriteLine($"Juego: {G9_dato.G9_juego}");
                            G9_a.WriteLine($"Resultado: {G9_dato.G9_result}");
                            G9_a.WriteLine($"Puntos obtenidos: {G9_dato.G9_p}");
                            G9_a.WriteLine("\n==========================");
                        }
                        //Se muestra el puntaje total.
                        G9_a.WriteLine($"Puntos totales: {G9_PT}");
                    }
                }
                //Si no se ha seleccionado una carpeta de destino para el archivo, saldra un mensaje indicando que se debe de elegir una carpeta de destino.
                else
                {
                    MessageBox.Show("Primero selecciona una carpeta donde guardaras el archivo.");
                }
            }
            //Si no se ha registrado aunque sea una actividad de un videojuego, saldra error.
            else
            {
                MessageBox.Show("Primero registra al menos una actividad de un videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto";
            // Establece el nombre del archivo
            saveFileDialog.FileName = "base_de_informacion.txt"; 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                G9_archivoUbicacion = saveFileDialog.FileName;
            }
        }
    }
}

