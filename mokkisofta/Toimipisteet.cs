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
    public partial class Toimipisteet : Form
    { 
        Sql S = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        private string valittuRivi = "";
        public Toimipisteet()
        {
            InitializeComponent();

            S.Connect();
            DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
            S.Close();

            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false); // Ohjelman käynnistyessä tekstikenttiin ei voi syöttää tietoa.
            btnTpTallenna.Enabled = false;
            btnTpPeruuta.Enabled = false;
            /*
            // Määritetään datagridview niin, että koko rivi tulee aina valituksi.
            DgwToimipisteet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Yhdistetään kantaan ja lisätään Toimipiste-taulu dataGridViewiin.
            user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            SqlConnection sql;
            database = @"Data Source=" + server + ";Initial Catalog=" + dbname + ";User ID=sa;Password=Kissa123!";

            sql = new SqlConnection(database);
            sql.Open();
            da = new SqlDataAdapter("Select toimipiste_id as Id, nimi as Nimi, lahiosoite as Osoite, postitoimipaikka as paikkakunta, postinro as Postinumero, email as Sähköposti, puhelinnro as Puhelin from Toimipiste", sql);
            da.Fill(ds, "Toimipiste");
            DgwToimipisteet.DataSource = ds;
            DgwToimipisteet.DataMember = "Toimipiste";
                
            sql.Close();
            */
        }

        private void BtnTpLisaa_Click(object sender, EventArgs e)
        {
            lisaysTila();
        }

        private void BtnTpMuokkaa_Click(object sender, EventArgs e)
        {
            muokkausTila();
        }

        private void BtnTpPoista_Click(object sender, EventArgs e)
        {

            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (DgwToimipisteet.CurrentCell != null)
                {
                    S.Connect();
                    int rowIndex = DgwToimipisteet.CurrentCell.RowIndex;
                    valittuRivi = DgwToimipisteet.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string tpPoisto = $"DELETE FROM Toimipiste WHERE toimipiste_id='{valittuRivi}'";

                    S.Query(tpPoisto);
                    DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
                    S.Close();
                }
            }
            if (kysely == DialogResult.Cancel)
            {

            }
        }

        private void TxbTpPuhnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void TxbTpPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void BtnTpTallenna_Click(object sender, EventArgs e)
        {
            /* Ehtolauseella tarkastetaan halutaanko lisätä vai muokata tietoja tietokantaan. 
             * Muuttujina ovat btnLisaaPainettu ja btnMuokkaaPainettu. Toiminnon jälkeen kyseiset muuttujat saavat arvon false.
             * Toiminnon suoritettua kaikki tekstikentät nollataan ja painonapit ovat jälleen käytettävissä.
             */
            S.Connect();
            if (btnLisaaPainettu == true)
            {
                string tpNimi = txbTpNimi.Text;
                string tpOsoite = txbTpOsoite.Text;
                string tpPtoimipaikka = txbTpPtoimipaikka.Text;
                string tpPostinro = txbTpPostinumero.Text;
                string tpSposti = txbTpSposti.Text;
                string tpPuhnro = txbTpPuhnro.Text;
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin tekstikenttiin!");
                }
                else
                {
                    string tpLisays = $"INSERT INTO Toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('{tpNimi}', '{tpOsoite}', '{tpPtoimipaikka}', '{tpPostinro}', '{tpSposti}', '{tpPuhnro}')";

                    S.Query(tpLisays);
                    DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                string tpNimi = txbTpNimi.Text;
                string tpOsoite = txbTpOsoite.Text;
                string tpPtoimipaikka = txbTpPtoimipaikka.Text;
                string tpPostinro = txbTpPostinumero.Text;
                string tpSposti = txbTpSposti.Text;
                string tpPuhnro = txbTpPuhnro.Text;
                string tpMuokkaus = $"UPDATE Toimipiste SET nimi = '{tpNimi}', lahiosoite = '{tpOsoite}', postitoimipaikka = '{tpPtoimipaikka}', postinro = '{tpPostinro}', email = '{tpSposti}', puhelinnro = '{tpPuhnro}' WHERE toimipiste_id = {valittuRivi}";

                S.Query(tpMuokkaus);
                DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");

                DgwToimipisteet.Enabled = true;
                perusTila();
            }

            S.Close();
        }

        private void BtnTpPeruuta_Click(object sender, EventArgs e)
        {
            perusTila();
        }

        private void perusTila()
        {
            // Tämän ajettaessa kaikki tekstikentät nollataan. Lisää, Muokkaa, ja Poista painikkeet käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = false;
            btnTpLisaa.Enabled = true;
            btnTpMuokkaa.Enabled = true;
            btnTpPoista.Enabled = true;
            btnTpTallenna.Enabled = false; ;
            btnTpPeruuta.Enabled = false; ;
            DgwToimipisteet.Enabled = true;
        }
        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            btnTpLisaa.Enabled = false;
            btnTpMuokkaa.Enabled = false;
            btnTpPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            DgwToimipisteet.Enabled = false;
        }
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnTpLisaa.Enabled = false;
            btnTpMuokkaa.Enabled = false;
            btnTpPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = DgwToimipisteet.CurrentCell.RowIndex;
            valittuRivi = DgwToimipisteet.Rows[rowIndex].Cells["Id"].Value.ToString();
            txbTpNimi.Text = DgwToimipisteet.Rows[rowIndex].Cells["Nimi"].Value.ToString();
            txbTpOsoite.Text = DgwToimipisteet.Rows[rowIndex].Cells["Osoite"].Value.ToString();
            txbTpPtoimipaikka.Text = DgwToimipisteet.Rows[rowIndex].Cells["paikkakunta"].Value.ToString();
            txbTpPostinumero.Text = DgwToimipisteet.Rows[rowIndex].Cells["Postinumero"].Value.ToString();
            txbTpSposti.Text = DgwToimipisteet.Rows[rowIndex].Cells["Sähköposti"].Value.ToString();
            txbTpPuhnro.Text = DgwToimipisteet.Rows[rowIndex].Cells["Puhelin"].Value.ToString();
            DgwToimipisteet.Enabled = false;
        }

        private void DgwToimipisteet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        /*
        private void BtnTpLisaa_Click(object sender, EventArgs e)
        {
            string tpNimi = txbTpNimi.Text;
            string tpOsoite = txbTpOsoite.Text;
            string pToimiPaikka = txbTpPtoimipaikka.Text;
            string postiNro = txbTpPostinumero.Text;
            string sPosti = txbTpSposti.Text;
            string puhNro = txbTpNumero.Text;
            // Yhdistetään kantaan ja lisätään Toimipiste-taulu dataGridViewiin.
            user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            SqlConnection sql;
            database = @"Data Source=" + server + ";Initial Catalog=" + dbname + ";User ID=sa;Password=Kissa123!";

            sql = new SqlConnection(database);
            sql.Open();
            da = new SqlDataAdapter("INSERT INTO Toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES" + "(" + tpNimi + ", " + txbTpOsoite + ", " + postiNro + ", " + sPosti + ", " + puhNro + ")", sql);
            da.Fill(ds, "Toimipiste");
            DgwToimipisteet.DataSource = ds;
            DgwToimipisteet.DataMember = "Toimipiste";

            sql.Close();
        }*/
    }
    }





