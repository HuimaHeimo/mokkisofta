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
        // Luodaan muuttuja päävalikosta tuotua yhdistämislausetta varten.
        string connectionString;

        Sql s = new Sql();
        public Raportit(string connection)
        {
            InitializeComponent();

            // Tuodaan pääikkunassa muodostettu tietokantalause formille käytettäväksi.
            connectionString = connection;
            dtpRptAlku.Value = DateTime.Now;
            dtpRptLoppu.Value = DateTime.Now;
            // Muutetaan DataGridView sellaiseksi, ettei yksittäisiä soluja pysty valitsemaan. Aina aktivoidaan koko rivi.
            dgwRaportit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estetään käyttäjää lisäämästä suoraan DataGridViewiin rivejä.
            dgwRaportit.AllowUserToAddRows = false;

            // Estetään DataGridViewin sisältöjen muokkaus.
            dgwRaportit.ReadOnly = true;

            // Tehdään Comboboxeista alasvetovalikko, johon ei voi kirjoittaa.
            cbxRptToimipiste.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRptPalvelut.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRptAsiakkaat.DropDownStyle = ComboBoxStyle.DropDownList;

            // Estetään DataGridViewin sisältöjen muokkaus.
            dgwRaportit.ReadOnly = true;

        }
        private void RdbRptRajaatoimipisteeseen_CheckedChanged(object sender, EventArgs e)
        {
            //Jos raporttiin halutaan rajata vain tietty toimipiste
            if (rdbRptRajaatoimipisteeseen.Checked)
            {
                cbxRptToimipiste.Enabled = true;
                s.Connect(connectionString);
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
                s.Connect(connectionString);            //poistetaan saman nimiset palvelut listasta
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
                s.Connect(connectionString);
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
            int varausmaara;
            int asiakasmaara;
            int palvelumaara;
            int i = 0;
            s.Connect(connectionString);
            dtpRptAlku.CustomFormat = "yyyyMMdd";
            dtpRptLoppu.CustomFormat = "yyyyMMdd";
            DateTime alku = dtpRptAlku.Value;
            DateTime loppu = dtpRptLoppu.Value;
            int ts = (int)dtpRptLoppu.Value.ToOADate() - (int)dtpRptAlku.Value.ToOADate();
            //Raportin haku niin että rajauksia ei ole tehty
            if (rdbRptRajaatoimipisteeseen.Checked == false && rdbRajaaPalvelu.Checked == false && rdbRajaaAsiakas.Checked == false)
            {
  
                dgwRaportit.DataSource = s.ShowInGridView("SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE Varaus.varattu_pvm BETWEEN '{alku.ToString("yyyyMMdd")}' AND '{loppu.ToString("yyyyMMdd")}'");
                for (; ts >= 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus WHERE varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[0].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus WHERE varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[1].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    palvelumaara = s.Haelukumaara($"SELECT COUNT(varauksen_palvelut_id) FROM Varauksen_palvelut INNER JOIN Varaus ON Varaus.varaus_id = Varauksen_palvelut.palvelu_id WHERE Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[2].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), palvelumaara);
                    i++;
                }
            }
            //Raportin haku toimipiste rajattu tiettyyn toimipisteeseen
            if (rdbRptRajaatoimipisteeseen.Checked)
            {

                dgwRaportit.DataSource = s.ShowInGridView($"SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE (Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}') AND Varaus.varattu_pvm BETWEEN '{alku.ToString("yyyyMMdd")}' AND '{loppu.ToString("yyyyMMdd")}'");
                for (; ts >= 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE (Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}') AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[0].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}' AND varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[1].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    palvelumaara = s.Haelukumaara($"SELECT COUNT(varauksen_palvelut_id) FROM Varauksen_palvelut INNER JOIN Varaus ON Varaus.varaus_id = Varauksen_palvelut.varaus_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE (Toimipiste.nimi = '{cbxRptToimipiste.Text.ToString()}') AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[2].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), palvelumaara);
                    i++;
                }

            }
            //Raportin haku palvelu rajattu tietyn nimiseen palveluun
            if (rdbRajaaPalvelu.Checked)
            {

                dgwRaportit.DataSource = s.ShowInGridView($"SELECT Varaus.varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Varauksen_palvelut ON Varaus.varaus_id = Varauksen_palvelut.varaus_id INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id WHERE (Palvelu.nimi = '{cbxRptPalvelut.Text.ToString()}') AND Varaus.varattu_pvm BETWEEN '{alku.ToString("yyyyMMdd")}' AND '{loppu.ToString("yyyyMMdd")}'");
                for (; ts >= 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(Varaus.varaus_id) FROM Varaus INNER JOIN Varauksen_palvelut ON Varaus.varaus_id = Varauksen_palvelut.varaus_id INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id WHERE (Palvelu.nimi = '{cbxRptPalvelut.Text.ToString()}') AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[0].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    asiakasmaara = s.Haelukumaara($"SELECT COUNT(DISTINCT asiakas_id) FROM Varaus INNER JOIN Varauksen_palvelut ON Varaus.varaus_id = Varauksen_palvelut.varaus_id INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id WHERE (Palvelu.nimi = '{cbxRptPalvelut.Text.ToString()}') AND varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[1].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), asiakasmaara);
                    palvelumaara = s.Haelukumaara($"SELECT COUNT(varauksen_palvelut_id) FROM Varauksen_palvelut INNER JOIN Varaus ON Varaus.varaus_id = Varauksen_palvelut.palvelu_id INNER JOIN Palvelu ON Varauksen_palvelut.palvelu_id = Palvelu.palvelu_id WHERE (Palvelu.nimi = '{cbxRptPalvelut.Text.ToString()}') AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");                
                    chrRptChart1.Series[2].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), palvelumaara);
                    i++;
                }
            }
            //Raportin haku asiakas rajattu tiettyyn asiakkaaseen
            if (rdbRajaaAsiakas.Checked)
            {
                chrRptChart1.DataSource = null;
                dgwRaportit.DataSource = s.ShowInGridView($"SELECT varaus_id AS 'Varaus Id', Asiakas.etunimi +' '+ Asiakas.sukunimi AS 'Asiakas',Toimipiste.toimipiste_id AS 'Toimipiste ID' , Toimipiste.nimi as 'Toimipiste', varattu_pvm AS 'Varaus pvm'" +
                $"FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id INNER JOIN Toimipiste ON Varaus.toimipiste_id = Toimipiste.toimipiste_id WHERE Asiakas.etunimi + ' ' + Asiakas.sukunimi = '{cbxRptAsiakkaat.Text.ToString()}' AND Varaus.varattu_pvm BETWEEN '{alku.ToString("yyyyMMdd")}' AND '{loppu.ToString("yyyyMMdd")}'");
                for (; ts >= 0; ts--)
                {
                    varausmaara = s.Haelukumaara($"SELECT COUNT(varaus_id) FROM Varaus INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id WHERE Asiakas.etunimi + ' ' + Asiakas.sukunimi = '{cbxRptAsiakkaat.Text.ToString()}' AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[0].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), varausmaara);
                    palvelumaara = s.Haelukumaara($"SELECT COUNT(varauksen_palvelut_id) FROM Varauksen_palvelut INNER JOIN Varaus ON Varaus.varaus_id = Varauksen_palvelut.palvelu_id INNER JOIN Asiakas ON Varaus.asiakas_id = Asiakas.asiakas_id WHERE Asiakas.etunimi + ' ' + Asiakas.sukunimi = '{cbxRptAsiakkaat.Text.ToString()}' AND Varaus.varattu_pvm = '{alku.AddDays(i).ToString("yyyyMMdd")}'");
                    chrRptChart1.Series[2].Points.AddXY(alku.AddDays(i).ToString("dd-MM-yyyy"), palvelumaara);
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

        //Kuvien muodostus tulostukseen
        Bitmap bmpDgw;
        Bitmap bmpChr;
        private void BtnRptTulosta_Click(object sender, EventArgs e)
        {
            int korkoDgw = dgwRaportit.Height;
            dgwRaportit.Height = dgwRaportit.RowCount * dgwRaportit.RowTemplate.Height * 2;
            bmpDgw = new Bitmap(dgwRaportit.Width, dgwRaportit.Height);
            bmpChr = new Bitmap(chrRptChart1.Width, chrRptChart1.Height);
            dgwRaportit.DrawToBitmap(bmpDgw, new Rectangle(0, 0, dgwRaportit.Width, dgwRaportit.Height));
            chrRptChart1.DrawToBitmap(bmpChr, new Rectangle(0, 0, chrRptChart1.Width, chrRptChart1.Height));
            dgwRaportit.Height = korkoDgw;
            printPreviewDialog1.ShowDialog();

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmpDgw, 120, 20);
            e.Graphics.DrawImage(bmpChr, 120, bmpDgw.Height +30);
        }

        private void tietoaOhjelmastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa ti = new Tietoa();
            ti.ShowDialog();
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OhjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("ohje.pdf");
            }
            catch
            {
                MessageBox.Show("Jokin meni pieleen! Ota yhteys ohjelmiston valmistajaan.", "Virhe");
            }
        }
    }


}


    


        