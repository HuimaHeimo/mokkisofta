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
    public partial class Asiakkaat : Form
    {
        Sql sql = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        public Asiakkaat()
        {
            InitializeComponent();
            sql.Connect();
            dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
            sql.Close();

            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false); // Ohjelman käynnistyessä tekstikenttiin ei voi syöttää tietoa.
            btnTpTallenna.Enabled = false;
            btnTpPeruuta.Enabled = false;

        }

        private void BtnAsLisaa_Click(object sender, EventArgs e)
        {
            lisaysTila();

        }

        private void BtnAsPoista_Click(object sender, EventArgs e)
        {
            
            sql.Connect();
            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (dgwAsiakkaat.CurrentCell != null)
                {
                    int rowIndex = dgwAsiakkaat.CurrentCell.RowIndex;
                    string valittuId = dgwAsiakkaat.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string asPoisto = $"DELETE FROM Asiakas WHERE asiakas_id='{valittuId}'";

                    sql.Query(asPoisto);
                    dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
                    sql.Close();
                }
            }
            if (kysely == DialogResult.Cancel)
            {

            }                     
        }

        private void BtnAsMuokkaa_Click(object sender, EventArgs e)
        {
            muokkausTila();
        }

        private void perusTila()
        {
            // Tämän ajettaessa kaikki tekstikentät nollataan. Lisää, Muokkaa, ja Poista painikkeet käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = false);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = false;
            btnAsLisaa.Enabled = true;
            btnAsMuokkaa.Enabled = true;
            btnAsPoista.Enabled = true;
            btnTpTallenna.Enabled = false; ;
            btnTpPeruuta.Enabled = false; ;
            lblId.Text = "-";
            dgwAsiakkaat.Enabled = true;
        }
        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            btnAsLisaa.Enabled = false;
            btnAsMuokkaa.Enabled = false;
            btnAsPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            lblId.Text = "-";
            dgwAsiakkaat.Enabled = false;
        }
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnAsLisaa.Enabled = false;
            btnAsMuokkaa.Enabled = false;
            btnAsPoista.Enabled = false;
            btnTpTallenna.Enabled = true;
            btnTpPeruuta.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = dgwAsiakkaat.CurrentCell.RowIndex;
            lblId.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Id"].Value.ToString();
            txbAsEtunimi.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Etunimi"].Value.ToString();
            txbAsSukunimi.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Sukunimi"].Value.ToString();
            txbAsOsoite.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Lähiosoite"].Value.ToString();
            txbAsPtoimipaikka.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Paikkakunta"].Value.ToString();
            txbAsPostinumero.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Postinumero"].Value.ToString();
            txbAsSposti.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Sähköposti"].Value.ToString();
            txbAsPuhnro.Text = dgwAsiakkaat.Rows[rowIndex].Cells["Puhelin"].Value.ToString();
            //Otetaan datagridin käyttö pois muokkauksen ajaksi
            dgwAsiakkaat.Enabled = false;
        }

        private void BtnTpPeruuta_Click(object sender, EventArgs e)
        {
            perusTila();
        }

        private void BtnTpTallenna_Click(object sender, EventArgs e)
        {
            sql.Connect();
            if (btnLisaaPainettu == true)
            {
                string asEtunimi = txbAsEtunimi.Text;
                string asSukunimi = txbAsSukunimi.Text;
                string asOsoite = txbAsOsoite.Text;
                string asPtoimipaikka = txbAsPtoimipaikka.Text;
                string asPostinro = txbAsPtoimipaikka.Text;
                string asSposti = txbAsSposti.Text;
                string asPuhnro = txbAsPuhnro.Text;
                if(txbAsSposti.Text.Length == 0) //Mahdollisuus jättää sähköposti tyhjäksi ja lisätään viivat
                {
                    txbAsSposti.Text = "--";
                    asSposti = "--";
                }
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin tekstikenttiin!");
                }
                else
                {
                    string asLisays = $"INSERT INTO Asiakas (etunimi , sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('{asEtunimi}', '{asSukunimi}','{asOsoite}', '{asPtoimipaikka}', '{asPostinro}', '{asSposti}', '{asPuhnro}')";

                    sql.Query(asLisays);
                    dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                int rowIndex = dgwAsiakkaat.CurrentCell.RowIndex;
                string asEtunimi = txbAsEtunimi.Text;
                string asSukunimi = txbAsSukunimi.Text;
                string asOsoite = txbAsOsoite.Text;
                string asPtoimipaikka = txbAsPtoimipaikka.Text;
                string asPostinro = txbAsPostinumero.Text;
                string asSposti = txbAsSposti.Text;
                string asPuhnro = txbAsPuhnro.Text;
                string valittuId = lblId.Text;
                if (txbAsSposti.Text.Length == 0) //Mahdollisuus jättää sähköposti tyhjäksi ja lisätään viivat
                {
                    txbAsSposti.Text = "--";
                    asSposti = "--";
                }
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Syötä tiedot kaikkiin tekstikenttiin!");
                }
                else
                {
                    string asMuokkaus = $"UPDATE Asiakas SET etunimi = '{asEtunimi}', sukunimi = '{asSukunimi}', lahiosoite = '{asOsoite}', postitoimipaikka = '{asPtoimipaikka}', postinro = '{asPostinro}', email = '{asSposti}', puhelinnro = '{asPuhnro}' WHERE asiakas_id = {valittuId}";

                    sql.Query(asMuokkaus);
                    dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
                    sql.Close();
                    perusTila();
                }

            }
        }
    }
}
