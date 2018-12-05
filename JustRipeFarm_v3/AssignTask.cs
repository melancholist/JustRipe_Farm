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
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffManagement stffMng = new StaffManagement();
            stffMng.Show();
        }

        private void btnSowing_Click(object sender, EventArgs e)
        {
            pnlSowing.Visible = true;
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            pnlHarvest.Visible = true;
        }

        private void btnTreating_Click(object sender, EventArgs e)
        {
            pnlTreatment.Visible = true;
        }

        private void btnDriving_Click(object sender, EventArgs e)
        {
            pnlDriving.Visible = true;
        }

    }
}
