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
using MySql.Data.MySqlClient;

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

     
        private void StaffManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaff adstf = new AddStaff();
            adstf.Show();
        }
    }
}
