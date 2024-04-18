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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            p1.Text = "Votos azules: " + Convert.ToString(Resultados.pvotoazul);
            p2.Text = "Votos rojos: " + Convert.ToString(Resultados.pvotorojo);
            p3.Text = "Votos negros: " + Convert.ToString(Resultados.pvotonegro);
            p4.Text = "Votos verdes: " + Convert.ToString(Resultados.pvotoverde);
            p5.Text = "Votos amarillos: " + Convert.ToString(Resultados.pvotoamarillo);
            p6.Text = "Votos nulos: " + Convert.ToString(Resultados.pvotonulo);

            a1.Text = "Votos azules: " + Convert.ToString(Resultados.avotoazul);
            a2.Text = "Votos rojos: " + Convert.ToString(Resultados.avotorojo);
            a3.Text = "Votos negros: " + Convert.ToString(Resultados.avotonegro);
            a4.Text = "Votos verdes: " + Convert.ToString(Resultados.avotoverde);
            a5.Text = "Votos amarillos: " + Convert.ToString(Resultados.avotoamarillo);
            a6.Text = "Votos nulos: " + Convert.ToString(Resultados.avotonulo);

            dn1.Text = "Votos azules: " + Convert.ToString(Resultados.dnvotoazul);
            dn2.Text = "Votos rojos: " + Convert.ToString(Resultados.dnvotorojo);
            dn3.Text = "Votos negros: " + Convert.ToString(Resultados.dnvotonegro);
            dn4.Text = "Votos verdes: " + Convert.ToString(Resultados.dnvotoverde);
            dn5.Text = "Votos amarillos: " + Convert.ToString(Resultados.dnvotoamarillo);
            dn6.Text = "Votos nulos: " + Convert.ToString(Resultados.dnvotonulo);

            dd1.Text = "Votos azules: " + Convert.ToString(Resultados.ddvotoazul);
            dd2.Text = "Votos rojos: " + Convert.ToString(Resultados.ddvotorojo);
            dd3.Text = "Votos negros: " + Convert.ToString(Resultados.ddvotonegro);
            dd4.Text = "Votos verdes: " + Convert.ToString(Resultados.ddvotoverde);
            dd5.Text = "Votos amarillos: " + Convert.ToString(Resultados.ddvotoamarillo);
            dd6.Text = "Votos nulos: " + Convert.ToString(Resultados.ddvotonulo);

            dp1.Text = "Votos azules: " + Convert.ToString(Resultados.dpvotoazul);
            dp2.Text = "Votos rojos: " + Convert.ToString(Resultados.dpvotorojo);
            dp3.Text = "Votos negros: " + Convert.ToString(Resultados.dpvotonegro);
            dp4.Text = "Votos verdes: " + Convert.ToString(Resultados.dpvotoverde);
            dp5.Text = "Votos amarillos: " + Convert.ToString(Resultados.dpvotoamarillo);
            dp6.Text = "Votos nulos: " + Convert.ToString(Resultados.dpvotonulo);



        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
