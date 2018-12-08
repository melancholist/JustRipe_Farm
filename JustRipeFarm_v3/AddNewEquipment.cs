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
        AddNewEquipment equipment = new AddNewEquipment();
        DbConnector DBConn = new DbConnector();

        public AddNewEquipment()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Equipment equipment = new Equipment();
            EquipmentHandler equipmentHandler = new EquipmentHandler();

            equipment.Type = textBoxType.Text;
            equipment.Brand = textBoxBrand.Text;
            equipment.Model = textBoxModel.Text;
            equipment.SerialNumber = textBoxSerialNumber.Text;
            equipment.Price = Decimal.Parse(textBoxPrice.Text);
            equipment.Description = textBoxDescription.Text;

            equipmentHandler.addNewEquipment(DBConn.getConn(), equipment);
            MessageBox.Show("A new equipment has been added!");

            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxType.Text = "";
            this.textBoxBrand.Text = "";
            this.textBoxModel.Text = "";
            this.textBoxSerialNumber.Text = "";
            this.textBoxPrice.Text = "";
            this.textBoxDescription.Text = "";
        }
    }
}
