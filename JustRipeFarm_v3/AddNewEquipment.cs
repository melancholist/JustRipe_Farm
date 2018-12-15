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
    public partial class AddNewEquipment : Form
    {
        DbConnector DBConn = new DbConnector();

        public AddNewEquipment()
        {
            InitializeComponent();
        }


        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxType.Text = "";
            this.textBoxBrand.Text = "";
            this.textBoxModel.Text = "";
            this.textBoxSerialNumber.Text = "";
            this.textBoxPrice.Text = "";
            this.textBoxDescription.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Equipment equipment = new Equipment();
            EquipmentHandler equipmentHandler = new EquipmentHandler();

            equipment.Type = textBoxType.Text;
            equipment.Brand = textBoxBrand.Text;
            equipment.Model = textBoxModel.Text;
            equipment.SerialNumber = textBoxSerialNumber.Text;
            equipment.PurchaseDate = dateTimePicker.Value.Date;
            equipment.Price = Decimal.Parse(textBoxPrice.Text);
            equipment.Description = textBoxDescription.Text;

            equipmentHandler.addNewEquipment(DBConn.getConn(), equipment);
            MessageBox.Show("A new equipment has been added!");

            this.Hide();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
