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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            dnnulo.Checked = true;
            ddnulo.Checked = true;
            dpnulo.Checked = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }

        #region Votos Presidente

        private void pvazulbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pvazulbtn.Checked)
            {
                Resultados.pvotoazul++;
            }
            else
            {
                Resultados.pvotoazul--;
            }
        }

        private void pvrojobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pvrojobtn.Checked)
            {
                Resultados.pvotorojo++;
            }
            else
            {
                Resultados.pvotorojo--;
            }
        }

        private void pvnegrobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pvnegrobtn.Checked)
            {
                Resultados.pvotonegro++;
            }
            else
            {
                Resultados.pvotonegro--;
            }
        }

        private void pvverdebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pvverdebtn.Checked)
            {
                Resultados.pvotoverde++;
            }
            else
            {
                Resultados.pvotoverde--;
            }
        }

        private void pvamarillobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (pvamarillobtn.Checked)
            {
                Resultados.pvotoamarillo++;
            }
            else
            {
                Resultados.pvotoamarillo--;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Resultados.pvotonulo++;
            }
            else
            {
                Resultados.pvotonulo--;
            }
        }

        #endregion

        private void alazulbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alazulbtn.Checked)
            {
                Resultados.avotoazul++;
            }
            else
            {
                Resultados.avotoazul--;
            }
        }

        private void alrojobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alrojobtn.Checked)
            {
                Resultados.avotorojo++;
            }
            else
            {
                Resultados.avotorojo--;
            }
        }

        private void alnegrobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alnegrobtn.Checked)
            {
                Resultados.avotonegro++;
            }
            else
            {
                Resultados.avotonegro--;
            }
        }

        private void alverdebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alverdebtn.Checked)
            {
                Resultados.avotoverde++;
            }
            else
            {
                Resultados.avotoverde--;
            }
        }

        private void dnazulbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dnazulbtn.Checked)
            {
                Resultados.dnvotoazul++;
            }
            else
            {
                Resultados.dnvotoazul--;
            }
        }

        private void dnrojobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dnrojobtn.Checked)
            {
                Resultados.dnvotorojo++;
            }
            else
            {
                Resultados.dnvotorojo--;
            }
        }

        private void dnnegrobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dnnegrobtn.Checked)
            {
                Resultados.dnvotonegro++;
            }
            else
            {
                Resultados.dnvotonegro--;
            }
        }

        private void dnverdebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dnverdebtn.Checked)
            {
                Resultados.dnvotoverde++;
            }
            else
            {
                Resultados.dnvotoverde--;
            }
        }

        private void dnamaillobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dnamarillobtn.Checked)
            {
                Resultados.dnvotoamarillo++;
            }
            else
            {
                Resultados.dnvotoamarillo--;
            }
        }

        private void dnnulo_CheckedChanged(object sender, EventArgs e)
        {
            if (dnnulo.Checked)
            {
                Resultados.dnvotonulo++;
            }
            else
            {
                Resultados.dnvotonulo--;
            }
        }

        private void ddazulbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ddazulbtn.Checked)
            {
                Resultados.ddvotoazul++;
            }
            else
            {
                Resultados.ddvotoazul--;
            }
        }

        private void ddrojobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ddrojobtn.Checked)
            {
                Resultados.ddvotorojo++;
            }
            else
            {
                Resultados.ddvotorojo--;
            }
        }

        private void ddnegrobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ddnegrobtn.Checked)
            {
                Resultados.ddvotonegro++;
            }
            else
            {
                Resultados.ddvotonegro--;
            }
        }

        private void ddverdebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ddverdebtn.Checked)
            {
                Resultados.ddvotoverde++;
            }
            else
            {
                Resultados.ddvotoverde--;
            }
        }

        private void ddamarillobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ddamarillobtn.Checked)
            {
                Resultados.ddvotoamarillo++;
            }
            else
            {
                Resultados.ddvotoamarillo--;
            }
        }

        private void ddnulo_CheckedChanged(object sender, EventArgs e)
        {
            if (ddnulo.Checked)
            {
                Resultados.ddvotonulo++;
            }
            else
            {
                Resultados.ddvotonulo--;
            }
        }

        private void dpazulbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dpazulbtn.Checked)
            {
                Resultados.dpvotoazul++;
            }
            else
            {
                Resultados.dpvotoazul--;
            }
        }

        private void dprojobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dprojobtn.Checked)
            {
                Resultados.dpvotorojo++;
            }
            else
            {
                Resultados.dpvotorojo--;
            }
        }

        private void dpnegrobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dpnegrobtn.Checked)
            {
                Resultados.dpvotonegro++;
            }
            else
            {
                Resultados.dpvotonegro--;
            }
        }

        private void dpverdebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dpverdebtn.Checked)
            {
                Resultados.dpvotoverde++;
            }
            else
            {
                Resultados.dpvotoverde--;
            }
        }

        private void dpamarillobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dpamarillobtn.Checked)
            {
                Resultados.dpvotoamarillo++;
            }
            else
            {
                Resultados.dpvotoamarillo--;
            }
        }

        private void dpnulo_CheckedChanged(object sender, EventArgs e)
        {
            if (dpnulo.Checked)
            {
                Resultados.dpvotonulo++;
            }
            else
            {
                Resultados.dpvotonulo--;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Resultados.avotonulo++;
            }
            else
            {
                Resultados.avotonulo--;
            }
        }

        private void alamarillobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alamarillobtn.Checked)
            {
                Resultados.avotoamarillo++;
            }
            else
            {
                Resultados.avotoamarillo--;
            }
        }

        private void subirbtn_Click(object sender, EventArgs e)
        {


            Close();
        }

        private void DiputadosParlacen_Enter(object sender, EventArgs e)
        {

        }
    }
}
