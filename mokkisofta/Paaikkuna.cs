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

            // Määritetään *-merkki salasanakenttään tulostuvaksi merkiksi.
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

                // Luodaan connectionStatus-muuttuja, johon luetaan TestConnection-funktion lopputulos.
                bool connectionStatus = S.TestConnection(connection);

                if (connectionStatus == true)
                {
                    // Kun tietokantayhteys on luotu, otetaan valikkopainikkeet käyttöön ja poistetaan yhdistämiseen liittyvät elementit käytöstä.
                    btnAsiakkaat.Enabled = true;
                    btnLaskut.Enabled = true;
                    btnPalvelut.Enabled = true;
                    btnRaportit.Enabled = true;
                    btnTpisteet.Enabled = true;
                    btnVaraukset.Enabled = true;
                    btnPvYhdista.Enabled = false;
                    cbPvAutentikointi.Enabled = false;
                    txbPvPalvelin.Enabled = false;
                    txbPvTietokanta.Enabled = false;

                    // Tuodaan tietokanta-asetusten viereen teksti indikaattoriksi onnistuneesta yhteydestä.
                    lblPvYhteys.Text = "Yhteys muodostettu";
                }
                else if (connectionStatus == false)
                {
                    MessageBox.Show("Tietokantayhteys epäonnistui. Anna toimivat arvot.");
                }



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

        private void tietojaOhjelmastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa ti = new Tietoa();
            ti.ShowDialog();
        }

        private void OhjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("ohje.pdf");
            }
            catch
            {
                MessageBox.Show("Jokin meni pieleen! Ota yhteys ohjelmiston valmistajaan.", "Virhe");
            }
        }
    }
}
