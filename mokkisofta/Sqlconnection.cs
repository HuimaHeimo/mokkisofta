using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace mokkisofta
{
    class Sqlconnection
    {
        public static void Connect(string database, string server, string dataBaseName, string user)
        {
            user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            SqlConnection sql;
            database = @"Data Source=" + server + ";Initial Catalog=" + dataBaseName + ";User ID=sa;Password=Kissa123!";

            sql = new SqlConnection(database);
            sql.Open();

            MessageBox.Show("Yhteys muodostettu");

            sql.Close();
        }


    }
}
