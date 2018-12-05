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
            pnlResources.Hide();
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStock.Hide();
            pnlAccounting.Hide();
        }

        //Exit Logout page and return to Login Page when button is clicked
        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        //Schedule panel appears when button is clicked
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

        //Sowing panel within Schedule panel appears when button is clicked
        private void btnSowing_Click(object sender, EventArgs e)
        {
            pnlSowing.Show();
            pnlHarvest.Hide();
            //Hide harvest panel and show Sowing panel
            if (btnSowing.Enabled)
            {
                panelBtnIndicatorHarv.Hide();
                panelBtnIndicatorSow.Show();
            }
        }

        //Harvest panel within Schedule panel appears
        private void btnHarvest_Click(object sender, EventArgs e)
        {
            pnlSowing.Hide();
            pnlHarvest.Show();
            //Hide Sowing panel and show Harvest panel
            if (btnHarvest.Enabled)
            {
                panelBtnIndicatorHarv.Show();
                panelBtnIndicatorSow.Hide();
            }
        }

        //Resources panel appears when button is clicked
        private void btnResourses_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Show();

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

        //Storage panel appears when button is clicked
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

        //Vehicle panel appears when button is clicked
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

        //Stock panel appears when button is clicked
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

        //Accounting panel appears when button is clicked
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

        //Record Transaction panel appears when button is clicked
        private void btnRecordTransaction_Click(object sender, EventArgs e)
        {
            RecordTransaction recordTransaction = new RecordTransaction();
            recordTransaction.Show();
        }

        //Sales panel appears within the Accounting panel when button is clicked
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

        private void btnAddNewPlant_Click(object sender, EventArgs e)
        {
            AddNewPlant addNewPlant = new AddNewPlant();
            addNewPlant.Show();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewEq_Click(object sender, EventArgs e)
        {
            AddNewEquipment addNewEquipment = new AddNewEquipment();
            addNewEquipment.Show();
        }
    }
}
