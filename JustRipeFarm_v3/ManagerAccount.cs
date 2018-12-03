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
    public partial class ManagerAccount : Form
    {
        public ManagerAccount()
        {
            InitializeComponent();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            main.picBoxManager.Visible = true;
            main.lblManager.Visible = true;
            main.btnLabourerManagement.Visible = true;
            main.manageraccountPictureBox.Visible = true;

            this.Close();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            Manager mang = new Manager();
            mang.FirstName1 = fnameTextBox.Text;
            mang.LastName1 = lnameTextBox.Text;
            mang.Age1 = Decimal.Parse(ageTextBox.Text);
            mang.Sex1 = sexComboBox.Text;
            mang.Address1 = addressTextBox.Text;
            mang.ContactNumber1 = contactTextBox.Text;
            mang.Username1 = usernameTextBox.Text;
            mang.Password1 = passwordTextBox.Text;

            ManagerHandler mangHandler = new ManagerHandler();
            mangHandler.addNewManager(dbConn.getConn(), mang);
            MessageBox.Show("Record Saved!");

            //Clears textboxes
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            ageTextBox.Text = "";
            sexComboBox.Text = "";
            addressTextBox.Text = "";
            contactTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
