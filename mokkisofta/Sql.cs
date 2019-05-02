using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace mokkisofta
{
    public class Sql
    {

        public string ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=vp;User ID=sa;Password=Kissa123!";
        SqlConnection con;

        /// <summary>
        /// Muodostaa yhteyden tietokantaan.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="dataBaseName"></param>
        /// <param name="user"></param>
        public void Connect()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();

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
                c.DisplayMember = kentta1;
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

        /// <summary>
        /// Hakee kannasta tietoa datagridviewiin.
        /// </summary>
        /// <param name="QuerySql"></param>
        /// <returns></returns>
        public object ShowInGridView(string QuerySql)
        {
            SqlDataAdapter dr = new SqlDataAdapter(QuerySql, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        /// <summary>
        /// Määrittää tietokantayhteysosoitteen.
        /// </summary>
        /// <param name="ConnectionString"></param>
        public void SetConnectionString(string ConnectionString)
        {


        }

        public void AddToDropdownMenu()
        {

        }

    }
}