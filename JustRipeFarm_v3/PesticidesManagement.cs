using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public partial class PesticidesManagement : Form
    {
        DbConnector DBcon = new DbConnector();

        public PesticidesManagement()
        {
            InitializeComponent();
        }

        private void btnSaveP_Click(object sender, EventArgs e)
        {
            DBcon.connect();
            Pesticides pes = new Pesticides();
            pes.PesticidesType = comboBoxPesType.Text;
            pes.PesticideQauntity = Decimal.Parse(numericUpDownPesQauntity.Value.ToString());
            pes.Company = textBoxPesComp.Text;

            PesticideHandler pesHandlr = new PesticideHandler();
            pesHandlr.addNewPesticide(DBcon.getConn(), pes);

            MessageBox.Show("Fertiliser added");

            this.Hide();
        }

        private void btnClearP_Click(object sender, EventArgs e)
        {
            comboBoxPesType.Text = "";
            numericUpDownPesQauntity.Value = 0;
            textBoxPesComp.Text = "";
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            DBcon.connect();
            Pesticides pes = new Pesticides();
            pes.PesticidesType = comboBoxUpdType.Text;
            pes.PesticideQauntity = Decimal.Parse(numericUpDownUpdateQ.Value.ToString());

            PesticideHandler pesHandlr = new PesticideHandler();
            pesHandlr.updateQuantity(DBcon.getConn(), pes);

            MessageBox.Show("Fertiliser added");

            this.Hide();
        }

        private void btnClearUpd_Click(object sender, EventArgs e)
        {
            comboBoxUpdType.Text = "";
            numericUpDownUpdateQ.Value = 0;
        }
    }
}
