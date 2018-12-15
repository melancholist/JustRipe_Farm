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
using DGVPrinterHelper;

namespace JustRipeFarm_v3
{
    public partial class Main : Form
    {
        Staff lab = new Staff();
        Login lgn = new Login();
        DbConnector dbc = new DbConnector();
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
                Login lgn = new Login();
                string query = "SELECT  `id` AS 'ID', " +
                    "`labourerName` AS 'Labourer Name', " +
                    "`farmSector` AS 'Farm Sector', " +
                    "`taskStatus` AS 'Task Status', " +
                    "`startDate` AS 'Start Date', " +
                    "`endDate` AS 'End Date', " +
                    "`method` AS 'Method', " +
                    "`seed` AS 'Seed', " +
                    "`quantity` AS 'Quantity', " +
                    "`startTime` AS 'Start Time', " +
                    "`endTime` AS 'End Time' " +
                    "FROM sowingTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewSchedule.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewSchedule.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewSchedule.RowHeadersVisible = false;
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
                Login lgn = new Login();
                string query = "SELECT `id` AS 'ID', " +
                    "`labourerName` AS 'Labourer Name', " +
                    "`farmSector` AS 'Farm Sector', " +
                    "`taskStatus` AS 'Task Status', " +
                    "`startDate` AS 'Start Date', " +
                    "`endDate` AS 'End Date', " +
                    "`method` AS 'Method', " +
                    "`storageUnit` AS 'Storage Unit', " +
                    "`machine` AS 'Machine', " +
                    "`startTime` AS 'Start Time', " +
                    "`endTime` AS 'End Time'" +
                    "FROM harvestTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewSchedule.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewSchedule.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewSchedule.RowHeadersVisible = false;
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
                Login lgn = new Login();
                string query = "SELECT `id` AS 'ID', " +
                    "`labourerName` AS 'Labourer Name', " +
                    "`farmSector` AS 'Farm Sector', " +
                    "`taskStatus` AS 'Task Status', " +
                    "`startDate` AS 'Start Date', " +
                    "`endDate` AS 'End Date', " +
                    "`fertiliserUsed` AS 'Fertiliser Used', " +
                    "`quantity` AS 'Quantity', " +
                    "`startTime` AS 'Start Time', " +
                    "`endTime` AS 'EndTime' " +
                    "FROM treatmentTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewSchedule.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewSchedule.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewSchedule.RowHeadersVisible = false;
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
                Login lgn = new Login();
                string query = "SELECT " +
                    "`id` AS'ID', " +
                    "`labourerName` AS 'Labourer Name', " +
                    "`farmSector` AS 'Farm Sector', " +
                    "`taskStatus` AS 'Task Status', " +
                    "`startDate` AS 'Start Date', " +
                    "`endDate` AS 'End Date', " +
                    "`vehicleUsed` AS 'Vehicle Used' " +
                    "FROM drivingTask";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewSchedule.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewSchedule.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewSchedule.RowHeadersVisible = false;
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
                string query = "SELECT " +
                    "`id` AS 'ID'," +
                    " `type` AS 'Type'," +
                    " `variety` AS 'Variety'," +
                    " `seedCompany` AS 'Seed Company'," +
                    " `seedLotNumber` AS 'Seed Lot Number'," +
                    " `seedOrigin` AS 'Seed Origin'," +
                    " `plantSpacing` AS 'Plant Spacing'," +
                    " `plantingDepth` AS 'Planting Depth'," +
                    " `plantingMethod` AS 'Planting Method'," +
                    " `seedPerHole` AS 'Seed Per Hole'," +
                    " `additionalInformation` AS 'Additional Information'," +
                    " `organic` AS 'Organic'," +
                    " `gmo` AS 'GMO'" +
                    " FROM crop";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewCrops.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewCrops.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewCrops.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewCrops.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewCrops.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewCrops.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewCrops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewCrops.RowHeadersVisible = false;
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
        private void btnPrintCrops_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Crops Report"; //Header
            printer.SubTitle = string.Format("Date {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Just Ripe Farm"; //Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewCrops);
        }
        //Fertilisers
        private void btnFertilisers_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("fertiliser");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`fertiliserType` AS 'Fertiliser Type', " +
                    "`fertiliserQuantity` AS 'Fertiliser Quantity', " +
                    "`fertiliserCompany` AS 'Fertiliser Company' " +
                    "FROM fertiliser";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewFertiliser.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewFertiliser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewFertiliser.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewFertiliser.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewFertiliser.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewFertiliser.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewFertiliser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewFertiliser.RowHeadersVisible = false;
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
        private void btnPrintFertilisers_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Fertilisers Report"; //Header
            printer.SubTitle = string.Format("Date {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Just Ripe Farm"; //Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewFertiliser);
        }
        //Pesticides
        private void btnPesticides_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("pesticide");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`pesticideType` AS 'Pesticide Type', " +
                    "`pesticideQuantity` AS 'Pesticide Quantity', " +
                    "`company` AS 'Company' " +
                    "FROM pesticide";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewPesticides.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewPesticides.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewPesticides.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewPesticides.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewPesticides.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewPesticides.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewPesticides.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewPesticides.RowHeadersVisible = false;
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
        private void btnPrintPesticides_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Pesticides Report"; //Header
            printer.SubTitle = string.Format("Date {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Just Ripe Farm"; //Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewPesticides);
        }
        //Equipments
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("equipment");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`type` AS 'Type', " +
                    "`brand` AS 'Brand', " +
                    "`model` AS 'Model', " +
                    "`serialNumber` AS 'Serial Number', " +
                    "`purchaseDate` AS 'Purchase Date', " +
                    "`price` AS 'Price', " +
                    "`description` AS 'Description' " +
                    "FROM equipment";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewEquipment.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewEquipment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewEquipment.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewEquipment.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewEquipment.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewEquipment.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewEquipment.RowHeadersVisible = false;
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
        private void btnPrntEquipment_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Equipments Report"; //Header
            printer.SubTitle = string.Format("Date {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Just Ripe Farm"; //Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewEquipment);
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

            DataTable datb = new DataTable("storage");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`unitType` AS 'Unit Type', " +
                    "`unitName` AS 'Unit Name', " +
                    "`cubicCapacity` AS 'Cubic Capacity', " +
                    "`minimumTemperature` AS 'Minimum Temperature', " +
                    "`maximumTemperature` AS 'Maximum Temperature', " +
                    "`humidity` AS 'Humidity' " +
                    "FROM storage";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewStorage.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewStorage.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewStorage.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewStorage.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewStorage.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewStorage.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewStorage.RowHeadersVisible = false;
                        da.Fill(datb);
                        dataGridViewStorage.DataSource = datb;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            StorageManagement stor = new StorageManagement();
            stor.Show();
        }


        // Vehicle/Machine panel 
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

            DataTable dtbl = new DataTable("vehicle");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`vehicleType` AS 'Vehicle Type', " +
                    "`modelName` AS 'Model Name', " +
                    "`productionYear` AS 'Production Year', " +
                    "`engineNumber` AS 'Engine Number', " +
                    "`weightLimit` AS 'Weight Limit', " +
                    "`vehicleStatus` AS 'Vehicle Status', " +
                    "`price` AS 'Price' " +
                    "FROM vehicle";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewVehicle.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewVehicle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewVehicle.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewVehicle.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewVehicle.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewVehicle.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewVehicle.RowHeadersVisible = false;
                        da.Fill(dtbl);
                        dataGridViewVehicle.DataSource = dtbl;
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
            DataTable dtbl = new DataTable("vehicle");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`vehicleType` AS 'Vehicle Type', " +
                    "`modelName` AS 'Model Name', " +
                    "`productionYear` AS 'Production Year', " +
                    "`engineNumber` AS 'Engine Number', " +
                    "`weightLimit` AS 'Weight Limit', " +
                    "`vehicleStatus` AS 'Vehicle Status', " +
                    "`price` AS 'Price' " +
                    "FROM vehicle";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dtbl);
                        dataGridViewVehicle.DataSource = dtbl;
                        DataView dv = dtbl.DefaultView;
                        dv.RowFilter = string.Format("vehicleType LIKE '%{0}%'", comboBoxVehicType.SelectedItem.ToString());
                        comboBoxVehicType.DataSource = dv.ToTable();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Machine
        private void btnMachine_Click(object sender, EventArgs e)
        {
            groupBoxVehicle.Visible = false;
            groupBoxMachine.Visible = true;

            DataTable dtb = new DataTable("machine");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`machineType` AS 'Machine Type', " +
                    "`modelName` AS 'Model Name', " +
                    "`machineStatus` AS 'Machine Status', " +
                    "`price` AS 'Price' " +
                    "FROM machine";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewMachine.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewMachine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewMachine.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewMachine.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewMachine.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewMachine.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewMachine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewMachine.RowHeadersVisible = false;
                        da.Fill(dtb);
                        dataGridViewMachine.DataSource = dtb;
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
            DataTable dtb = new DataTable("machine");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`machineType` AS 'Machine Type', " +
                    "`modelName` AS 'Model Name', " +
                    "`machineStatus` AS 'Machine Status', " +
                    "`price` AS 'Price' " +
                    "FROM machine";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dtb);
                        dataGridViewMachine.DataSource = dtb;
                        DataView dv = dtb.DefaultView;
                        dv.RowFilter = string.Format("machineType LIKE '%{0}%'", comboBoxMachType.SelectedItem.ToString());
                        comboBoxMachType.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            DataTable dtab = new DataTable("yield");
            try
            {
                string query = "SELECT  `id` AS 'ID', " +
                    "`yieldType` AS 'Yield Type', " +
                    "`quantity` AS 'Quantity',  " +
                    "`storageUnitName` AS 'Storage Unit Name' " +
                    "FROM yield";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewYields.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewYields.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewYields.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewYields.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewYields.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewYields.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewYields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewYields.RowHeadersVisible = false;
                        da.Fill(dtab);
                        dataGridViewYields.DataSource = dtab;
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
            DataTable dtab = new DataTable("yield");
            try
            {
                string query = "SELECT  `id` AS 'ID', " +
                    "`yieldType` AS 'Yield Type', " +
                    "`quantity` AS 'Quantity',  " +
                    "`storageUnitName` AS 'Storage Unit Name' " +
                    "FROM yield";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dtab);
                        dataGridViewYields.DataSource = dtab;
                        DataView dv = dtab.DefaultView;
                        dv.RowFilter = string.Format("yieldType LIKE '%{0}%'", comboBoxYieldType.SelectedItem.ToString());
                        comboBoxYieldType.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printYield_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Yield Report"; //Header
            printer.SubTitle = string.Format("Date {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Just Ripe Farm"; //Footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewYields);
        }
        //Products
        private void btnProducts_Click(object sender, EventArgs e)
        {
            groupBoxYields.Visible = false;
            groupBoxProducts.Visible = true;

            DataTable data = new DataTable("product");
            try
            {
                string query = "SELECT `id` AS 'ID', " +
                    "`productName` AS 'Product Name', " +
                    "`price` AS 'Price', " +
                    "`quantityAvailable` AS 'Quantity Available', " +
                    "`status` AS 'Status', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM product";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewProducts.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewProducts.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewProducts.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewProducts.RowHeadersVisible = false;
                        da.Fill(data);
                        dataGridViewProducts.DataSource = data;
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
            DataTable data = new DataTable("product");
            try
            {
                string query = "SELECT `id` AS 'ID', " +
                    "`productName` AS 'Product Name', " +
                    "`price` AS 'Price', " +
                    "`quantityAvailable` AS 'Quantity Available', " +
                    "`status` AS 'Status', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM product";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(data);
                        dataGridViewProducts.DataSource = data;
                        DataView dv = data.DefaultView;
                        dv.RowFilter = string.Format("category LIKE '%{0}%'", comboBoxProdCat.SelectedItem.ToString());
                        comboBoxProdCat.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            DataTable dta = new DataTable("income");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`amount` AS 'Amount', " +
                    "`date` AS 'Date', " +
                    "`customer` AS 'Customer', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM income";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewIncome.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewIncome.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewIncome.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewIncome.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewIncome.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewIncome.RowHeadersVisible = false;
                        da.Fill(dta);
                        dataGridViewIncome.DataSource = dta;
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
            DataTable dta = new DataTable("income");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`amount` AS 'Amount', " +
                    "`date` AS 'Date', " +
                    "`customer` AS 'Customer', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM income";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {                     
                        da.Fill(dta);
                        dataGridViewIncome.DataSource = dta;
                        DataView dv = dta.DefaultView;
                        dv.RowFilter = string.Format("date = '#{0}#'", dateTimePickerInDate.Value.ToLongDateString());
                        dataGridViewIncome.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Expense
        private void btnExpense_Click(object sender, EventArgs e)
        {
            groupBoxIncome.Visible = false;
            groupBoxExpense.Visible = true;

            DataTable dtt = new DataTable("expense");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`amount` AS 'Amount', " +
                    "`date` AS 'Date', " +
                    "`payee` AS 'Payee', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM expense";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        dataGridViewExpense.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                        dataGridViewExpense.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dataGridViewExpense.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewExpense.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridViewExpense.RowsDefaultCellStyle.ForeColor = Color.Black;
                        dataGridViewExpense.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        dataGridViewExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        dataGridViewExpense.RowHeadersVisible = false;
                        da.Fill(dtt);
                        dataGridViewExpense.DataSource = dtt;
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
            DataTable dtt = new DataTable("expense");
            try
            {
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`amount` AS 'Amount', " +
                    "`date` AS 'Date', " +
                    "`payee` AS 'Payee', " +
                    "`category` AS 'Category', " +
                    "`description` AS 'Description' " +
                    "FROM expense";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dtt);
                        dataGridViewExpense.DataSource = dtt;
                        DataView dv = dtt.DefaultView;
                        dv.RowFilter = string.Format("date = '#{0}#'", dateTimePickerExpDate.Value.ToLongDateString());
                        dataGridViewExpense.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Redirrect users to staff management form
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffManagement stf = new StaffManagement();
            stf.Show();
            this.Hide();
        }

        //Redirrect users to update task status form
        private void btnUpdateTaskStatus_Click(object sender, EventArgs e)
        {
            UpdateTaskStatus tsk = new UpdateTaskStatus();
            tsk.Show();
        }

        //Redirect user to website
        /*private void linkLabelOnlineStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }*/
    }
}
