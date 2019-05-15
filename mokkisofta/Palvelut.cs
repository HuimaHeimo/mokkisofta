using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace mokkisofta
{
    public partial class Palvelut : Form
    {
        // Luodaan muuttuja DataGridViewiä varten. Sen ansiosta SELECT-lausetta ei tarvitse kirjoittaa toistuvasti. 
        private string sqlSelection = "SELECT palvelu_id AS Id, Palvelu.nimi AS Nimi, Toimipiste.nimi as Toimipiste, kuvaus AS Kuvaus, hinta AS hinta, alv AS Arvonlisävero FROM Palvelu " +
            "INNER JOIN Toimipiste ON Palvelu.toimipiste_id = Toimipiste.toimipiste_id";


        // Viedään tekstikenttien tiedot muuttujiin.
        private string pNimi;
        private string pToimipiste;
        private int pToimipisteId;
        private string pKuvaus;
        private double pHinta;
        private double pAlv;

        // Luodaan muuttuja päävalikosta tuotua yhdistämislausetta varten.
        string connectionString;

        // Luodaan apumuuttuja taulun päivitystä varten.
        private int rowIndex;

        Sql S = new Sql();

        public Palvelut(string connection)
        {
            InitializeComponent();

            // Tuodaan pääikkunassa muodostettu tietokantalause formille käytettäväksi.
            connectionString = connection;

            

            // Muutetaan DataGridView sellaiseksi, ettei yksittäisiä soluja pysty valitsemaan. Aina aktivoidaan koko rivi.
            dgwPalvelut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estetään käyttäjää lisäämästä suoraan DataGridViewiin rivejä.
            dgwPalvelut.AllowUserToAddRows = false;

            // Estetään DataGridViewin sisältöjen muokkaus.
            dgwPalvelut.ReadOnly = true;

            // Tehdään Comboboxista alasvetovalikko, johon ei voi kirjoittaa.
            cboxPlvToimipiste.DropDownStyle = ComboBoxStyle.DropDownList;

            // Estetään DataGridViewin sisältöjen muokkaus.
            dgwPalvelut.ReadOnly = true;

            // Haetaan toimipisteet alasvetovalikkoon.
            S.Connect(connectionString);
            DataTable dt = new DataTable();
            cboxPlvToimipiste = S.haeTaulustaLaatikkoon(S, cboxPlvToimipiste, dt, "Toimipiste", "toimipiste_id", "nimi"); 
            S.Close();

            // Haetaan tietokannasta palvelut DataGridViewiin.
            S.Connect(connectionString);
            
            dgwPalvelut.DataSource = S.ShowInGridView(sqlSelection);
           
            S.Close();

            btnPlvTallenna.Enabled = false;
            btnPlvPeruuta.Enabled = false;



        }

        
        /// <summary>
        /// Funktio hoitaa valikkopainikkeiden toiminnan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void palvelut_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Jos painetaan Lisää-painiketta, kentissä olevat tiedot viedään tietokantaan.
            if (btn == btnPlvLisää)
            {
                S.Connect(connectionString);

                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin tekstikenttiin!");
                }
                else
                {
                    // Viedään tekstikenttien tiedot muuttujiin.
                    pNimi = txbPlvNimi.Text;
                    pToimipiste = cboxPlvToimipiste.SelectedValue.ToString();
                    pToimipisteId = int.Parse(pToimipiste);
                    pKuvaus = txbPlvKuvaus.Text;
                    pHinta = double.Parse(txbPlvHinta.Text);
                    pAlv = double.Parse(txbPlvAlv.Text);

                    // Muodostetaan yllä olevien muuttujien avulla SQL-lause ja lisätään tiedot tauluun.
                    string pLisays = $"INSERT INTO Palvelu (nimi, toimipiste_id, kuvaus, hinta, alv) VALUES ('{pNimi}', '{pToimipiste}', '{pKuvaus}', '{pHinta}', '{pAlv}')";
                    S.Query(pLisays);
                    dgwPalvelut.DataSource = S.ShowInGridView(sqlSelection);

                    // Lisäyksen jälkeen tyhjennetään tekstikentät
                    this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
                }
                
                S.Close();
            }
            // Jos painetaan Muokkaa-painiketta, muokataan DataFridViewistä valittu kohta.
            else if (btn == btnPlvMuokkaa)
            {
                // Haetaan muokkausTila-funktiolla nykyiset arvot tekstikenttiin ja muutetaan painikkeiden toiminnallisuudet muokkauksen vaatimiksi.
                muokkausTila();


            }
            else if (btn == btnPlvPoista)
            {
                DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
                if (kysely == DialogResult.OK)
                {
                    if (dgwPalvelut.CurrentCell != null)
                    {
                        S.Connect(connectionString);
                        int rowIndex = dgwPalvelut.CurrentCell.RowIndex;
                        string valittuId = dgwPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
                        string asPoisto = $"DELETE FROM Palvelu WHERE palvelu_id='{valittuId}'";

                        
                        try
                        {
                            S.Query(asPoisto);
                        }
                        catch (Exception ex)
                        {
                            if (ex is SqlException)
                            {
                                // Handle more specific SqlException exception here.  
                                MessageBox.Show("Error, yksi tai useampi lasku/varaus/toimipiste käyttää tätä palvelua. Poista kyseiset rivit ennen palvelun poistamista.");
                            }
                            else
                            {

                            }
                        }
                        dgwPalvelut.DataSource = S.ShowInGridView(sqlSelection);
                        S.Close();
                    }
                }
                if (kysely == DialogResult.Cancel)
                {

                }
            }
            else if (btn == btnPlvPeruuta)
            {
                perusTila();
            }
            else if (btn == btnPlvTallenna)
            {
                
                // Viedään tekstikenttien muokatut tiedot apumuuttujiin ja apumuuttujien avulla tauluun. Valitaan oikea palvelu rowIndex-muuttujaan viedyllä palvelu-id:llä.
                S.Connect(connectionString);
                
                pNimi = txbPlvNimi.Text;
                pToimipiste = cboxPlvToimipiste.SelectedValue.ToString();
                pToimipisteId = int.Parse(pToimipiste);
                pKuvaus = txbPlvKuvaus.Text;
                pHinta = double.Parse(txbPlvHinta.Text);
                pAlv = double.Parse(txbPlvAlv.Text);

                
                string asMuokkaus = $"UPDATE Palvelu SET toimipiste_id = '{pToimipiste}', nimi = '{pNimi}', kuvaus = '{pKuvaus}', hinta = '{pHinta}', alv = '{pAlv}' WHERE palvelu_id='{rowIndex}'";

                S.Query(asMuokkaus);
                dgwPalvelut.DataSource = S.ShowInGridView(sqlSelection);

                dgwPalvelut.Enabled = true;

                // Poistetaan Peruuta- ja Tallenna-painikkeet käytöstä.
                btnPlvPeruuta.Enabled = false;
                btnPlvTallenna.Enabled = false;

                // Otetaan Lisää-, Poista ja Muokkaa-painikkeet käyttöön.
                btnPlvLisää.Enabled = true;
                btnPlvPoista.Enabled = true;
                btnPlvMuokkaa.Enabled = true;

                S.Close();
                
            }
        }

        private void muokkausTila()
        {

            try
            {
                if (dgwPalvelut.CurrentCell.RowIndex != null)
                {
                    // Lisätään valitun rivin tiedot tekstikenttiin ja otetaan valitun palvelun id-numero talteen rowIndex-muuttujaan.
                    rowIndex = dgwPalvelut.CurrentCell.RowIndex;
                    lblPaID.Text = dgwPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
                    cboxPlvToimipiste.Text = dgwPalvelut.Rows[rowIndex].Cells["Toimipiste"].Value.ToString();
                    txbPlvNimi.Text = dgwPalvelut.Rows[rowIndex].Cells["Nimi"].Value.ToString();
                    txbPlvKuvaus.Text = dgwPalvelut.Rows[rowIndex].Cells["Kuvaus"].Value.ToString();
                    txbPlvHinta.Text = dgwPalvelut.Rows[rowIndex].Cells["Hinta"].Value.ToString();
                    txbPlvAlv.Text = dgwPalvelut.Rows[rowIndex].Cells["Arvonlisävero"].Value.ToString();
                    rowIndex = int.Parse(lblPaID.Text);

                    //Otetaan datagridin käyttö pois muokkauksen ajaksi
                    dgwPalvelut.Enabled = false;

                    // Poistetaan lisää-, poista- ja muokkaa-painikkeet käytöstä. Niitä ei tarvita muokkaustilassa.
                    btnPlvPoista.Enabled = false;
                    btnPlvLisää.Enabled = false;
                    btnPlvMuokkaa.Enabled = false;

                    // Otetaan peruuta- ja tallenna-painikkeet käyttöön.
                    btnPlvPeruuta.Enabled = true;
                    btnPlvTallenna.Enabled = true;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error, ei muokattavaa riviä! \n" + ex.Message);
                perusTila();
            }    
        }

        private void perusTila()
        {
            // Tämän ajettaessa kaikki tekstikentät nollataan. Lisää, Muokkaa, ja Poista painikkeet käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);

            // Poistetaan Peruuta- ja Tallenna-painikkeet käytöstä.
            btnPlvPeruuta.Enabled = false;
            btnPlvTallenna.Enabled = false;

            // Otetaan Lisää-, Poista ja Muokkaa-painikkeet käyttöön.
            btnPlvLisää.Enabled = true;
            btnPlvPoista.Enabled = true;
            btnPlvMuokkaa.Enabled = true;


            //Otetaan datagridin takaisin käyttöön.
            dgwPalvelut.Enabled = true;
        }

        /// <summary>
        /// Sallitaan hinta-kenttään ainoastaan numerot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbPlvHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Sallitaan alv-kenttään ainoastaan numerot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbPlvAlv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tietoaOhjelmastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa ti = new Tietoa();
            ti.ShowDialog();
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
