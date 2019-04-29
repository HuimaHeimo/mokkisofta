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
    public partial class Palvelut : Form
    {
        Sql S = new Sql();
        public Palvelut()
        {
            InitializeComponent();


            cboxPlvToimipiste.DropDownStyle = ComboBoxStyle.DropDownList;

            // Haetaan toimipisteet alasvetovalikkoon.
            S.Connect();
            //cboxPlvToimipiste = S.haeTaulustaLaatikkoon(S, cboxPlvToimipiste, "Toimipiste", "nimi", ""); // toimivuuden testaus
            S.Close();

            // Haetaan tietokannasta palvelut DataGridViewiin.
            S.Connect();
            dgwPalvelut.DataSource = S.ShowInGridView("SELECT palvelu_id AS Id, toimipiste_id AS Toimipiste, tyyppi AS Tyyppi, kuvaus AS Kuvaus, hinta AS Hinta, alv AS Arvonlisävero FROM Palvelu");
            S.Close();


        }

        private void palvelut_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnPlvLisää)
            {

            }
            else if (btn == btnPlvMuokkaa)
            {

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
    }
}
