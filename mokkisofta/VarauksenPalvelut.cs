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
        private string valittuRivi = "";

        private string dgSqlHakulause = "SELECT Varaus.varaus_id AS 'Varaus', Palvelu.nimi AS 'Palvelu', lkm AS 'Lukumäärä' " +
            "FROM Varauksen_palvelut INNER JOIN Varaus ON Varauksen_palvelut.varaus_id = Varaus.varaus_id INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id";

        public VarauksenPalvelut()
        {
            InitializeComponent();
            S.Connect();
            dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
            DataTable varaukset = new DataTable();
            DataTable palvelut = new DataTable();
            cboxVarPalVaraus = S.haeTaulustaLaatikkoon(S, cboxVarPalVaraus, varaukset, "Varaus", "varaus_id", "varaus_id");
            cboxVarPalPalvelu = S.haeTaulustaLaatikkoon(S, cboxVarPalPalvelu, palvelut, "Palvelu", "palvelu_id", "nimi");   
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
                    string varPalVaraus = cboxVarPalVaraus.SelectedValue.ToString();
                    string varPalPalvelu = cboxVarPalPalvelu.SelectedValue.ToString();
                    int varPalLukumaara = int.Parse(txbVarPalLukumaara.Text);

                    string varPalLisays = $"INSERT INTO Varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES ('{varPalVaraus}', '{varPalPalvelu}', '{varPalLukumaara}')";
                    S.Query(varPalLisays);
                    dgwVarauksenPalvelut.DataSource = S.ShowInGridView(dgSqlHakulause);
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                string varPalVaraus = cboxVarPalVaraus.SelectedValue.ToString();
                string varPalPalvelu = cboxVarPalPalvelu.SelectedValue.ToString();
                int varPalLukumaara = int.Parse(txbVarPalLukumaara.Text);
                string varPalMuokkaus = $"UPDATE Varauksen_palvelut SET varaus_id = '{varPalVaraus}',palvelu_id = '{varPalPalvelu}', lkm = '{varPalLukumaara}' WHERE varaus_id = {valittuRivi}";

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
                    valittuRivi = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Varaus"].Value.ToString();
                    string varPalPoisto = $"DELETE FROM Varauksen_palvelut WHERE varaus_id='{valittuRivi}'";
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
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = dgwVarauksenPalvelut.CurrentCell.RowIndex;
            valittuRivi = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Varaus"].Value.ToString();
            cboxVarPalVaraus.Text = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Varaus"].Value.ToString();
            cboxVarPalPalvelu.Text = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Palvelu"].Value.ToString();
            txbVarPalLukumaara.Text = dgwVarauksenPalvelut.Rows[rowIndex].Cells["Lukumäärä"].Value.ToString();
            //Otetaan datagridin käyttö pois muokkauksen ajaksi
            dgwVarauksenPalvelut.Enabled = false;
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


    }
}
