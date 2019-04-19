using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            txbPvPalvelin.Text = "localhost\\SQLEXPRESS";
            txbPvTietokanta.Text = "vp";
            /*
            btnAsiakkaat.Enabled = false;
            btnLaskut.Enabled = false;
            btnPalvelut.Enabled = false;
            btnRaportit.Enabled = false;
            btnTpisteet.Enabled = false;
            btnVaraukset.Enabled = false;
            */
            
        }


        string connection = @"Data Source=localhost\\SQLEXPRESS"";Initial Catalog=vp;User ID=sa;Password=Kissa123!";

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
            else if (btn == btnPvYhdista)
            {

                // Luodaan muuttujat tietokantayhteyttä varten.
                string server = null;
                string dataBaseName;
                string user;

                // Lisätään muuttujiin tietokantayhteyttä varten tarvittavat tiedot.
                server = txbPvPalvelin.Text;
                dataBaseName = txbPvTietokanta.Text;
                user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                string connection = @"Data Source=" + server + ";Initial Catalog=" + dataBaseName + ";User ID=sa;Password=Kissa123!";

                Sql S = new Sql();

                S.SetConnectionString(connection);

                btnAsiakkaat.Enabled = true;
                btnLaskut.Enabled = true;
                btnPalvelut.Enabled = true;
                btnRaportit.Enabled = true;
                btnTpisteet.Enabled = true;
                btnVaraukset.Enabled = true;

            }
            

        }

        // Funktio hoitaa pääikkunan yläpalkin toiminnan
        private void MmmsPoistu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
