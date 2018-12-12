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
    public partial class YieldManagement : Form
    {
        DbConnector conn = new DbConnector();

        public YieldManagement()
        {
            InitializeComponent();
            FillStorageUnitName();
        }

        void FillStorageUnitName()
        {
            conn.connect();
            string unitquery = "Select * FROM storage";
            MySqlCommand cmd = new MySqlCommand(unitquery, conn.getConn());
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string machine = reader.GetString("unitName");
                    comboBoxStrUName.Items.Add(machine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxYType.Text = "";
            numYQuantity.Value = 0;
            comboBoxStrUName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.connect();

            Yield yield = new Yield();
            yield.YieldType = textBoxYType.Text;
            yield.Quantity = Decimal.Parse(numYQuantity.Value.ToString());
            yield.StorageUnitName = comboBoxStrUName.Text;
            yield.StorageCapacity = Decimal.Parse(numericUpDownStorCapacity.Value.ToString());

            YieldHandler yHandlr = new YieldHandler();
            yHandlr.addYield(conn.getConn(), yield);

            MessageBox.Show("Yield Added!");

            this.Close();
        }
    }
}
