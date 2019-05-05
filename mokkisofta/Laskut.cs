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
    public partial class Laskut : Form
    {
        Sql S = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        private string valittuRivi = "";
        /* SQL hakulause tietojen hakemiseen datagridiin. Hakee Asiakas taulusta etunimen ja sukunimen ja tulostaa ne Asiakas_id sijasta.
        * 
        */
        private string dgSqlHakulause = "SELECT lasku_id AS 'Id', varaus_id AS 'Varaus', Asiakas.etunimi + ' ' + Asiakas.sukunimi AS 'Asiakas', nimi as 'Laskun maksaja', Lasku.lahiosoite AS 'Lähiosoite', Lasku.postitoimipaikka AS 'Postitoimipaikka', " +
            "Lasku.postinro AS 'Postinumero', summa AS 'Summa', alv AS 'Alv' " +
            "FROM Lasku INNER JOIN Asiakas ON Lasku.asiakas_id = Asiakas.asiakas_id";
        public Laskut()
        {
            InitializeComponent();
            S.Connect();
            dgwLaskut.DataSource = S.ShowInGridView(dgSqlHakulause);
            DataTable varaukset = new DataTable();
            DataTable asiakkaat = new DataTable();
            cboxLasVaraus = S.haeTaulustaLaatikkoon(S, cboxLasVaraus, varaukset, "Varaus", "varaus_id", "varaus_id");
            cboxLasAsiakas = S.haeTaulustaLaatikkoon(S, cboxLasAsiakas, asiakkaat, "Asiakas", "asiakas_id", "etunimi", "sukunimi");
            S.Close();
            perusTila();
        }

        private void BtnLasTallenna_Click(object sender, EventArgs e)
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
                    string lasVaraus = cboxLasVaraus.SelectedValue.ToString();
                    string lasAsiakas = cboxLasAsiakas.SelectedValue.ToString();
                    string lasNimi = txbLasNimi.Text;
                    string lasOsoite = txbLasOsoite.Text;
                    string lasPostitoimipaikka = txbLasPostitoimipaikka.Text;
                    string lasPostinro = txbLasPostinro.Text;
                    double lasSumma = double.Parse(txbLasSumma.Text);
                    double lasAlv = double.Parse(txbLasAlv.Text);
                    string lasLisays = $"INSERT INTO Lasku (varaus_id, asiakas_id, nimi, lahiosoite, postitoimipaikka, postinro, summa, alv) " +
                        $"VALUES ('{lasVaraus}', '{lasAsiakas}', '{lasNimi}', '{lasOsoite}', '{lasPostitoimipaikka}', '{lasPostinro}', '{lasSumma}', '{lasAlv}')";

                    S.Query(lasLisays);
                    dgwLaskut.DataSource = S.ShowInGridView(dgSqlHakulause);
                    perusTila();
                }
            }
            else if (btnMuokkaaPainettu == true)
            {
                // muokkaustoiminnallisuus (Valitun datagrid rivin tietojen siirtäminen tekstikenttiin, ja niiden muokkaustoiminnallisuus.)
                string lasVaraus = cboxLasVaraus.SelectedValue.ToString();
                string lasAsiakas = cboxLasAsiakas.SelectedValue.ToString();
                string lasNimi = txbLasNimi.Text;
                string lasOsoite = txbLasOsoite.Text;
                string lasPostitoimipaikka = txbLasPostitoimipaikka.Text;
                string lasPostinro = txbLasPostinro.Text;
                double lasSumma = double.Parse(txbLasSumma.Text);
                double lasAlv = double.Parse(txbLasAlv.Text);
                string lasMuokkaus = $"UPDATE Lasku SET varaus_id = '{lasVaraus}', asiakas_id = '{lasAsiakas}', nimi = '{lasNimi}', lahiosoite = '{lasOsoite}', " +
                    $"postitoimipaikka = '{lasPostitoimipaikka}', postinro = '{lasPostinro}', summa = '{lasSumma}', alv = '{lasAlv}' WHERE lasku_id = {valittuRivi}";

                S.Query(lasMuokkaus);
                dgwLaskut.DataSource = S.ShowInGridView(dgSqlHakulause);
                perusTila();
            }

            S.Close();
        }
        private void btnLasPoista_Click(object sender, EventArgs e)
        {
            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (dgwLaskut.CurrentCell != null)
                {
                    S.Connect();
                    int rowIndex = dgwLaskut.CurrentCell.RowIndex;
                    string valittuId = dgwLaskut.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string lasPoisto = $"DELETE FROM Laskut WHERE lasku_id='{valittuId}'";

                    S.Query(lasPoisto);
                    dgwLaskut.DataSource = S.ShowInGridView(dgSqlHakulause);
                    S.Close();
                }
            }
            if (kysely == DialogResult.Cancel)
            {

            }
        }

        private void btnLasMuokkaa_Click(object sender, EventArgs e)
        {
            muokkausTila();
        }
        private void btnLasLisää_Click(object sender, EventArgs e)
        {
            lisaysTila();
        }
        private void BtnLasPeruuta_Click(object sender, EventArgs e)
        {
            perusTila();
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
            btnLasLisaa.Enabled = true;
            btnLasMuokkaa.Enabled = true;
            btnLasPoista.Enabled = true;
            btnLasTallenna.Enabled = false; ;
            btnLasPeruuta.Enabled = false; ;
            dgwLaskut.Enabled = true;
        }
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnLasLisaa.Enabled = false;
            btnLasMuokkaa.Enabled = false;
            btnLasPoista.Enabled = false;
            btnLasTallenna.Enabled = true;
            btnLasPeruuta.Enabled = true;
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = dgwLaskut.CurrentCell.RowIndex;
            valittuRivi = dgwLaskut.Rows[rowIndex].Cells["Id"].Value.ToString();
            cboxLasVaraus.Text = dgwLaskut.Rows[rowIndex].Cells["Varaus"].Value.ToString();
            cboxLasAsiakas.Text = dgwLaskut.Rows[rowIndex].Cells["Asiakas"].Value.ToString();
            txbLasNimi.Text = dgwLaskut.Rows[rowIndex].Cells["Laskun maksaja"].Value.ToString();
            txbLasOsoite.Text = dgwLaskut.Rows[rowIndex].Cells["Lähiosoite"].Value.ToString();
            txbLasPostitoimipaikka.Text = dgwLaskut.Rows[rowIndex].Cells["Postitoimipaikka"].Value.ToString();
            txbLasPostinro.Text = dgwLaskut.Rows[rowIndex].Cells["Postinumero"].Value.ToString();
            txbLasSumma.Text = dgwLaskut.Rows[rowIndex].Cells["Summa"].Value.ToString();
            txbLasAlv.Text = dgwLaskut.Rows[rowIndex].Cells["Alv"].Value.ToString();
            //Otetaan datagridin käyttö pois muokkauksen ajaksi
            dgwLaskut.Enabled = false;
        }


        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.Enabled = true);
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            btnLasLisaa.Enabled = false;
            btnLasMuokkaa.Enabled = false;
            btnLasPoista.Enabled = false;
            btnLasTallenna.Enabled = true;
            btnLasPeruuta.Enabled = true;
            dgwLaskut.Enabled = false;
        }

        private void TxbLasPostinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxbLasSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxbLasAlv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
