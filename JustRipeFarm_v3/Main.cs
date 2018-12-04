using System;
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
    public partial class Main : Form
    {
        Staff lab = new Staff();
        DbConnector DbCon = new DbConnector();

        public Main()
        {
            InitializeComponent();
            //Panels
            pnlSchedule.Show();
            panelBtnIndicator1.Show();
            pnlSowing.Show();
            pnlHarvest.Hide();
            panelBtnIndicatorSow.Show();
            panelBtnIndicator2.Hide();
            panelBtnIndicator3.Hide();
            panelBtnIndicator4.Hide();
            panelBtnIndicator5.Hide();
            panelBtnIndicator6.Hide();
            //pnlResources.Hide();
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStock.Hide();
            //pnlAccounting.Hide();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedule.Show();
            //pnlResourses.Hide();

            if (btnSchedule.Enabled)
            {
                panelBtnIndicator1.Show();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Hide();
                panelBtnIndicator6.Hide();
            }
        }

        private void btnSowing_Click(object sender, EventArgs e)
        {
            pnlSowing.Show();
            pnlHarvest.Hide();

            if (btnSowing.Enabled)
            {
                panelBtnIndicatorHarv.Hide();
                panelBtnIndicatorSow.Show();
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            pnlSowing.Hide();
            pnlHarvest.Show();

            if (btnHarvest.Enabled)
            {
                panelBtnIndicatorHarv.Show();
                panelBtnIndicatorSow.Hide();
            }
        }

        private void btnResourses_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            //pnlResourses.Show();

            if (btnResources.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Show();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Hide();
                panelBtnIndicator6.Hide();
            }
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (btnStorage.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Show();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Hide();
                panelBtnIndicator6.Hide();
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            if (btnVehicle.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Show();
                panelBtnIndicator5.Hide();
                panelBtnIndicator6.Hide();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (btnStocks.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Show();
                panelBtnIndicator6.Hide();
            }
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            pnlAccounting.Show();

            if (btnAccounting.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Hide();
                panelBtnIndicator6.Show();
            }
        }

        //Record Transaction panel shows when button is clicked
        private void btnRecordTransaction_Click(object sender, EventArgs e)
        {
            RecordTransaction recordTransaction = new RecordTransaction();
            recordTransaction.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffManagement stf = new StaffManagement();
            stf.Show();
            this.Hide();
        }
    }
}
