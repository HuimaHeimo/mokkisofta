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
        // Luodaan muuttujat tietokantayhteyttä varten.
        string userID;
        string password;
        string connection;
        string server;
        string dataBaseName;

        public Paaikkuna()
        {
            InitializeComponent();
            txbPvPalvelin.Text = "localhost\\SQLEXPRESS";
            txbPvTietokanta.Text = "vp";

            // Poistetaan päävalikon painikkeet käytöstä, kunnes tietokantayhteys on määritetty onnistuneesti.
            btnAsiakkaat.Enabled = false;
            btnLaskut.Enabled = false;
            btnPalvelut.Enabled = false;
            btnRaportit.Enabled = false;
            btnTpisteet.Enabled = false;
            btnVaraukset.Enabled = false;
            
            // Määritetään tietokanta-asetusten kentät alkutilaan.
            cbPvAutentikointi.Checked = true;
            txbPvTunnus.Enabled = false;
            txbPvSalasana.Enabled = false;

            txbPvSalasana.PasswordChar = '*';


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
                Toimipisteet tp = new Toimipisteet(connection);
                tp.ShowDialog();
            }
            else if (btn == btnPalvelut)
            {
                Palvelut p = new Palvelut(connection);
                p.ShowDialog();
            }
            else if (btn == btnVaraukset)
            {
                Varaukset va = new Varaukset(connection);
                va.ShowDialog();
            }
            else if (btn == btnAsiakkaat)
            {
                Asiakkaat a = new Asiakkaat(connection);
                a.ShowDialog();
            }
            else if (btn == btnLaskut)
            {
                Laskut la = new Laskut(connection);
                la.ShowDialog();
            }
            else if (btn == btnRaportit)
            {
                Raportit ra = new Raportit(connection);
                ra.ShowDialog();
            }
            else if (btn == btnPvYhdista)
            {


                server = txbPvPalvelin.Text;
                dataBaseName = txbPvTietokanta.Text;
                

                // Lisätään muuttujiin tietokantayhteyttä varten tarvittavat tiedot.
                server = txbPvPalvelin.Text;
                dataBaseName = txbPvTietokanta.Text;

                if (cbPvAutentikointi.Checked == true)
                {
                    connection = @"Data Source=" + server + ";Initial Catalog= " + dataBaseName + ";Integrated Security=SSPI";
                }
                else if (cbPvAutentikointi.Checked == false)
                {
                    userID = txbPvTunnus.Text;
                    password = txbPvSalasana.Text;
                    connection = @"Data Source=" + server + ";Initial Catalog=" + dataBaseName + ";" + "User ID=" + userID + ";" + "Password=" + password;
                }
                
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

        // Enabloidaan tai disabloidaan tietokannan autentikointitekstikentät valinnan mukaan.
        private void cbPvAutentikointi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPvAutentikointi.Checked == true)
            {
                txbPvTunnus.Enabled = false;
                txbPvSalasana.Enabled = false;
            }
            else if (cbPvAutentikointi.Checked == false)
            {
                txbPvTunnus.Enabled = true;
                txbPvSalasana.Enabled = true;
            }
        }
    }
}
