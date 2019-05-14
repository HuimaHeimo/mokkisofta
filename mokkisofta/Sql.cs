using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mokkisofta
{
    public class Sql
    {

        // public string ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=vp;Integrated Security=SSPI";
        SqlConnection con;

        string connection;

        /// <summary>
        /// Muodostaa yhteyden tietokantaan.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="dataBaseName"></param>
        /// <param name="user"></param>


        public void Connect(string ConnectionString)
        {
            connection = ConnectionString;
            con = new SqlConnection(ConnectionString);
            con.Open();

        }

        /// <summary>
        /// Funktio testaa tietokantayhteyden parametrien toimivuuden.
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <returns></returns>
        public bool TestConnection(string ConnectionString)
        {
            
            connection = ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Katkaisee tietokantayhteyden.
        /// </summary>
        public void Close()
        {
            con.Close();
        }

        //Päivittää, hakee tai muokkaa kannan tietoja.
        public void Query(string QuerySql)
        {
            SqlCommand cmd = new SqlCommand(QuerySql, con);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Hakee kannasta tietoa, esimerkiksi tekstikenttiin.
        /// </summary>
        /// <param name="QuerySql"></param>
        /// <returns></returns>
        public SqlDataReader DataReader(string QuerySql)
        {
            SqlCommand cmd = new SqlCommand(QuerySql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        //Palauttaa lukuarvon määriä hakiessa esim (SELECT COUNT)
        public int Haelukumaara(string QuerySql)
        {
            SqlCommand cmd = new SqlCommand(QuerySql, con);
            Int32 luku = (Int32)cmd.ExecuteScalar();
            return luku;
        }

        public ComboBox haeTaulustaLaatikkoon(Sql S, ComboBox c, DataTable dt, string taulu, string kentta1, string kentta2, string kentta3 = "")
        {
            /* Palauttaa datatablen joka ottaa sql objektin ja datatablen lisäksi parametriksi: taulun nimen, sekä kaksi taulun kenttäarvoa. Esim. kentta1 = toimipaikka_id, kentta2 = toimipaikan nimi.
             * kentta3 on vaihtoehtoinen parametri jota tarvitsee Asiakkaiden nimen tulostamisessa (etunimi + sukunimi samaan comboboxiin)
             */
            SqlDataReader sqlReader;
            if (string.IsNullOrEmpty(kentta3))
            {
                string komento = $"SELECT {kentta1}, {kentta2} FROM {taulu}";
                sqlReader = S.DataReader(komento);
                dt.Load(sqlReader);
                c.DataSource = dt;
                c.ValueMember = kentta1;
                c.DisplayMember = kentta2;
                return c;
            }
            else
            {
                // Käyttäjän syöttäessä useamman kenttaparametrin; kentta2 ja kentta3 muodostavat Aliaksen KENTTA joka luetaan comboboxin nimeen.
                string komento = $"SELECT {kentta1}, {kentta2} + ' ' + {kentta3} as KENTTA FROM {taulu}";
                sqlReader = S.DataReader(komento);
                dt.Load(sqlReader);
                c.DataSource = dt;
                c.ValueMember = kentta1;
                c.DisplayMember = "KENTTA";
                return c;
            }
        }
        public ComboBox haeVarauksenAsiakas(Sql S, ComboBox a, ComboBox c, DataTable dt, string taulu, string kentta1)
        {
            /* Palauttaa datatablen joka sisältää varauksen tekevän asiakkaan id arvon ja nimen. 
             * Asiakkaan koko nimi tulostetaan comboboxiin ja valuememberinä on asiakkaan id arvo.
             */
            SqlDataReader sqlReader;
            string komento = $"SELECT {kentta1} as id, Asiakas.etunimi + ' ' + Asiakas.sukunimi AS KENTTA FROM {taulu} INNER JOIN Varaus ON Varaus.asiakas_id = Asiakas.asiakas_id  WHERE {a.SelectedValue} = Varaus.varaus_id";
            sqlReader = S.DataReader(komento);
            dt.Load(sqlReader);
            c.DataSource = dt;
            c.ValueMember = "id";
            c.DisplayMember = "KENTTA";
            return c;
            
        }
        public ComboBox haeVarauksenPalvelut(Sql S, ComboBox c, DataTable dt, string taulu, string kentta1, string kentta2, string kentta3)
        {
            SqlDataReader sqlReader;
            string komento = $"SELECT {kentta1}, {kentta2} FROM {taulu} WHERE toimipiste_id = '{kentta3}'";
            sqlReader = S.DataReader(komento);
            dt.Load(sqlReader);
            c.DataSource = dt;
            c.ValueMember = kentta1;
            c.DisplayMember = kentta2;
            return c;
        }


        /// <summary>
        /// Hakee kannasta tietoa datagridviewiin.
        /// </summary>
        /// <param name="QuerySql"></param>
        /// <returns></returns>
        public object ShowInGridView(string QuerySql)
        {
            SqlDataAdapter dr = new SqlDataAdapter(QuerySql, connection);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }



    }
}