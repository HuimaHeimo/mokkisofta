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
    public partial class Varaukset : Form
    {
        Sql S = new Sql();
        public Varaukset()
        {
            InitializeComponent();

            S.Connect();
            //DgwVaraukset.DataSource = S.ShowInGridView("SELECT varaus_id AS Id, asiakas_id AS Nimi, toimipiste_id AS Toimipiste, varattu_pvm AS Varattu pvm, vahvistus_pvm AS Vahvistus pvm, varattu_alkupvm AS Varauksen alkupvm, varattu_loppupvm AS Varauksen loppupvm FROM Varaus");
            //cboxVarAsiakas = S.haeTaulustaLaatikkoon(S, cboxVarAsiakas, "Asiakas", "etunimi", "sukunimi"); // toimivuuden testaus
            DataTable dt = new DataTable();
            dt = S.haeTaulustaLaatikkoon(S, dt, "Asiakas", "asiakas_id", "etunimi");
            cboxVarAsiakas.DataSource = dt;
            cboxVarAsiakas.ValueMember = "asiakas_id";
            cboxVarAsiakas.DisplayMember = "etunimi";
            
            S.Close();


        }


    }
}
