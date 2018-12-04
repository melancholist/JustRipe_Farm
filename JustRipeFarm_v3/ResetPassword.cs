using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;


namespace JustRipeFarm_v3
{
    public partial class ResetPassword : Form
    {
        DbConnector dbcon = new DbConnector();

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();

            Login login = new Login();
            login.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dbcon.connect();

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxNewPassword.Text) || string.IsNullOrWhiteSpace(textBoxConfirmPasssword.Text))
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Staff staff = new Staff();
                staff.Username = textBoxUsername.Text;
                staff.Password = textBoxConfirmPasssword.Text;

                StaffHandler stafHandlr = new StaffHandler();
                stafHandlr.resetPassword(dbcon.getConn(), staff);

                if(textBoxUsername.Text == staff.Username && textBoxConfirmPasssword.Text == staff.Password)
                {
                    Login lgn = new Login();
                    lgn.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("The password does not match.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnConfirm.PerformClick();
            }
        }

        private void textBoxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnConfirm.PerformClick();
            }
        }

        private void textBoxConfirmPasssword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnConfirm.PerformClick();
            }
        }
    }
}
