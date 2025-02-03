using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_GRUPO9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se ajusta el tamaño del formulario
            Size = new Size(650,500);
        }

        private void btn_e1_Click(object sender, EventArgs e)
        {
            //Aparece el formulario del enunciado 1.
            Enunciado1 G9_frm = new Enunciado1();
            G9_frm.Show();
        }

        private void btn_e2_Click(object sender, EventArgs e)
        {
            //Aparece el formulario del enunciado 2.
            Enunciado2 G9_frm = new Enunciado2();
            G9_frm.Show();
        }
    }
}
