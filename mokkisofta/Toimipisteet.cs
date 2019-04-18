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
        public Toimipisteet()
        {
            InitializeComponent();

            Sql S = new Sql();

            S.Connect();
            DgwToimipisteet.DataSource = S.ShowInGridView("Select toimipiste_id as Id, nimi as Nimi, lahiosoite as Osoite, postitoimipaikka as paikkakunta, postinro as Postinumero, email as Sähköposti, puhelinnro as Puhelin from Toimipiste");
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
            Sql S = new Sql();

            S.Connect();

            string tpNimi = txbTpNimi.Text;
            string tpOsoite = txbTpOsoite.Text;
            string tpPtoimipaikka = txbTpPtoimipaikka.Text;
            string tpPostinro = txbTpPostinumero.Text;
            string tpSposti = txbTpSposti.Text;
            string tpPuhnro = txbTpPuhnro.Text;

            string tpLisays = $"INSERT INTO Toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('{tpNimi}', '{tpOsoite}', '{tpPtoimipaikka}', '{tpPostinro}', '{tpSposti}', '{tpPuhnro}')";
            
            S.Query(tpLisays);
            DgwToimipisteet.DataSource = S.ShowInGridView("Select toimipiste_id as Id, nimi as Nimi, lahiosoite as Osoite, postitoimipaikka as paikkakunta, postinro as Postinumero, email as Sähköposti, puhelinnro as Puhelin from Toimipiste");
            S.Close();
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





