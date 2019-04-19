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
        public Toimipisteet()
        {
            InitializeComponent();

            S.Connect();
            DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
            S.Close();

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
            S.Connect();

            string tpNimi = txbTpNimi.Text;
            string tpOsoite = txbTpOsoite.Text;
            string tpPtoimipaikka = txbTpPtoimipaikka.Text;
            string tpPostinro = txbTpPostinumero.Text;
            string tpSposti = txbTpSposti.Text;
            string tpPuhnro = txbTpPuhnro.Text;

            string tpLisays = $"INSERT INTO Toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('{tpNimi}', '{tpOsoite}', '{tpPtoimipaikka}', '{tpPostinro}', '{tpSposti}', '{tpPuhnro}')";
            
            S.Query(tpLisays);
            DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
            S.Close();
        }

        private void BtnTpPoista_Click(object sender, EventArgs e)
        {
 
            S.Connect();
            if (DgwToimipisteet.CurrentCell != null)
            {
                int rowIndex = DgwToimipisteet.CurrentCell.RowIndex;
                string valittuRivi = DgwToimipisteet.Rows[rowIndex].Cells["Id"].Value.ToString();
                string tpPoisto = $"DELETE FROM Toimipiste WHERE toimipiste_id='{valittuRivi}'";

                S.Query(tpPoisto);
                DgwToimipisteet.DataSource = S.ShowInGridView("SELECT toimipiste_id AS Id, nimi AS Nimi, lahiosoite AS Osoite, postitoimipaikka AS paikkakunta, postinro AS Postinumero, email AS Sähköposti, puhelinnro AS Puhelin FROM Toimipiste");
                S.Close();
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





