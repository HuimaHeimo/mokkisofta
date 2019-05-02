using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                dtpRptAlku.CustomFormat = "yyyyMMdd";
                dtpRptLoppu.CustomFormat = "yyyyMMdd";
                dgwRaportit.DataSource = s.ShowInGridView("SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                "FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id");
                int i = 0;
                int ts = (int) dtpRptLoppu.Value.ToOADate() - (int) dtpRptAlku.Value.ToOADate();

                for (; ts > 0; ts--)
                {                   
                    int varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus WHERE varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    int asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus WHERE varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series["Varaukset"].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    chrRptChart1.Series["Asiakkaat"].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    i++;                    
                }
                
                s.Close();
            }
        }


    }
}

        