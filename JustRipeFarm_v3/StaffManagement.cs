using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
            pnlAddStaff.Show();
            pnlBtnIndic1.Show();
            pnlBtnIndic2.Hide();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            main.picBoxManager.Visible = true;
            main.lblManager.Visible = true;
            main.btnStaffManagement.Visible = true;

            this.Hide();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (btnAddStaff.Enabled)
            { 
                pnlAddStaff.Show();
                pnlBtnIndic1.Show();
                pnlBtnIndic2.Hide();
            }
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();
            add.Show();
            this.Hide();

            if (btnAddManager.Enabled)
            {
                add.lblManagerRole.Visible = true;
            }
        }

        private void btnAddLabourer_Click(object sender, EventArgs e)
        {
            AddStaff ad = new AddStaff();
            ad.Show();
            this.Hide();

            if (btnAddLabourer.Enabled)
            {
                ad.labourerComboBox.Visible = true;
                ad.lblDateHired.Visible = true;
                ad.lblWage.Visible = true;
                ad.hiredDateTimePicker.Visible = true;
                ad.wageTextBox.Visible = true;
            }
        }

        private void btnAddSalesStaff_Click(object sender, EventArgs e)
        {
            AddStaff adstf = new AddStaff();
            adstf.Show();
            this.Hide();

            if (btnAddSalesStaff.Enabled)
            {
                adstf.lblSalesStaff.Visible = true;
            }
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
