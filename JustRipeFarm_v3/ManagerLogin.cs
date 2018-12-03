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
    public partial class ManagerLogin : Form
    {
        DbConnector DBConn = new DbConnector();
        SqlDataAdapter da;

        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            if (string.IsNullOrWhiteSpace(txtBoxuManager.Text) || string.IsNullOrWhiteSpace(txtBoxpManager.Text))
            {
                MessageBox.Show("Please provide Username and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DBConn.connect();
                    string loginQuery = "SELECT Count(*) from Manager WHERE Username ='" + txtBoxuManager.Text + "' and Password ='" + txtBoxpManager.Text + "'";

                    da = new SqlDataAdapter(loginQuery, DBConn.getConn());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        main.Show();

                        main.picBoxManager.Visible = true;
                        main.lblManager.Visible = true;
                        main.btnLabourerManagement.Visible = true;
                        main.manageraccountPictureBox.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Your username and password is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtBoxpManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnManagerLogin.PerformClick();
            }
        }

        private void txtBoxuManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnManagerLogin.PerformClick();
            }
        }

        private void exitAdminLoginPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void resetPasswordLabel_Click(object sender, EventArgs e)
        {
            //Hides this form
            this.Hide();

            //Proceeds to the reset password form
            ResetPasswordManager reset = new ResetPasswordManager();
            reset.Show();
        }
    }
}
