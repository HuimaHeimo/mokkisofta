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
// test
namespace mokkisofta
{
    public partial class Toimipisteet : Form
    {
        public Toimipisteet(string database, string server, string dbname, string user)
        {
            InitializeComponent();

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


        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void Connect()
        {

        }

        private void Toimipisteet_Load(object sender, EventArgs e)
        {

        }
    }


}


