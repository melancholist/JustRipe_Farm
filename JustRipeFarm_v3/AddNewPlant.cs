using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm_v3
{
    public partial class AddNewPlant : Form
    {
        public AddNewPlant()
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
        }
    }
}
