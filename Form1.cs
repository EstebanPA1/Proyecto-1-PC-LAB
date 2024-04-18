using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Proyecto_1_Lab_PC
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public static Task timer = Task.Run(async delegate
        {
            await Task.Delay(60000);
        });
        private void ingresobtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ingusuariobox.Text))
            {
                MessageBox.Show("La casilla de usuario no debe estar vacia");

            }
            if (ingusuariobox.Text == "admin" && ingcontrabox.Text == "admin")
            {
                Form4 Resultados = new Form4();
                Resultados.ShowDialog();

                ingcontrabox.Clear();
                ingcontrabox.Clear();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                ingusuariobox.Clear();
                ingcontrabox.Clear();
                count++;

            }

            if ((count == 3))
            {
                MessageBox.Show("Maximo de intentos alcanzado");
                timer.Wait();
                Close();
            }
        }



        private void ingcontratxt_Click(object sender, EventArgs e)
        {

        }


        private void ingusuariotxt_Click(object sender, EventArgs e)
        {

        }

        private void ingcontrabox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresobtn.Focus();
            }
        }

        private void ingusuariobox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingcontrabox.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}