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
    public partial class AddNewMachine : Form
    {
        AddNewMachine machine = new AddNewMachine();
        DbConnector DBConn = new DbConnector();

        public AddNewMachine()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Machine machine = new Machine();
            MachineHandler machineHandler = new MachineHandler();

            machine.MachineType = comboBoxMachineType.Text;
            machine.ModelName = textBoxModelName.Text;
            machine.Date = dateTimePicker1.Value.Date;
            machine.MachineStatus = comboBoxMachineStatus.Text;
            machine.Price = Decimal.Parse(textBoxPrice.Text);

            machineHandler.addNewMachine(DBConn.getConn(), machine);
            MessageBox.Show("A new machine has been added!");

            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxMachineType.SelectedIndex = -1;
            this.textBoxModelName.Text = "";
            this.textBoxPrice.Text = "";
            comboBoxMachineStatus.SelectedIndex = -1;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
