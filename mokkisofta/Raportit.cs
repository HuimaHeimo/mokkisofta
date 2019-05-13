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
            dtpRptAlku.Value = DateTime.Now;
            dtpRptLoppu.Value = DateTime.Now;

        }
        private void RdbRptRajaatoimipisteeseen_CheckedChanged(object sender, EventArgs e)
        {
            //Jos raporttiin halutaan rajata vain tietty toimipiste
            if (rdbRptRajaatoimipisteeseen.Checked)
            {
                cbxRptToimipiste.Enabled = true;
                s.Connect();
                DataTable toimipisteet = new DataTable();
                cbxRptToimipiste = s.haeTaulustaLaatikkoon(s, cbxRptToimipiste, toimipisteet, "Toimipiste", "toimipiste_id", "nimi");
                s.Close();
            }
            else
            {
                cbxRptToimipiste.Enabled = false;
                cbxRptToimipiste.Text = "Kaikki";
            }
        }
        //Jos raporttiin halutaan rajata vain tietty palvelu
        private void RdbRajaaPalvelu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRajaaPalvelu.Checked)
            {

                cbxRptPalvelut.Enabled = true;          //Rajataan palvelu nimen mukaan valittavaksi ja
                s.Connect();                            //poistetaan saman nimiset palvelut listasta
                DataTable palvelut = new DataTable();
                string komento = "SELECT DISTINCT nimi FROM Palvelu";
                palvelut.Load(s.DataReader(komento));
                cbxRptPalvelut.DataSource = palvelut;
                cbxRptPalvelut.ValueMember = "nimi";
                cbxRptPalvelut.DisplayMember = "nimi";
                s.Close();
            }

            else
            {
                cbxRptPalvelut.Enabled = false;
                cbxRptPalvelut.Text = "Kaikki";
            }

        }

        //Jos raporttiin halutaan rajata vain tietty asiakas
        private void RdbRajaaAsiakas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRajaaAsiakas.Checked)
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


        private void BtnRptHae_Click(object sender, EventArgs e)
        {
            dgwRaportit.DataSource = null;
            chrRptChart1.Series.Clear();
            chrRptChart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chrRptChart1.ChartAreas[0].AxisX.LabelStyle.Angle = 30;
            chrRptChart1.Series.Add("Varaukset");
            chrRptChart1.Series.Add("Asiakkaat");
            chrRptChart1.Series.Add("Palvelut");
            int varausmaara = 0;
            int asiakasmaara = 0;
            int palvelumaara = 0;


            s.Connect();
            dtpRptAlku.CustomFormat = "yyyyMMdd";
            dtpRptLoppu.CustomFormat = "yyyyMMdd";
            int i = 0;
            int ts = (int)dtpRptLoppu.Value.ToOADate() - (int)dtpRptAlku.Value.ToOADate();
            //Raportin haku niin että rajauksia ei ole tehty
            if (rdbRptRajaatoimipisteeseen.Checked == false && rdbRajaaPalvelu.Checked == false && rdbRajaaAsiakas.Checked == false)
            {
                dgwRaportit.DataSource = s.ShowInGridView("SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE Varaus.varattu_pvm BETWEEN '{dtpRptAlku.Value.ToString("yyyyMMdd")}' AND '{dtpRptLoppu.Value.ToString("yyyyMMdd")}'");
                for (; ts >= 0; ts--)
                {

                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus WHERE varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus WHERE varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    palvelumaara = s.Haelukumaara($"SELECT COUNT(varauksen_palvelut_id) FROM Varauksen_palvelut INNER JOIN Varaus ON Varaus.varaus_id = Varauksen_palvelut.varauksen_palvelut_id WHERE Varaus.varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[0].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    chrRptChart1.Series[1].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    chrRptChart1.Series[2].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), palvelumaara);
                    i++;
                }
            }
            //Raportin haku toimipiste rajattuu tiettyyn toimipisteeseen
            if (rdbRptRajaatoimipisteeseen.Checked)
            {
                dgwRaportit.DataSource = s.ShowInGridView($"SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE (Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}') AND Varaus.varattu_pvm BETWEEN '{dtpRptAlku.Value.ToString("yyyyMMdd")}' AND '{dtpRptLoppu.Value.ToString("yyyyMMdd")}'");
                for (; ts > 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE (Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}') AND Varaus.varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");
                    asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}' AND Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}'");
                    chrRptChart1.Series[0].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    chrRptChart1.Series[1].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    i++;                   
                }

            }
            //Raportin haku palvelu rajattu tietyn nimiseen palveluun
            if (rdbRajaaPalvelu.Checked)
            {

            }
            //Raportin haku asiakas rajattu tiettyyn asiakkaaseen
            if (rdbRajaaAsiakas.Checked)
            {
                chrRptChart1.DataSource = null;
                dgwRaportit.DataSource = s.ShowInGridView($"SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE Asiakas.etunimi + ' ' + Asiakas.sukunimi = '{cbxRptAsiakkaat.Text.ToString()}' AND Varaus.varattu_pvm BETWEEN '{dtpRptAlku.Value.ToString("yyyyMMdd")}' AND '{dtpRptLoppu.Value.ToString("yyyyMMdd")}'");
                for (; ts > 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id WHERE Asiakas.etunimi + ' ' + Asiakas.sukunimi = '{cbxRptAsiakkaat.Text.ToString()}' AND Varaus.varattu_pvm = '{dtpRptAlku.Value.AddDays(i).ToString("yyyyMMdd")}'");

                    chrRptChart1.Series[0].Points.AddXY(dtpRptAlku.Value.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    i++;
                }

            }
            s.Close();

        }
        //Hakujen nollaus
        private void BtnRptTyhjenna_Click(object sender, EventArgs e)
        {
            dgwRaportit.DataSource = null;
            chrRptChart1.Series.Clear();
            cbxRptToimipiste.Enabled = false;
            cbxRptToimipiste.Text = "Kaikki";
            cbxRptPalvelut.Enabled = false;
            cbxRptPalvelut.Text = "Kaikki";
            cbxRptAsiakkaat.Enabled = false;
            cbxRptAsiakkaat.Text = "Kaikki";
            rdbRptRajaatoimipisteeseen.Checked = false;
            rdbRajaaPalvelu.Checked = false;
            rdbRajaaAsiakas.Checked = false;
            dtpRptAlku.Value = DateTime.Now;
            dtpRptLoppu.Value = DateTime.Now;
        }


    }


        }


    


        