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
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStocks.Hide();
            //pnlAccounting.Hide();
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
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStocks.Hide();
            //pnlAccounting.Hide();

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
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStocks.Hide();
            //pnlAccounting.Hide();

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
            DataTable dt = new DataTable("crops");
            try
            {
                string query = "SELECT * FROM crops";
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

        }
        private void btnUpdateFert_Click(object sender, EventArgs e)
        {

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

        }
        private void btnUpdatePest_Click(object sender, EventArgs e)
        {

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
            //pnlStorage.Show();
            //pnlVehicle.Hide();
            //pnlStocks.Hide();
            //pnlAccounting.Hide();

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

        //Vehicle and Machines 
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            //pnlStorage.Hide();
            //pnlVehicle.Show();
            //pnlStocks.Hide();
            //pnlAccounting.Hide();

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

        //Yield
        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStocks.Show();
            //pnlAccounting.Hide();

            if (btnYields.Enabled)
            {
                panelBtnIndicator1.Hide();
                panelBtnIndicator2.Hide();
                panelBtnIndicator3.Hide();
                panelBtnIndicator4.Hide();
                panelBtnIndicator5.Show();
                panelBtnIndicator6.Hide();
            }
        }

        //Accounting 
        private void btnAccounting_Click(object sender, EventArgs e)
        {
            pnlSchedule.Hide();
            pnlResources.Hide();
            //pnlStorage.Hide();
            //pnlVehicle.Hide();
            //pnlStocks.Hide();
            //pnlAccounting.Show();

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
