﻿using System;
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
            this.textBoxPrice.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Vehicle vehicle = new Vehicle();
            VehicleHandler vehicleHandler = new VehicleHandler();

            vehicle.VehicleType = comboBoxVehicleType.Text;
            vehicle.ModelName = textBoxModelName.Text;
            vehicle.ProductionYear = dateTimePicker1.Value.Date;
            vehicle.WeightLimit = Decimal.Parse(textBoxWeightLimit.Text);
            vehicle.EngineNumber = textBoxEngNo.Text;
            vehicle.VehicleStatus = comboBoxVehicleStatus.Text;
            vehicle.Price = Decimal.Parse(textBoxPrice.Text);

            vehicleHandler.addNewVehicle(DBConn.getConn(), vehicle);
            MessageBox.Show("A new vehicle has been added!");

            this.Hide();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBoxPrice.Text.IndexOf('.') != 1)
            {
                e.Handled = true;
                return;
            }
             if (!char.IsDigit(ch) && ch != 8 && ch != 46) //8 is backspace
            {
                e.Handled = true;
            }
        }

        private void textBoxWeightLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBoxPrice.Text.IndexOf('.') != 1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46) //8 is backspace
            {
                e.Handled = true;
            }
        }
    }
}
