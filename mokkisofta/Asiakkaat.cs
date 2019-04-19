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
        public Asiakkaat()
        {
            InitializeComponent();
            sql.Connect();
            dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
            sql.Close();

        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAsLisää_Click(object sender, EventArgs e)
        {

            sql.Connect();
            string asEtunimi = txbAsEtunimi.Text;
            string asSukunimi = txbAsSukunimi.Text;
            string asOsoite = txbAsOsoite.Text;
            string asPNro = txbAsPostinumero.Text;
            string asPtoimipaikka = txbAsPtoimipaikka.Text;
            string asSPosti = txbAsSposti.Text;
            string asPuhNro = txbAsPuhnro.Text;

            string asLisays = $"INSERT INTO Asiakas (etunimi, sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('{asEtunimi}', '{asSukunimi}', '{asOsoite}' , '{asPtoimipaikka}', '{asPNro}', '{asSPosti}', '{asPuhNro}')";
            sql.Query(asLisays);
            dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");

            sql.Close();
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

        }

        private void DgwAsiakkaat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            sql.Connect();
            int rowIndex = dgwAsiakkaat.CurrentCell.RowIndex;
            string asEtunimi = dgwAsiakkaat.Rows[rowIndex].Cells["Etunimi"].Value.ToString();
            string asSukunimi = dgwAsiakkaat.Rows[rowIndex].Cells["Sukunimi"].Value.ToString();
            string asOsoite = dgwAsiakkaat.Rows[rowIndex].Cells["Lähiosoite"].Value.ToString();
            string asPNro = dgwAsiakkaat.Rows[rowIndex].Cells["Paikkakunta"].Value.ToString();
            string asPtoimipaikka = dgwAsiakkaat.Rows[rowIndex].Cells["Postinumero"].Value.ToString();
            string asSPosti = dgwAsiakkaat.Rows[rowIndex].Cells["Sähköposti"].Value.ToString();
            string asPuhNro = dgwAsiakkaat.Rows[rowIndex].Cells["Puhelin"].Value.ToString();
            string valittuId = dgwAsiakkaat.Rows[rowIndex].Cells["Id"].Value.ToString();
            string asMuokkaus = $"UPDATE Asiakas SET etunimi = '{asEtunimi}', sukunimi = '{asSukunimi}', lahiosoite = '{asOsoite}', postitoimipaikka = '{asPtoimipaikka}', postinro = '{asPNro}', email = '{asSPosti}', puhelinnro = '{asPuhNro}' WHERE asiakas_id = {valittuId}";

            sql.Query(asMuokkaus);
            dgwAsiakkaat.DataSource = sql.ShowInGridView("SELECT asiakas_id AS Id, etunimi AS Etunimi, sukunimi AS Sukunimi, lahiosoite AS Lähiosoite, postitoimipaikka AS Paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Asiakas");
            sql.Close();
        }
    }
}
