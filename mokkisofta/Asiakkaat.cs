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
    public partial class Asiakkaat : Form
    {
        public Asiakkaat()
        {
            InitializeComponent();
        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asiakaatDataSet.Asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.asiakaatDataSet.Asiakas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
