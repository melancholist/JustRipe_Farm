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
    public partial class AddNewCrop : Form
    {
        AddNewCrop crop = new AddNewCrop();
        DbConnector DBConn = new DbConnector();

        public AddNewCrop()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxType.Text = "";
            this.textBoxVariety.Text = "";
            comboBoxPlantingMethod.SelectedIndex = -1;
            this.textBoxSeedLotNo.Text = "";
            this.textBoxSeedCompany.Text = "";
            this.textBoxSeedOrigin.Text = "";
            this.textBoxAddInfo.Text = "";
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown2.DecimalPlaces = 0;
            numericUpDown3.DecimalPlaces = 0;
            checkBoxGMO.Checked = false;
            checkBoxOrganic.Checked = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Crop crop = new Crop();
            CropHandler cropHandler = new CropHandler();

            crop.Type = textBoxType.Text;
            crop.Variety = textBoxVariety.Text;
            crop.PlantingMethod = comboBoxPlantingMethod.Text;
            crop.SeedLotNumber = textBoxSeedLotNo.Text;
            crop.SeedCompany = textBoxSeedCompany.Text;
            crop.SeedOrigin = textBoxSeedOrigin.Text;
            crop.AdditionalInformation = textBoxAddInfo.Text;
            crop.PlantSpacing = Convert.ToInt32(numericUpDown1.Value);
            crop.PlantingDepth = Convert.ToInt32(numericUpDown2.Value);
            crop.SeedPerHole = Convert.ToInt32(numericUpDown3.Value);
            crop.AdditionalInformation = textBoxAddInfo.Text;
            crop.Organic = checkBoxOrganic.Checked; //ThreeState, CheckAlign, CheckState
            crop.Gmo = checkBoxGMO.Checked;

            cropHandler.addNewCrop(DBConn.getConn(), crop);
            MessageBox.Show("A new crop has been added!");

            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
