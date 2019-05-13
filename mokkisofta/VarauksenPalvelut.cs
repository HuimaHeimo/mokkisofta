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
    public partial class VarauksenPalvelut : Form
    {
        Sql S = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        // valittuRivi muuttujaa käytetään kun muokataan tai poistetaan rivin tietoja, muuttuja sisältää id arvon
        // jolla tunnistetaan rivit toisistaan. 
        private string valittuId = "";
        private int rowIndex;
        /* käytin tässä luokassa myös julkista varaus_id muuttujaa Varaukset luokasta (Varaukset.varaus_id) . Tällä muuttujalla varmistetaan että
         * VarauksenPalvelut datagridin listauksessa näkyvät vain Varaukset luokasta valitun varauksen tiedot.
         */
        private string dgSqlHakulause = $"SELECT varauksen_palvelut_id as 'Id', Palvelu.nimi AS 'Palvelu', lkm AS 'Lukumäärä' FROM Varauksen_palvelut " +
                                        $"INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id WHERE Varauksen_palvelut.varaus_id = {Varaukset.varaus_id}";

        public VarauksenPalvelut()
        {
            InitializeComponent();
            // Muutetaan DataGridView sellaiseksi, ettei yksittäisiä soluja pysty valitsemaan. Aina aktivoidaan koko rivi.
            dgwVarauksenPalvelut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Estetään käyttäjää lisäämästä suoraan DataGridViewiin rivejä.
            dgwVarauksenPalvelut.AllowUserToAddRows = false;
            // Estetään DataGridViewin sisältöjen muokkaus.
            dgwVarauksenPalvelut.ReadOnly = true;
            // Tehdään Comboboxista alasvetovalikko, johon ei voi kirjoittaa.
            cboxVarPalPalvelu.DropDownStyle = ComboBoxStyle.DropDownList;
            
            S.Connect();
            dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
            DataTable palvelut = new DataTable();
            //cboxVarPalPalvelu = S.haeTaulustaLaatikkoon(S, cboxVarPalPalvelu, palvelut, "Palvelu", "palvelu_id", "nimi");    // toimipiste_id
            cboxVarPalPalvelu = S.haeVarauksenPalvelut(S, cboxVarPalPalvelu, palvelut, "Palvelu", "palvelu_id", "nimi", Varaukset.toimipiste_id);
            S.Close();
            perusTila();
        }
        private void BtnVarPalLisaa_Click(object sender, EventArgs e)
        {
            lisaysTila();
        }

        private void BtnVarPalMuokkaa_Click(object sender, EventArgs e)
        {
            
           
            muokkausTila();
        }
        private void BtnVarPalPeruuta_Click(object sender, EventArgs e)
        {
            perusTila();
        }
        private void BtnVarPalTallenna_Click(object sender, EventArgs e)
        {
            /* Ehtolauseella tarkastetaan halutaanko lisätä vai muokata tietoja tietokantaan. 
            * Muuttujina ovat btnLisaaPainettu ja btnMuokkaaPainettu. Toiminnon jälkeen kyseiset muuttujat saavat arvon false.
            * Toiminnon suoritettua kaikki tekstikentät nollataan ja painonapit ovat jälleen käytettävissä.
            */
            S.Connect();
            if (btnLisaaPainettu == true)
            {

                if (this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)) || this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin kenttiin!");
                }
                else
                {
                    string varPalPalvelu = cboxVarPalPalvelu.SelectedValue.ToString();
                    int varPalLukumaara = int.Parse(txbVarPalLukumaara.Text);
                    string varPalLisays = $"INSERT INTO Varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES ('{Varaukset.varaus_id}', '{varPalPalvelu}', '{varPalLukumaara}')";
                    S.Query(varPalLisays);
                    dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                string varPalPalvelu = cboxVarPalPalvelu.SelectedValue.ToString();
                int varPalLukumaara = int.Parse(txbVarPalLukumaara.Text);
                string varPalMuokkaus = $"UPDATE Varauksen_palvelut SET palvelu_id = '{varPalPalvelu}', lkm = '{varPalLukumaara}' WHERE varauksen_palvelut_id = {valittuId}";
                S.Query(varPalMuokkaus);
                dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
                perusTila();
            }

            S.Close();
        }


        private void BtnVarPalPoista_Click(object sender, EventArgs e)
        {
            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (dgwVarauksenPalvelut.CurrentCell != null)
                {
                    S.Connect();
                    int rowIndex = dgwVarauksenPalvelut.CurrentCell.RowIndex;
                    valittuId = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string varPalPoisto = $"DELETE FROM Varauksen_palvelut WHERE varauksen_palvelut_id = '{valittuId}'";
                    S.Query(varPalPoisto);
                    dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
                    S.Close();
                }
            }
            if (kysely == DialogResult.Cancel)
            {

            }
        }

        private void perusTila()
        {
            // Tämän ajettaessa kaikki tekstikentät nollataan. Lisää, Muokkaa, ja Poista painikkeet käytössä.
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Text = string.Empty);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = false);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = false;
            btnVarPalLisaa.Enabled = true;
            btnVarPalMuokkaa.Enabled = true;
            btnVarPalPoista.Enabled = true;
            btnVarPalTallenna.Enabled = false; ;
            btnVarPalPeruuta.Enabled = false; ;
            dgwVarauksenPalvelut.Enabled = true;
        }
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnVarPalLisaa.Enabled = false;
            btnVarPalMuokkaa.Enabled = false;
            btnVarPalPoista.Enabled = false;
            btnVarPalTallenna.Enabled = true;
            btnVarPalPeruuta.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenttiin
            
            try
            {
                if (dgwVarauksenPalvelut.CurrentCell.RowIndex != null)
                {
                    rowIndex = dgwVarauksenPalvelut.CurrentCell.RowIndex;
                    valittuId = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Id"].Value.ToString();
                    cboxVarPalPalvelu.Text = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Palvelu"].Value.ToString();
                    txbVarPalLukumaara.Text = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Lukumäärä"].Value.ToString();
                    //Otetaan datagridin käyttö pois muokkauksen ajaksi
                    dgwVarauksenPalvelut.Enabled = false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error, ei muokattavaa riviä! \n" + ex.Message);
                perusTila();
            }

        }


        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            btnVarPalLisaa.Enabled = false;
            btnVarPalMuokkaa.Enabled = false;
            btnVarPalPoista.Enabled = false;
            btnVarPalTallenna.Enabled = true;
            btnVarPalPeruuta.Enabled = true;
            dgwVarauksenPalvelut.Enabled = false;
        }

        private void TxbVarPalLukumaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
