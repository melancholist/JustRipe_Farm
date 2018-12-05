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
    public partial class AddNewEquipment : Form
    {
        public AddNewEquipment()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

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
