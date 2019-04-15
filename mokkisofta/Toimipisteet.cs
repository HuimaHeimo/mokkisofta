﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// test
namespace mokkisofta
{
    public partial class Toimipisteet : Form
    {
        public Toimipisteet(string database, string server, string dbname, string user)
        {
            InitializeComponent();

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
        }

        // Luodaan dataset ja sqldataAdapter tietokantayhteyttä varten.
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        

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
        }
    }
    }


}


