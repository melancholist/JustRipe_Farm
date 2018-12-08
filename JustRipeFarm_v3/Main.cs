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
using System.Diagnostics;

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
            pnlStorage.Hide();
            //pnlVehicle.Hide();
            pnlStocks.Hide();
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
            pnlResources.Hide();
            pnlStorage.Hide();
            //pnlVehicle.Hide();
            pnlStocks.Hide();
            pnlAccounting.Hide();

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
        private void btnResources_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Show();
            pnlStorage.Hide();
            //pnlVehicle.Hide();
            pnlStocks.Hide();
            pnlAccounting.Hide();

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
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Show();
            //pnlVehicle.Hide();
            pnlStocks.Hide();
            pnlAccounting.Hide();

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
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            //pnlVehicle.Hide();
            pnlStocks.Show();
            pnlAccounting.Hide();

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
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            //pnlVehicle.Hide();
            pnlStocks.Hide();
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

            pnlIncome.Hide();
            pnlExpenses.Hide();
            pnlAccMain.Show();
        }

        //Redirrect users to staff management form
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffManagement stf = new StaffManagement();
            stf.Show();
            this.Hide();
        }

        //Redirect user to add new plant form
        private void btnAddNewPlant_Click(object sender, EventArgs e)
        {
            AddNewPlant addNewPlant = new AddNewPlant();
            addNewPlant.Show();
        }

        //Equipment panel appears and crops panel is hidden when button is clicked
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            pnlEquipment.Show();
            pnlCrops.Hide();
        }

        //Redirect user to add new equipment form
        private void btnAddNewEq_Click(object sender, EventArgs e)
        {
            AddNewEquipment addNewEquipment = new AddNewEquipment();
            addNewEquipment.Show();
        }

        //Crops panel appears and equipment panel is hidden when button is clicked
        private void btnCrops_Click(object sender, EventArgs e)
        {
            pnlCrops.Show();
            pnlEquipment.Hide();
        }

        //Products panel within stock panel appears
        private void btnProducts_Click(object sender, EventArgs e)
        {
            pnlProducts.Show();
            pnlOnlineStore.Hide();
        }

        //Redirect user to website
        private void linkLabelOnlineStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        //Online Store panel within stock panel appears
        private void btnOnlineStore_Click(object sender, EventArgs e)
        {
            pnlProducts.Hide();
            pnlOnlineStore.Show();
        }

        //New Expense form appears when button is clicked
        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            NewExpense newExpense = new NewExpense();
            newExpense.Show();
        }

        //New Income form appears when button is clicked
        private void btnNewIncome_Click(object sender, EventArgs e)
        {
            NewIncome newIncome = new NewIncome();
            newIncome.Show();
        }

        //Income panel appears within Accounting panel when button is clicked
        private void btnIncomeSales_Click(object sender, EventArgs e)
        {
            pnlIncome.Show();
            pnlExpenses.Hide();
        }

        //Expenses panel appears within Accounting panel when button is clicked
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            pnlIncome.Hide();
            pnlExpenses.Show();
        }
    }
}
