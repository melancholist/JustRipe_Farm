using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm_v3
{
    public partial class AddStaff : Form
    {
        StaffManagement staff = new StaffManagement();
        DbConnector DBConn = new DbConnector();

        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Staff stff = new Staff();
            StaffHandler staffHandlr = new StaffHandler();


            stff.FirstName = fnameTextBox.Text;
            stff.LastName = lnameTextBox.Text;
            stff.Age = Decimal.Parse(ageTextBox.Text);
            stff.Sex = sexComboBox.Text;
            stff.Address = addressRichTextBox.Text;
            stff.ZipCode = zipTextBox.Text;
            stff.ContactNumber = contactTextBox.Text;
            stff.StaffRole = roleComboBox.Text;
            stff.LoginStatus = statusComboBox.Text;
            stff.DateOfHire = hiredDateTimePicker.Value.Date;
            stff.HourlyWage = Decimal.Parse(wageTextBox.Text);
            stff.Username = usernameTextBox.Text;
            stff.Password = passwordTextBox.Text;

            staffHandlr.addNewStaff(DBConn.getConn(), stff);
            MessageBox.Show("A new staff has been added!");

        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffManagement stf = new StaffManagement();
            stf.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            ageTextBox.Text = "";
            sexComboBox.Text = "";
            addressRichTextBox.Text = "";
            zipTextBox.Text = "";
            contactTextBox.Text = "";
            roleComboBox.Text = "";
            statusComboBox.Text = "";
            wageTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
