﻿using System;
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
    public partial class Palvelut : Form
    {
        // Luodaan boolean-muuttujat painikkeiden toiminnallisuuksia varten.
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;

        Sql S = new Sql();
        public Palvelut()
        {
            InitializeComponent();

            // Muutetaan DataGridView sellaiseksi, ettei yksittäisiä soluja pysty valitsemaan. Aina aktivoidaan koko rivi.
            dgwPalvelut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Tehdään Comboboxista alasvetovalikko, johon ei voi kirjoittaa.
            cboxPlvToimipiste.DropDownStyle = ComboBoxStyle.DropDownList;

            // Haetaan toimipisteet alasvetovalikkoon.
            S.Connect();
            DataTable dt = new DataTable();
            cboxPlvToimipiste = S.haeTaulustaLaatikkoon(S, cboxPlvToimipiste, dt, "Toimipiste", "toimipiste_id", "toimipiste_id,", "nimi"); 
            S.Close();

            // Haetaan tietokannasta palvelut DataGridViewiin.
            S.Connect();
            dgwPalvelut.DataSource = S.ShowInGridView("SELECT palvelu_id AS Id, nimi as Nimi, toimipiste_id AS Toimipiste, kuvaus AS Kuvaus, hinta AS Hinta, alv AS Arvonlisävero FROM Palvelu");
            S.Close();

        

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
                S.Connect();

                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin tekstikenttiin!");
                }
                else
                {
                    // Viedään tekstikenttien tiedot muuttujiin.
                    string pNimi = txbPlvNimi.Text;
                    string pToimipiste = cboxPlvToimipiste.Text;
                    string pKuvaus = txbPlvKuvaus.Text;
                    double pHinta = double.Parse(txbPlvHinta.Text);
                    double pAlv = double.Parse(txbPlvAlv.Text);

                    // Muodostetaan yllä olevien muuttujien avulla SQL-lause ja lisätään tiedot tauluun.
                    string pLisays = $"INSERT INTO Palvelu (nimi, toimipiste, kuvaus, hinta, alv) VALUES ('{pNimi}', '{pToimipiste}', '{pKuvaus}', '{pHinta}', '{pAlv}')";
                    S.Query(pLisays);
                    dgwPalvelut.DataSource = S.ShowInGridView("SELECT palvelu_id AS Id, toimipiste_id AS Toimipiste, nimi AS Palvelu, kuvaus AS Kuvaus, hinta AS hinta, alv AS Arvonlisävero FROM Palvelu");
                }
                
                S.Close();
            }
            // Jos painetaan Muokkaa-painiketta, muokataan DataFridViewistä valittu kohta.
            else if (btn == btnPlvMuokkaa)
            {
                   // Haetaan muokkausTila-funktiolla nykyiset arvot tekstikenttiin ja muutetaan painikkeiden toiminnallisuudet muokkauksen vaatimiksi.
                   muokkausTila();


                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                    string pToimipiste = cboxPlvToimipiste.Text;
                    string pKuvaus = txbPlvKuvaus.Text;
                    double pHinta = double.Parse(txbPlvHinta.Text);
                    double pAlv = double.Parse(txbPlvAlv.Text);
                    string valittuId = lblPaID.Text;
                    string asMuokkaus = $"UPDATE Palvelu SET toimipiste = '{pToimipiste}', kuvaus = '{pKuvaus}', hinta = '{pHinta}', alv = '{pAlv}'";

                    S.Query(asMuokkaus);
                    dgwPalvelut.DataSource = S.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");

            }
            else if (btn == btnPlvPoista)
            {
                DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
                if (kysely == DialogResult.OK)
                {
                    if (dgwPalvelut.CurrentCell != null)
                    {
                        S.Connect();
                        int rowIndex = dgwPalvelut.CurrentCell.RowIndex;
                        string valittuId = dgwPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
                        string asPoisto = $"DELETE FROM Asiakas WHERE asiakas_id='{valittuId}'";

                        S.Query(asPoisto);
                        dgwPalvelut.DataSource = S.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
                        S.Close();
                    }
                }
                if (kysely == DialogResult.Cancel)
                {

                }
            }
        }

        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            /*
            btnAsLisaa.Enabled = false;
            btnAsMuokkaa.Enabled = false;
            btnAsPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            */
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = dgwPalvelut.CurrentCell.RowIndex;
            lblPaID.Text = dgwPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
            cboxPlvToimipiste.Text = dgwPalvelut.Rows[rowIndex].Cells["Toimipiste"].Value.ToString();
            txbPlvNimi.Text = dgwPalvelut.Rows[rowIndex].Cells["Nimi"].Value.ToString();
            txbPlvKuvaus.Text = dgwPalvelut.Rows[rowIndex].Cells["Kuvaus"].Value.ToString();
            txbPlvHinta.Text = dgwPalvelut.Rows[rowIndex].Cells["Hinta"].Value.ToString();
            txbPlvAlv.Text = dgwPalvelut.Rows[rowIndex].Cells["Arvonlisävero"].Value.ToString();
            //Otetaan datagridin käyttö pois muokkauksen ajaksi
            dgwPalvelut.Enabled = false;
        }

        private void perusTila()
        {
            // Tämän ajettaessa kaikki tekstikentät nollataan. Lisää, Muokkaa, ja Poista painikkeet käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = false;
            /*
            btnAsLisaa.Enabled = true;
            btnAsMuokkaa.Enabled = true;
            btnAsPoista.Enabled = true;
            btnTpTallenna.Enabled = false; ;
            btnTpPeruuta.Enabled = false; ;
            */
            lblPaID.Text = "-";
            dgwPalvelut.Enabled = true;
        }

        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            /*
            btnAsLisaa.Enabled = false;
            btnAsMuokkaa.Enabled = false;
            btnAsPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            lblId.Text = "-";
            */
            dgwPalvelut.Enabled = false;
        }
    }
}
