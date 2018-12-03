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
    public partial class ResetPasswordManager : Form
    {
        DbConnector DBcon = new DbConnector();
        SqlDataAdapter da;

        public ResetPasswordManager()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            ManagerLogin mangr = new ManagerLogin();
            mangr.Show();

            this.Hide();
        }

        //Reset Password for Manager
        private void btnManagerConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMangrUser.Text) || string.IsNullOrWhiteSpace(textBoxMangrNewPass.Text) || string.IsNullOrWhiteSpace(textBoxMangrConfirmPass.Text))
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DBcon.connect();
                    string rstQuery = "UPDATE Manager SET Password = '" + textBoxMangrConfirmPass.Text + "' WHERE Username = '" + textBoxMangrUser.Text + "'";

                    da = new SqlDataAdapter(rstQuery, DBcon.getConn());
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        Login logn = new Login();
                        this.Hide();
                        logn.Show();
                    }
                    else
                    {
                        MessageBox.Show("The password does not match.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
