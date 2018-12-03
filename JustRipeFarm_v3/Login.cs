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
    public partial class Login : Form
    {
        DbConnector DBConn = new DbConnector();
        SqlDataAdapter da;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        //Exit the form
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin adminLogin = new ManagerLogin();
            adminLogin.Show();
        }

        private void resetPasswordLabel_Click(object sender, EventArgs e)
        {
            //Hides this form
            this.Hide();

            //Proceeds to the reset password form
            ResetPasswordLabourer reset = new ResetPasswordLabourer();
            reset.Show();
        }


        private void btnLabourerLogin_Click(object sender, EventArgs e)
        {
            Main mn = new Main();

            if (string.IsNullOrWhiteSpace(txtBoxuLabourer.Text) || string.IsNullOrWhiteSpace(txtBoxpLabourer.Text))
            {
                MessageBox.Show("Please provide Username and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DBConn.connect();
                    string loginQuery = "SELECT Count(*) from LabourerData WHERE Username ='" + txtBoxuLabourer.Text + "' and Password ='" + txtBoxpLabourer.Text + "'";

                    da = new SqlDataAdapter(loginQuery, DBConn.getConn());
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    if (dta.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        mn.Show();

                        mn.lblLabourer.Visible = true;
                        mn.picboxLabourer.Visible = true;
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

        private void txtBoxuLabourer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLabourerLogin.PerformClick();
            }
        }

        private void txtBoxpLabourer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLabourerLogin.PerformClick();
            }
        }
    }
}
