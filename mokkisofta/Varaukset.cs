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

            // Muutetaan DataGridView sellaiseksi, ettei yksittäisiä soluja pysty valitsemaan. Aina aktivoidaan koko rivi.
            DgwVaraukset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Lisätään comboboxiin asiakas-taulun asiakkaat.
            S.Connect();
            DataTable dt = new DataTable();
            cboxVarAsiakas = S.haeTaulustaLaatikkoon(S, cboxVarAsiakas, dt, "Asiakas", "asiakas_id", "etunimi", "sukunimi");   
            S.Close();


        }


    }
}
