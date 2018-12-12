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
        DbConnector Dbconn = new DbConnector();

        public StaffManagement()
        {
            InitializeComponent();

            pnlAddStaff.Show();
            pnlBtnIndic1.Show();
        }

        DataTable dt = new DataTable("staffdata");
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=sql12.freemysqlhosting.net;user=sql12268366;database=sql12268366;password=1VpFDLJHBC;port=3306";
                string query = "SELECT * FROM staffdata";
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
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("staffRole LIKE '%{0}%'", searchComboBox.SelectedItem.ToString());
            dataGridViewStaff.DataSource = dv.ToTable();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            main.picBoxManager.Visible = true;
            main.lblManager.Visible = true;
            main.btnStaffManagement.Visible = true;

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
