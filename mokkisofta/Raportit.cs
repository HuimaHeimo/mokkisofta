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
    public partial class Raportit : Form
    {
        Sql s = new Sql();
        public Raportit()
        {
            InitializeComponent();
        }

        private void ChbRptSisallytaToimip_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRptSisallytaToimip.Checked)
            {
                cbxRptToimipiste.Enabled = true;
                s.Connect();
                DataTable toimipisteet = new DataTable();
                cbxRptToimipiste = s.haeTaulustaLaatikkoon(s, cbxRptToimipiste, toimipisteet, "Toimipiste", "nimi", "toimipiste_id");
                s.Close();
            }
            else
            {
                cbxRptToimipiste.Enabled = false;
                cbxRptToimipiste.Text = "Kaikki";
            }
        }

        private void ChbRptsisallytaAsiakas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRptSisallytaAsiakas.Checked)
            {
                cbxRptAsiakkaat.Enabled = true;
                s.Connect();
                DataTable asiakkaat = new DataTable();
                cbxRptAsiakkaat = s.haeTaulustaLaatikkoon(s, cbxRptAsiakkaat, asiakkaat, "Asiakas", "asiakas_id", "etunimi", "sukunimi");
                s.Close();
            }
            else
            {
                cbxRptAsiakkaat.Enabled = false;
                cbxRptAsiakkaat.Text = "Kaikki";
            }
        }

        private void ChbRptSisallytaPalvelu_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRptSisallytaPalvelu.Checked)
            {
                cbxRptPalvelut.Enabled = true;
                s.Connect();
                DataTable palvelut = new DataTable();
                cbxRptPalvelut = s.haeTaulustaLaatikkoon(s, cbxRptPalvelut, palvelut, "Palvelu", "palvelu_id", "nimi");
                s.Close();
            }
            else
            {
                cbxRptPalvelut.Enabled = false;
                cbxRptPalvelut.Text = "Kaikki";
            }


        }

        private void BtnRptHae_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<CheckBox>().Any(t => !checked(t.Checked)))
            {

                s.Connect();
                dgwRaportit.DataSource = s.ShowInGridView("SELECT varaus_id AS 'Id', Asiakas.etunimi as 'Etunimi', Asiakas.sukunimi as 'Sukunimi', Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varattu pvm', " +
            "vahvistus_pvm AS 'Vahvistus pvm', varattu_alkupvm AS 'Varauksen alkupvm', varattu_loppupvm AS 'Varauksen loppupvm' " +
            "FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id");
                int varausmaara = s.Haelukumaara("SELECT COUNT(varaus_id) FROM Varaus");
                int asiakasmaara = s.Haelukumaara("SELECT COUNT(DISTINCT asiakas_id) FROM Varaus");
                

                chrRptChart1.Series["Varaukset"].Points.AddXY(dtpRptAlku.Value.ToString(), varausmaara);
                chrRptChart1.Series["Asiakkaat"].Points.AddXY(dtpRptAlku.Value.ToString(), asiakasmaara);
                
                s.Close();
            }
        }

        private void ChrRptChart1_Click(object sender, EventArgs e)
        {

        }
    }
}

        