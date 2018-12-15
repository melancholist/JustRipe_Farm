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
        string connString = "server=sql12.freemysqlhosting.net;user=sql12268366;database=sql12268366;password=1VpFDLJHBC;port=3306";

        public StaffManagement()
        {
            InitializeComponent();

            pnlAddStaff.Show();
            pnlBtnIndic1.Show();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable("staffdata");
                string query = "SELECT " +
                    "`id` AS 'ID', " +
                    "`firstName` AS 'First Name', " +
                    "`lastName` AS 'Last Name', " +
                    "`age` AS 'Age', " +
                    "`sex` AS 'Sex', " +
                    "`address` AS 'Address', " +
                    "`zipCode` AS 'Zip Code', " +
                    "`contactNumber` AS 'Contact Number', " +
                    "`staffRole` AS 'Staff Role', " +
                    "`loginStatus` AS 'Login Status', " +
                    "`dateOfHire` AS 'Date Of Hire', " +
                    "`hourlyWage` AS 'Hourly Wage', " +
                    "`username` AS 'Username', " +
                    "`password` AS 'Password' " +
                    "FROM staffdata";
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        da.Fill(dt);
                        dataGridViewStaff.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBocSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM staffdata";
            DataTable dta = new DataTable("staffdata");
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    da.Fill(dta);
                    dataGridViewStaff.DataSource = dta;
                    DataView dv = dta.DefaultView;
                    dv.RowFilter = string.Format("staffRole LIKE '%{0}%'", searchComboBox.SelectedItem.ToString());
                    dataGridViewStaff.DataSource = dv.ToTable();
                }
            }
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            main.picBoxManager.Visible = true;
            main.lblManager.Visible = true;
            main.btnStaffManagement.Visible = true;
            main.btnAccounting.Visible = true;
            main.btnStock.Visible = true;
            main.btnAddStorage.Visible = true;
            main.btnAddVehic.Visible = true;
            main.btnAddMach.Visible = true;
            main.btnAddCrops.Visible = true;
            main.btnAddFertilisers.Visible = true;
            main.btnAddPesticides.Visible = true;
            main.btnAddEquipment.Visible = true;
            main.btnUpdateFert.Visible = true;
            main.btnUpdatePest.Visible = true;
            main.btnPrintCrops.Visible = true;
            main.btnPrintFertilisers.Visible = true;
            main.btnPrintPesticides.Visible = true;
            main.btnPrntEquipment.Visible = true;
            main.btnPrntEquipment.Visible = true;
            main.printStorage.Visible = true;
            main.PrintMachine.Visible = true;
            main.printVehicle.Visible = true;

            this.Hide();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (btnAddStaff.Enabled)
            {
                pnlAddStaff.Show();
                pnlBtnIndic1.Show();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaff adstf = new AddStaff();
            adstf.Show();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            AssignTask tsk = new AssignTask();
            tsk.Show();
            this.Hide();
        }
    }
}
