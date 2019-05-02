﻿using System;
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
    }
}
