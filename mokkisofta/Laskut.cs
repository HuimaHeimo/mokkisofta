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
        Sql sql = new Sql();
        private bool btnLisaaPainettu = false;
        private bool btnMuokkaaPainettu = false;
        public Laskut()
        {
            InitializeComponent();
            sql.Connect();
            dgwLaskut.DataSource = sql.ShowInGridView("SELECT lasku_id AS Lasku, varaus_id AS Varaus, asiakas_id AS Asiakas, nimi AS Nimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Postitoimipaikka, postinro AS Postinumero, summa AS Summa, alv AS Alv FROM Lasku");
            sql.Close();
        }

        private void btnLasPoista_Click(object sender, EventArgs e)
        {


            DialogResult kysely = MessageBox.Show("Haluatko varmasti poistaa valitun rivin?", "Poistetaanko?", MessageBoxButtons.OKCancel);
            if (kysely == DialogResult.OK)
            {
                if (dgwLaskut.CurrentCell != null)
                {
                    sql.Connect();
                    int rowIndex = dgwLaskut.CurrentCell.RowIndex;
                    string valittuId = dgwLaskut.Rows[rowIndex].Cells["Id"].Value.ToString();
                    string asPoisto = $"DELETE FROM Laskut WHERE lasku_id='{valittuId}'";

                    sql.Query(asPoisto);
                    dgwLaskut.DataSource = sql.ShowInGridView("SELECT lasku_id AS Lasku, varaus_id AS Varaus, asiakas_id AS Asiakas, nimi AS Nimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Postitoimipaikka, postinro AS Postinumero, summa AS Summa, alv AS Alv FROM Lasku");
                    sql.Close();
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
        private void muokkausTila()
        {
            // Sama kuin lisaysTila() , erona btnMuokkaaPainettu <-> btnLisaaPainettu totuusarvot.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = false;
            btnMuokkaaPainettu = true;
            btnLasLisää.Enabled = false;
            btnLasMuokkaa.Enabled = false;
            btnLasPoista.Enabled = false;
            //Lisätään valitun rivin tiedot tekstikenntiin
            int rowIndex = dgwLaskut.CurrentCell.RowIndex;
            txbLasNumero.Text = dgwLaskut.Rows[rowIndex].Cells["Numero"].Value.ToString();
            cboxLasVaraus.Text = dgwLaskut.Rows[rowIndex].Cells["Varaus"].Value.ToString();
            cboxLasAsiakas.Text = dgwLaskut.Rows[rowIndex].Cells["Asiakas"].Value.ToString();
            txbLasNimi.Text = dgwLaskut.Rows[rowIndex].Cells["Nimi"].Value.ToString();
            txbLasOsoite.Text = dgwLaskut.Rows[rowIndex].Cells["Lähiosoite"].Value.ToString();
            txbLasPostitoimipaikka.Text = dgwLaskut.Rows[rowIndex].Cells["Postitoimipaikka"].Value.ToString();
            txbLasPostinro.Text = dgwLaskut.Rows[rowIndex].Cells["Postinumero"].Value.ToString();
            txbLasSumma.Text = dgwLaskut.Rows[rowIndex].Cells["Summa"].Value.ToString();
            txbLasAlv.Text = dgwLaskut.Rows[rowIndex].Cells["Alv"].Value.ToString();
            //Otetaan datagridin käyttö pois muokkauksen ajaksi
            dgwLaskut.Enabled = false;
        }

        private void btnLasLisää_Click(object sender, EventArgs e)
        {
            lisaysTila();
        }
        private void lisaysTila()
        {
            // Siirrytään painamalla lisää nappia. Tekstikenttiin pystyy syöttämään tietoa. Vain Tallenna ja Peruuta painikkeet ovat käytössä.
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Enabled = true);
            btnLisaaPainettu = true;
            dgwLaskut.Enabled = false;
        }
        private void laskut_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Jos painetaan Lisää-painiketta, kentissä olevat tiedot viedään tietokantaan.
            if (btn == btnLasLisää)
            {
                sql.Connect();

                double pNumero = double.Parse(txbLasNumero.Text);
                string pVaraus = cboxLasVaraus.Text;
                string pAsiakas = cboxLasAsiakas.Text;
                string pNimi = txbLasNimi.Text;
                string pLahiosoite = txbLasOsoite.Text;
                string pPostitoimipaikka = txbLasPostitoimipaikka.Text;
                string pPostinumero = txbLasPostinro.Text;
                string pSumma = txbLasSumma.Text;
                double pAlv = double.Parse(txbLasAlv.Text);


                string pLisays = $"INSERT INTO Lasku (numero, varaus, asiakas, nimi, lahiosoite, postitoimipaikka, postinro, summa, alv) VALUES ('{pNumero}','{pVaraus}', '{pAsiakas}', '{pNimi}', '{pLahiosoite}', '{pPostitoimipaikka}', '{pPostinumero}', '{pSumma}', '{pAlv}')";
                sql.Query(pLisays);
                dgwLaskut.DataSource = sql.ShowInGridView("SELECT lasku_id AS Lasku, varaus_id AS Varaus, asiakas_id AS Asiakas, nimi AS Nimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Postitoimipaikka, postinro AS Postinumero, summa AS Summa, alv AS Alv FROM Lasku");


                sql.Close();
            }
        }
    }
}
