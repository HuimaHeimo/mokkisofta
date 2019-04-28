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
            SqlCommand cmd = new SqlCommand(QuerySql,con);
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

        public ComboBox haeTaulustaLaatikkoon(Sql S, ComboBox c, string taulu, string kentta, string kentta2 = "")
        {
            /* Funktio tietojen lukemiseen comboboxiin halutusta taulusta.
                * Tällä hetkellä palauttaa comboboxin, eli korvaa nykyisen comboboxin uudella joka sisältää arvot. 
                *  esim. cboxVarAsiakas = S.haeTaulustaLaatikkoon(S, cboxVarAsiakas, "Asiakas", "etunimi", "sukunimi");
                */
            string komento = $"SELECT * FROM {taulu}";
            SqlDataReader sqlReader = S.DataReader(komento);
            if (string.IsNullOrEmpty(kentta2))
            {

                while (sqlReader.Read())
                {
                    c.Items.Add(sqlReader[kentta].ToString());
                }
            }
            else
            {
                while (sqlReader.Read())
                {
                    c.Items.Add(sqlReader[kentta].ToString() + " " + sqlReader[kentta2].ToString());
                }
            }

            sqlReader.Close();
            return c;
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


    }
}
