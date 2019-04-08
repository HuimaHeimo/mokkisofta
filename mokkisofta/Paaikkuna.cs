using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mokkisofta
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tämä click event hoitaa päävalikon painikkeiden toiminnan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenu_Click(object sender, EventArgs e)
        {
            // Luodaan sender toiminnon tarkastusta varten.
            Button btn = (Button)sender;

            // Ehtolauseet hoitavat oikean valikkopainikkeen tunnistamisen
            if (btn == btnTpisteet)
            {
                Toimipisteet tp = new Toimipisteet();
                tp.ShowDialog();
            }
            else if (btn == btnPalvelut)
            {
                Palvelut p = new Palvelut();
                p.ShowDialog();
            }
            else if (btn == btnVaraukset)
            {
                Varaukset va = new Varaukset();
                va.ShowDialog();
            }
            else if (btn == btnAsiakkaat)
            {
                Asiakkaat a = new Asiakkaat();
                a.ShowDialog();
            }
            else if (btn == btnLaskut)
            {
                Laskut la = new Laskut();
                la.ShowDialog();
            }
            else if (btn == btnRaportit)
            {
                Raportit ra = new Raportit();
                ra.ShowDialog();
            }
            //Testi Altti github

        }

        private void MmmsPoistu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
