using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace JustRipeFarm_v3
{
    public partial class Main : Form
    {
        Staff lab = new Staff();
        string connString = "server=sql12.freemysqlhosting.net;user=sql12268366;database=sql12268366;password=1VpFDLJHBC;port=3306";

        public Main()
        {
            InitializeComponent();
            //Panels
            pnlSchedule.Show();
            panelBtnIndicator1.Show();
            panelBtnIndicator2.Hide();
            panelBtnIndicator3.Hide();
            panelBtnIndicator4.Hide();
            panelBtnIndicator5.Hide();
            panelBtnIndicator6.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            pnlVehicMach.Hide();
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

        //Schedule panel
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedule.Show();
            pnlResources.Hide();
            pnlStorage.Hide();
            pnlVehicMach.Hide();
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
        private void btnSowing_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("sowingTask");
            try
            {
                string query = "SELECT * FROM sowingTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewSchedule.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHarvest_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("harvestTask");
            try
            {
                string query = "SELECT * FROM harvestTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewSchedule.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("treatmentTask");
            try
            {
                string query = "SELECT * FROM treatmentTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewSchedule.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDriving_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("drivingTask");
            try
            {
                string query = "SELECT * FROM drivingTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewSchedule.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Resources panel
        private void btnResources_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Show();
            pnlResources.BringToFront();
            pnlStorage.Hide();
            pnlVehicMach.Hide();
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
        //Crops
        private void btnCrops_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("crop");
            try
            {
                string query = "SELECT * FROM crop";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewCrops.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnCrops.Enabled)
            {
                groupBoxCrops.Visible = true;
                groupBoxFertilisers.Visible = false;
                groupBoxPesticides.Visible = false;
                groupBoxEquip.Visible = false;
            }
        }
        private void btnAddCrops_Click(object sender, EventArgs e)
        {
            AddNewCrop crop = new AddNewCrop();
            crop.Show();
        }
        //Fertilisers
        private void btnFertilisers_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("fertiliser");
            try
            {
                string query = "SELECT * FROM fertiliser";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewFertiliser.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnFertilisers.Enabled)
            {
                groupBoxCrops.Visible = false;
                groupBoxFertilisers.Visible = true;
                groupBoxPesticides.Visible = false;
                groupBoxEquip.Visible = false;
            }
        }
        private void btnAddFertilisers_Click(object sender, EventArgs e)
        {
            FertiliserManagement fer = new FertiliserManagement();
            fer.Show();
            fer.pnlAddFertiliser.Show();
            fer.pnlUpdateFer.Hide();
        }
        private void btnUpdateFert_Click(object sender, EventArgs e)
        {
            FertiliserManagement fer = new FertiliserManagement();
            fer.Show();
            fer.pnlAddFertiliser.Hide();
            fer.pnlUpdateFer.Show();
        }
        //Pesticides
        private void btnPesticides_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("pesticide");
            try
            {
                string query = "SELECT * FROM pesticide";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewPesticides.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnPesticides.Enabled)
            {
                groupBoxCrops.Visible = false;
                groupBoxFertilisers.Visible = false;
                groupBoxPesticides.Visible = true;
                groupBoxEquip.Visible = false;
            }
        }
        private void btnAddPesticides_Click(object sender, EventArgs e)
        {
            PesticidesManagement pesMang = new PesticidesManagement();
            pesMang.Show();
            pesMang.pnlAddPesticides.Show();
            pesMang.pnlUpdatePes.Hide();
        }
        private void btnUpdatePest_Click(object sender, EventArgs e)
        {
            PesticidesManagement pesMang = new PesticidesManagement();
            pesMang.Show();
            pesMang.pnlAddPesticides.Hide();
            pesMang.pnlUpdatePes.Show();
        }
        //Equipments
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("equipment");
            try
            {
                string query = "SELECT * FROM equipment";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewEquipment.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnEquipment.Enabled)
            {
                groupBoxCrops.Visible = false;
                groupBoxFertilisers.Visible = false;
                groupBoxPesticides.Visible = false;
                groupBoxEquip.Visible = true;
            }
        }
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            AddNewEquipment equip = new AddNewEquipment();
            equip.Show();
        }


        //Storage panel
        private void btnStorage_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Show();
            pnlVehicMach.Hide();
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

            DataTable dt = new DataTable("storage");
            try
            {
                string query = "SELECT * FROM storage";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewStorage.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picBoxSearchStorage_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("storage");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("unitName LIKE '%{0}%'", comboBoxUnitName.SelectedItem.ToString());
            comboBoxUnitName.DataSource = dv.ToTable();
        }
        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            StorageManagement stor = new StorageManagement();
            stor.Show();
        }

        //Vehicle/Machine panel 
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            pnlVehicMach.Show();
            pnlStocks.Hide();
            pnlAccounting.Hide();

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
        //Vehicle
        private void btnVehic_Click(object sender, EventArgs e)
        {
            groupBoxVehicle.Visible = true;
            groupBoxMachine.Visible = false;

            DataTable dt = new DataTable("vehicle");
            try
            {
                string query = "SELECT * FROM vehicle";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewVehicle.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddVehic_Click(object sender, EventArgs e)
        {
            AddNewVehicle vehic = new AddNewVehicle();
            vehic.Show();
        }
        private void pictureBoxSearchV_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("vehicle");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("vehicleType LIKE '%{0}%'", comboBoxVehicType.SelectedItem.ToString());
            comboBoxVehicType.DataSource = dv.ToTable();
        }
        //Machine
        private void btnMachine_Click(object sender, EventArgs e)
        {
            groupBoxVehicle.Visible = false;
            groupBoxMachine.Visible = true;

            DataTable dt = new DataTable("machine");
            try
            {
                string query = "SELECT * FROM machine";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewMachine.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picBoxSearchM_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("machine");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("machineType LIKE '%{0}%'", comboBoxMachType.SelectedItem.ToString());
            comboBoxMachType.DataSource = dv.ToTable();
        }
        private void btnAddMach_Click(object sender, EventArgs e)
        {
            AddNewMachine mach = new AddNewMachine();
            mach.Show();
        }


        //Stock panel
        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            pnlVehicMach.Hide();
            pnlStocks.Show();
            pnlAccounting.Hide();

            if (btnStock.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Show();
                panelBtnIndicator6.Hide();
            }
        }
        //Yields
        private void btnYields_Click(object sender, EventArgs e)
        {
            groupBoxYields.Visible = true;
            groupBoxProducts.Visible = false;

            DataTable dt = new DataTable("yield");
            try
            {
                string query = "SELECT * FROM yield";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewYields.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddYield_Click(object sender, EventArgs e)
        {
            YieldManagement ymang = new YieldManagement();
            ymang.Show();
        }
        private void picBoxSearchYield_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("yield");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("yieldType LIKE '%{0}%'", comboBoxYieldType.SelectedItem.ToString());
            comboBoxYieldType.DataSource = dv.ToTable();
        }
        //Products
        private void btnProducts_Click(object sender, EventArgs e)
        {
            groupBoxYields.Visible = false;
            groupBoxProducts.Visible = true;

            DataTable dt = new DataTable("product");
            try
            {
                string query = "SELECT * FROM product";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewProducts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            AddNewProduct product = new AddNewProduct();
            product.Show();
        }
        private void picBoxSearchProd_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("product");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("category LIKE '%{0}%'", comboBoxProdCat.SelectedItem.ToString());
            comboBoxProdCat.DataSource = dv.ToTable();
        }


        //Accounting panel
        private void btnAccounting_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            pnlStorage.Hide();
            pnlVehicMach.Hide();
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
        }
        //Income
        private void btnIncome_Click(object sender, EventArgs e)
        {
            groupBoxIncome.Visible = true;
            groupBoxExpense.Visible = false;

            DataTable dt = new DataTable("income");
            try
            {
                string query = "SELECT * FROM income";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewIncome.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddNewIncome inc = new AddNewIncome();
            inc.Show();
        }
        private void pictBoxSearchInDate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("income");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("date = '#{0}#'", dateTimePickerInDate.Value.ToShortDateString());
            dataGridViewIncome.DataSource = dv.ToTable();
        }
        //Expense
        private void btnExpense_Click(object sender, EventArgs e)
        {
            groupBoxIncome.Visible = false;
            groupBoxExpense.Visible = true;

            DataTable dt = new DataTable("expense");
            try
            {
                string query = "SELECT * FROM expense";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewExpense.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddNewExpense exp = new AddNewExpense();
            exp.Show();
        }
        private void picBoxSearchExpDate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("expense");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("date = '#{0}#'", dateTimePickerExpDate.Value.ToShortDateString());
            dataGridViewExpense.DataSource = dv.ToTable();
        }


        //Redirrect users to staff management form
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffManagement stf = new StaffManagement();
            stf.Show();
            this.Hide();
        }

        //Redirect user to website
        /*private void linkLabelOnlineStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }*/
    }
}
