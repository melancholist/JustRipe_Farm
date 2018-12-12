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
    public partial class StorageManagement : Form
    {
        DbConnector dbconn = new DbConnector();

        public StorageManagement()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbconn.connect();
            Storage storage = new Storage();
            storage.UnitType = comboBoxUType.Text;
            storage.UnitName = textBoxUName.Text;
            storage.CubicCapacity = Decimal.Parse(numCubicCap.Value.ToString());
            storage.MinimumTemperature = Decimal.Parse(numMinTemp.Value.ToString());
            storage.MaximumTemperature = Decimal.Parse(numMaxTemp.Value.ToString());
            storage.Humidity = Decimal.Parse(numAirHumd.Value.ToString());

            StorageHandler storHandlr = new StorageHandler();
            storHandlr.addStorage(dbconn.getConn(), storage);

            MessageBox.Show("Storage Added!");

            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxUType.Text = "";
            textBoxUName.Text = "";
            numCubicCap.Value = 0;
            numMinTemp.Value = 0;
            numMaxTemp.Value = 0;
            numAirHumd.Value = 0;
        }
    }
}
