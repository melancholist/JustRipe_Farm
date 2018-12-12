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
    public partial class AddNewVehicle : Form
    {
        AddNewVehicle vehicle = new AddNewVehicle();
        DbConnector DBConn = new DbConnector();

        public AddNewVehicle()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxVehicleType.SelectedIndex = -1;
            this.textBoxModelName.Text = "";
            this.textBoxEngNo.Text = "";
            this.textBoxWeightLimit.Text = "";
            comboBoxVehicleStatus.SelectedIndex = -1;
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Vehicle vehicle = new Vehicle();
            VehicleHandler vehicleHandler = new VehicleHandler();

            vehicle.VehicleType = comboBoxVehicleType.Text;
            vehicle.ModelName = textBoxModelName.Text;
            vehicle.ProductionYear = dateTimePicker1.Value.Date;
            vehicle.WeightLimit = Decimal.Parse(textBoxWeightLimit.Text);
            vehicle.EngineNumber = Decimal.Parse(textBoxEngNo.Text);
            vehicle.VehicleStatus = comboBoxVehicleStatus.Text;

            vehicleHandler.addNewVehicle(DBConn.getConn(), vehicle);
            MessageBox.Show("A new vehicle has been added!");

            this.Hide();
        }
    }
}
