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
            pnlFieldWorkers.Show();
            //pnlDrivers.Hode();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            StaffManagement staff = new StaffManagement();
            staff.Show();
            this.Hide();
        }
    }
}
