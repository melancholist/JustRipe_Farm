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
using System.Data.SqlClient;


namespace JustRipeFarm_v3
{
    public partial class ResetPasswordLabourer : Form
    {
        DbConnector dbcon = new DbConnector();
        SqlDataAdapter da;

        public ResetPasswordLabourer()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();

            Login login = new Login();
            login.Show();
        }

        //Reset Password for Labourer
        private void btnLabourerConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLabrUser.Text) || string.IsNullOrWhiteSpace(textBoxLabrNewPass.Text) || string.IsNullOrWhiteSpace(textBoxLabrConfirmPass.Text))
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    dbcon.connect();
                    string resetQuery = "UPDATE LabourerData SET Password = '" + textBoxLabrConfirmPass.Text + "' WHERE Username = '" + textBoxLabrUser.Text + "'";

                    da = new SqlDataAdapter(resetQuery, dbcon.getConn());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        Login lgn = new Login();
                        this.Hide();
                        lgn.Show();
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
