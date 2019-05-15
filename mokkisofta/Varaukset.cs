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
        // Luodaan muuttuja päävalikosta tuotua yhdistämislausetta varten.
        string connectionString;

        Sql S = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        // varaus_id muuttujaa käytetään myös VarauksenPalvelut luokassa. Tähän muuttujaan talletetaan valitun rivin id arvo muokkaamista/poistamista varten.
        public static string varaus_id = ""; // tarvitaan VarauksenPalvelut luokassa
        public static string toimipiste_id = ""; // tarvitaan VarauksenPalvelut luokassa
        private string valittuId = "";
        private int rowIndex;
        /* SQL hakulause tietojen hakemiseen datagridiin. Hakee Asiakas taulusta etunimen ja sukunimen ja tulostaa ne Asiakas_id sijasta.
         * Hakee Toimipiste taulusta Toimipisteen nimen ja tulostaa sen toimipiste_id sijasta. Loput kentistä on Varaus taulusta.
         */
        private string dgSqlHakulause = "SELECT varaus_id AS 'Id', Asiakas.etunimi AS 'Etunimi', Asiakas.sukunimi AS 'Sukunimi', Toimipiste.nimi AS 'Toimipiste', varattu_pvm AS 'Varattu pvm', " +
            "vahvistus_pvm AS 'Vahvistus pvm', varattu_alkupvm AS 'Varauksen alkupvm', varattu_loppupvm AS 'Varauksen loppupvm' " +
            "FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id";
        public Varaukset(string connection)
        {
            InitializeComponent();

            // Tuodaan pääikkunassa muodostettu tietokantalause formille käytettäväksi.
            connectionString = connection;

            DgwVaraukset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Estetään käyttäjää lisäämästä suoraan DataGridViewiin rivejä.
            DgwVaraukset.AllowUserToAddRows = false;
            // Estetään DataGridViewin sisältöjen muokkaus.
            DgwVaraukset.ReadOnly = true;
            // Tehdään Comboboxista alasvetovalikko, johon ei voi kirjoittaa.
            cboxVarAsiakas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxVarToimipiste.DropDownStyle = ComboBoxStyle.DropDownList;
            S.Connect(connectionString);
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
            S.Connect(connectionString);
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
                    $"vahvistus_pvm = '{varVahvistuspvm}', varattu_alkupvm = '{varAlkupvm}', varattu_loppupvm = '{varLoppupvm}' WHERE varaus_id = {valittuId}";

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
                    S.Connect(connectionString);
                    int rowIndex = DgwVaraukset.CurrentCell.RowIndex;
                    valittuId = DgwVaraukset.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string varPalPoisto = $"DELETE FROM Varauksen_palvelut WHERE varaus_id='{valittuId}'";
                    string lasPoisto = $"DELETE FROM Lasku WHERE varaus_id='{valittuId}'";
                    string varPoisto = $"DELETE FROM Varaus WHERE varaus_id='{valittuId}'";
                    S.Query(varPalPoisto);
                    S.Query(lasPoisto);
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
            btnVarTallenna.Enabled = false;
            btnVarPeruuta.Enabled = false;
            btnVarauksenPalvelut.Enabled = false;
            DgwVaraukset.Enabled = true;
            DateTime d = new DateTime(2019,1,1);
            dtVarPvm.MinDate = d;
            dtVarAlkupvm.MinDate = d;
            dtVarLoppupvm.MinDate = d;
            dtVarVahvistuspvm.MinDate = d;
            dtVarAlkupvm.Value = DateTime.Today;
            dtVarPvm.Value = DateTime.Today;
            dtVarVahvistuspvm.Value = DateTime.Today;
            dtVarLoppupvm.Value = DateTime.Today;
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
            btnVarauksenPalvelut.Enabled = false;
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
            btnVarauksenPalvelut.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenntiin

            try
            {
                if (DgwVaraukset.CurrentCell.RowIndex != null)
                {
                    rowIndex = DgwVaraukset.CurrentCell.RowIndex;
                    varaus_id = DgwVaraukset.Rows[rowIndex].Cells["Id"].Value.ToString();
                    valittuId = DgwVaraukset.Rows[rowIndex].Cells["Id"].Value.ToString();
                    cboxVarAsiakas.Text = DgwVaraukset.Rows[rowIndex].Cells["Etunimi"].Value.ToString() + " " + DgwVaraukset.Rows[rowIndex].Cells["Sukunimi"].Value.ToString();
                    cboxVarToimipiste.Text = DgwVaraukset.Rows[rowIndex].Cells["Toimipiste"].Value.ToString();
                    dtVarPvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varattu pvm"].Value.ToString();
                    dtVarVahvistuspvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Vahvistus pvm"].Value.ToString();
                    dtVarAlkupvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varauksen alkupvm"].Value.ToString();
                    dtVarLoppupvm.Text = DgwVaraukset.Rows[rowIndex].Cells["Varauksen loppupvm"].Value.ToString();
                    DgwVaraukset.Enabled = false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error, ei muokattavaa riviä! \n" + ex.Message);
                perusTila();
            }

        }

        private void btnVarauksenPalvelut_Click(object sender, EventArgs e)
        {
            VarauksenPalvelut vp = new VarauksenPalvelut(connectionString);
            toimipiste_id = cboxVarToimipiste.SelectedValue.ToString();
            vp.Text = "Varauksen " + varaus_id + " palvelut";
            vp.ShowDialog(); 
            perusTila();
        }

        private void DtVarPvm_ValueChanged(object sender, EventArgs e)
        {
            dtVarAlkupvm.MinDate = dtVarPvm.Value;
            dtVarVahvistuspvm.MinDate = dtVarPvm.Value;
            dtVarAlkupvm.MinDate = dtVarPvm.Value;
            dtVarLoppupvm.MinDate = dtVarPvm.Value;
        }

        private void DtVarAlkupvm_ValueChanged(object sender, EventArgs e)
        {
            dtVarLoppupvm.MinDate = dtVarAlkupvm.Value;
        }

        private void DtVarVahvistuspvm_ValueChanged(object sender, EventArgs e)
        {
            dtVarAlkupvm.MinDate = dtVarVahvistuspvm.Value;
            dtVarLoppupvm.MinDate = dtVarAlkupvm.Value;
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
