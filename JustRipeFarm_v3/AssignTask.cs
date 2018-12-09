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
    public partial class AssignTask : Form
    {
        public AssignTask()
        {
            InitializeComponent();
        }

        private void AssignTask_Load(object sender, EventArgs e)
        {
            pnlSowing.Visible = true;
            pnlSowing.BringToFront();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffManagement stffMng = new StaffManagement();
            stffMng.Show();
        }

        private void btnSowing_Click(object sender, EventArgs e)
        {
            while (btnSowing.Enabled)
            {
                pnlSowing.Visible = true;
                pnlSowing.BringToFront();
                break;
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            while (btnHarvest.Enabled)
            {
                pnlHarvest.Visible = true;
                pnlHarvest.BringToFront();
                break;
            }
        }

        private void btnTreating_Click(object sender, EventArgs e)
        {
            while (btnTreating.Enabled)
            {
                pnlTreatment.Visible = true;
                pnlTreatment.BringToFront();
                break;
            }
           
        }

        private void btnDriving_Click(object sender, EventArgs e)
        {
            while (btnDriving.Enabled)
            {
                pnlDriving.Visible = true;
                pnlDriving.BringToFront();
                break;
            }
        }

        private void btnSaveT_Click(object sender, EventArgs e)
        {

        }
    }
}
