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
        Staff stff = new Staff();
        StaffManagement staff = new StaffManagement();
        StaffHandler staffHandlr = new StaffHandler();
        DbConnector DBConn = new DbConnector();

        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (staff.btnAddManager.Enabled)
            {
                DBConn.connect();
                stff.FirstName = fnameTextBox.Text;
                stff.LastName = lnameTextBox.Text;
                stff.Age = Decimal.Parse(ageTextBox.Text);
                stff.Sex = sexComboBox.Text;
                stff.Address = addressRichTextBox.Text;
                stff.ZipCode = zipTextBox.Text;
                stff.ContactNumber = contactTextBox.Text;
                stff.StaffRole = lblManagerRole.Text;
                stff.LoginStatus = statusComboBox.Text;
                stff.Username = usernameTextBox.Text;
                stff.Password = passwordTextBox.Text;

                staffHandlr.addNewManager(DBConn.getConn(), stff);
                MessageBox.Show("A new Manager has been added!");
            }

            if (staff.btnAddLabourer.Enabled)
            {
                DBConn.connect();
                stff.FirstName = fnameTextBox.Text;
                stff.LastName = lnameTextBox.Text;
                stff.Age = Decimal.Parse(ageTextBox.Text);
                stff.Sex = sexComboBox.Text;
                stff.Address = addressRichTextBox.Text;
                stff.ZipCode = zipTextBox.Text;
                stff.ContactNumber = contactTextBox.Text;
                stff.StaffRole = labourerComboBox.Text;
                stff.LoginStatus = statusComboBox.Text;
                stff.DateOfHire = hiredDateTimePicker.Value.Date;
                stff.HourlyWage = Decimal.Parse(wageTextBox.Text);
                stff.Username = usernameTextBox.Text;
                stff.Password = passwordTextBox.Text;

                staffHandlr.addNewLabourer(DBConn.getConn(), stff);
                MessageBox.Show("A new Labourer has been added!");
            }

            if (staff.btnAddSalesStaff.Enabled)
            {
                DBConn.connect();
                stff.FirstName = fnameTextBox.Text;
                stff.LastName = lnameTextBox.Text;
                stff.Age = Decimal.Parse(ageTextBox.Text);
                stff.Sex = sexComboBox.Text;
                stff.Address = addressRichTextBox.Text;
                stff.ZipCode = zipTextBox.Text;
                stff.ContactNumber = contactTextBox.Text;
                stff.StaffRole = lblSalesStaff.Text;
                stff.LoginStatus = statusComboBox.Text;
                stff.Username = usernameTextBox.Text;
                stff.Password = passwordTextBox.Text;

                staffHandlr.addNewSalesStaff(DBConn.getConn(), stff);
                MessageBox.Show("A new Sales Staff has been added!");
            }

            stff.FirstName = "";
            stff.LastName = "";
            stff.Age = Decimal.Parse("");
            stff.Sex = "";
            stff.Address = "";
            stff.ZipCode = "";
            stff.ContactNumber = "";
            stff.StaffRole = "";
            stff.LoginStatus = "";
            stff.Username = "";
            stff.Password = "";
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffManagement stf = new StaffManagement();
            stf.Show();
        }
    }
}
