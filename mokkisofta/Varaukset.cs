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
    public partial class Varaukset : Form
    {
        Sql S = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        private string valittuRivi = "";
        /* SQL hakulause tietojen hakemiseen datagridiin. Hakee Asiakas taulusta etunimen ja sukunimen ja tulostaa ne Asiakas_id sijasta.
         * Hakee Toimipiste taulusta Toimipisteen nimen ja tulostaa sen toimipiste_id sijasta. Loput kentistä on Varaus taulusta.
         */
        private string dgSqlHakulause = "SELECT varaus_id AS 'Id', Asiakas.etunimi AS 'Etunimi', Asiakas.sukunimi AS 'Sukunimi', Toimipiste.nimi AS 'Toimipiste', varattu_pvm AS 'Varattu pvm', " +
            "vahvistus_pvm AS 'Vahvistus pvm', varattu_alkupvm AS 'Varauksen alkupvm', varattu_loppupvm AS 'Varauksen loppupvm' " +
            "FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id";
        public Varaukset()
        {
            InitializeComponent();
            DgwVaraukset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estetään käyttäjää lisäämästä suoraan DataGridViewiin rivejä.
            DgwVaraukset.AllowUserToAddRows = false;
            S.Connect();
            DgwVaraukset.DataSource = S.ShowInGridView(dgSqlHakulause);
            DataTable asiakkaat = new DataTable();
            DataTable toimipisteet = new DataTable();
            cboxVarAsiakas = S.haeTaulustaLaatikkoon(S, cboxVarAsiakas, asiakkaat, "Asiakas", "asiakas_id", "etunimi", "sukunimi"); 
            cboxVarToimipiste = S.haeTaulustaLaatikkoon(S, cboxVarToimipiste, toimipisteet, "Toimipiste", "toimipiste_id", "nimi");
            S.Close();
            perusTila();
        }

        private void BtnVarLisaa_Click(object sender, EventArgs e)
        {
            lisaysTila();
        }

        private void BtnVarMuokkaa_Click(object sender, EventArgs e)
        {
            muokkausTila();
        }
        private void BtnVarPeruuta_Click(object sender, EventArgs e)
        {
            perusTila();
        }
        private void BtnVarTallenna_Click(object sender, EventArgs e)
        {
            /* Ehtolauseella tarkastetaan halutaanko lisätä vai muokata tietoja tietokantaan. 
            * Muuttujina ovat btnLisaaPainettu ja btnMuokkaaPainettu. Toiminnon jälkeen kyseiset muuttujat saavat arvon false.
            * Toiminnon suoritettua kaikki tekstikentät nollataan ja painonapit ovat jälleen käytettävissä.
            */
            S.Connect();
            if (btnLisaaPainettu == true)
            {

                if (this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)) || this.Controls.OfType<DateTimePicker>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin kenttiin!");
                }
                else
                {
                    string varNimi = cboxVarAsiakas.SelectedValue.ToString();
                    string varToimipiste = cboxVarToimipiste.SelectedValue.ToString();
                    string varVarattupvm = dtVarPvm.Value.ToString("yyyyMMdd");
                    string varVahvistuspvm = dtVarVahvistuspvm.Value.ToString("yyyyMMdd");
                    string varAlkupvm = dtVarAlkupvm.Value.ToString("yyyyMMdd");
                    string varLoppupvm = dtVarLoppupvm.Value.ToString("yyyyMMdd");
                    string varLisays = $"INSERT INTO Varaus (asiakas_id, toimipiste_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) " +
                        $"VALUES ('{varNimi}', '{varToimipiste}', '{varVarattupvm}', '{varVahvistuspvm}', '{varAlkupvm}', '{varLoppupvm}')";

                    S.Query(varLisays);
                    DgwVaraukset.DataSource = S.ShowInGridView(dgSqlHakulause);
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                string varNimi = cboxVarAsiakas.SelectedValue.ToString();
                string varToimipiste = cboxVarToimipiste.SelectedValue.ToString();
                string varVarattupvm = dtVarPvm.Value.ToString("yyyyMMdd");
                string varVahvistuspvm = dtVarVahvistuspvm.Value.ToString("yyyyMMdd");
                string varAlkupvm = dtVarAlkupvm.Value.ToString("yyyyMMdd");
                string varLoppupvm = dtVarLoppupvm.Value.ToString("yyyyMMdd");
                string varMuokkaus = $"UPDATE Varaus SET asiakas_id = '{varNimi}', toimipiste_id = '{varToimipiste}', varattu_pvm = '{varVarattupvm}', " +
                    $"vahvistus_pvm = '{varVahvistuspvm}', varattu_alkupvm = '{varAlkupvm}', varattu_loppupvm = '{varLoppupvm}' WHERE varaus_id = {valittuRivi}";

                S.Query(varMuokkaus);
                DgwVaraukset.DataSource = S.ShowInGridView(dgSqlHakulause);
                perusTila();
            }

            S.Close();
        }
        private void BtnVarPoista_Click(object sender, EventArgs e)
        {
            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (DgwVaraukset.CurrentCell != null)
                {
                    S.Connect();
                    int rowIndex = DgwVaraukset.CurrentCell.RowIndex;
                    valittuRivi = DgwVaraukset.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string varPoisto = $"DELETE FROM Toimipiste WHERE toimipiste_id='{valittuRivi}'";
                    S.Query(varPoisto);
                    DgwVaraukset.DataSource = S.ShowInGridView(dgSqlHakulause);
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
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = false);
            this.Controls.OfType<DateTimePicker>().ToList().ForEach(t => t.Enabled = false);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = false;
            btnVarLisaa.Enabled = true;
            btnVarMuokkaa.Enabled = true;
            btnVarPoista.Enabled = true;
            btnVarTallenna.Enabled = false; ;
            btnVarPeruuta.Enabled = false; ;
            DgwVaraukset.Enabled = true;
        }
        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<DateTimePicker>().ToList().ForEach(t => t.Enabled = true); 
            btnLisaaPainettu = true;
            btnVarLisaa.Enabled = false;
            btnVarMuokkaa.Enabled = false;
            btnVarPoista.Enabled = false;
            btnVarTallenna.Enabled = true;
            btnVarPeruuta.Enabled = true;
            DgwVaraukset.Enabled = false;
        }
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<DateTimePicker>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnVarLisaa.Enabled = false;
            btnVarMuokkaa.Enabled = false;
            btnVarPoista.Enabled = false;
            btnVarTallenna.Enabled = true;
            btnVarPeruuta.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = DgwVaraukset.CurrentCell.RowIndex;
            valittuRivi = DgwVaraukset.Rows[rowIndex].Cells["Id"].Value.ToString();
            cboxVarAsiakas.Text = DgwVaraukset.Rows[rowIndex].Cells["Etunimi"].Value.ToString() + " " + DgwVaraukset.Rows[rowIndex].Cells["Sukunimi"].Value.ToString();
            cboxVarToimipiste.Text = DgwVaraukset.Rows[rowIndex].Cells["Toimipiste"].Value.ToString();
            dtVarPvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varattu pvm"].Value.ToString();
            dtVarVahvistuspvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Vahvistus pvm"].Value.ToString();
            dtVarAlkupvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varauksen alkupvm"].Value.ToString();
            dtVarLoppupvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varauksen loppupvm"].Value.ToString();
            DgwVaraukset.Enabled = false;
        }


    }
}
