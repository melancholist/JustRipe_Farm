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
    public partial class AddNewServiceRecord : Form
    {
        AddNewServiceRecord serviceRecord = new AddNewServiceRecord();
        DbConnector DBConn = new DbConnector();

        public AddNewServiceRecord()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            ServiceRecord serviceRecord = new ServiceRecord();
            ServiceRecordHandler serviceRecordHandler = new ServiceRecordHandler();

            serviceRecord.EqSerialNo = textBoxEqSerialNo.Text;
            serviceRecord.ServiceDate = dateTimePicker1.Value.Date;
            serviceRecord.ServiceDescription = textBoxServiceDesc.Text;
            serviceRecord.ServiceType = comboBoxServiceType.Text;

            serviceRecordHandler.addNewServiceRecord(DBConn.getConn(), serviceRecord);
            MessageBox.Show("A new service record has been added!");

            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxEqSerialNo.Text = "";
            comboBoxServiceType.SelectedIndex = -1;
            textBoxServiceDesc.Text = "";
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
