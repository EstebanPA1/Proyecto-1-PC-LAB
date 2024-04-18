using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1_Lab_PC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void votantebtn_Click(object sender, EventArgs e)
        {
                Form3 Votaciones = new Form3();
                Votaciones.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form1 IngresoUsuario = new Form1();
            IngresoUsuario.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
