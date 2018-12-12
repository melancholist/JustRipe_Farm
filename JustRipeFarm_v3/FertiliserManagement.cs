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
    public partial class FertiliserManagement : Form
    {
        DbConnector dbcon = new DbConnector();

        public FertiliserManagement()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveF_Click(object sender, EventArgs e)
        {
            dbcon.connect();
            Fertiliser fer = new Fertiliser();
            fer.FertiliserType = comboBoxFerType.Text;
            fer.FertiliserQuantity = Decimal.Parse(numericUpDownFerQauntity.Value.ToString());
            fer.FertiliserCompany = textBoxFerComp.Text;

            FertiliserHandler ferHandlr = new FertiliserHandler();
            ferHandlr.addNewFertiliser(dbcon.getConn(), fer);

            MessageBox.Show("Fertiliser added");

            this.Hide();
        }

        private void btnClearF_Click(object sender, EventArgs e)
        {
            comboBoxFerType.Text = "";
            numericUpDownFerQauntity.Value = 0;
            textBoxFerComp.Text = "";
        }

        private void btnSaveFerUp_Click(object sender, EventArgs e)
        {
            dbcon.connect();

            Fertiliser fert = new Fertiliser();
            fert.FertiliserType = comboBoxUpdateFer.Text;
            fert.FertiliserQuantity = Decimal.Parse(numericUpDownUpdateQ.Value.ToString());

            FertiliserHandler ferHandlr = new FertiliserHandler();
            ferHandlr.updateQuantity(dbcon.getConn(), fert);

            MessageBox.Show("Fertiliser added");

            this.Hide();

        }

        private void btnClearFerU_Click(object sender, EventArgs e)
        {
            comboBoxFerType.Text = "";
            numericUpDownUpdateQ.Value = 0;
        }
    }
}
