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

            }
            else if (btn == btnAsiakkaat)
            {

            }
            else if (btn == btnLaskut)
            {

            }
            else if (btn == btnRaportit)
            {

            }
        }
    }
}
