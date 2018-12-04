﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            AddManager add = new AddManager();
            add.Show();

            if (btnAddManager.Enabled)
            {
                add.lblManagerRole.Visible = true;
            }
        }

        private void btnAddLabourer_Click(object sender, EventArgs e)
        {
            AddManager ad = new AddManager();
            ad.Show();

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
            AddManager adstf = new AddManager();
            adstf.Show();

            if (btnAddSalesStaff.Enabled)
            {
                adstf.lblSalesStaff.Visible = true;
            }
        }
    }
}
