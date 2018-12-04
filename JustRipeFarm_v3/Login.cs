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

namespace JustRipeFarm_v3
{
    public partial class Login : Form
    {
        DbConnector DBConn = new DbConnector();
        Main mn = new Main();
        MySqlDataAdapter da;

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
            System.Environment.Exit(1);
        }

        private void resetPasswordLabel_Click(object sender, EventArgs e)
        {
            //Hides this form
            this.Hide();

            //Proceeds to the reset password form
            ResetPassword reset = new ResetPassword();
            reset.Show();
        }

        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            string loginQuery = "SELECT *  from staffdata WHERE Username ='" + txtBoxUsername.Text + "' and Password ='" + txtBoxPassword.Text + "'";

            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text) || string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Please provide Username and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    da = new MySqlDataAdapter(loginQuery, DBConn.getConn());
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        this.Hide();
                        mn.Show();

                        string role = dta.Rows[0]["staffRole"].ToString();

                        switch (role)
                        {
                            case "Manager":
                                mn.Show();
                                this.Hide();
                                mn.btnStaffManagement.Visible = true;
                                mn.lblManager.Visible = true;
                                mn.picBoxManager.Visible = true;
                                break;

                            case "Sales Staff":
                                mn.Show();
                                this.Hide();
                                break;

                            case "Driver":
                                mn.Show();
                                this.Hide();
                                mn.lblLabourer.Visible = true;
                                mn.picboxLabourer.Visible = true;
                                break;

                            case "Field Worker":
                                mn.Show();
                                this.Hide();
                                mn.lblLabourer.Visible = true;
                                mn.picboxLabourer.Visible = true;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your username and password is incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
