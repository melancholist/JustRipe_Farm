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
    public partial class RecordTransaction : Form
    {
        RecordTransaction transaction = new RecordTransaction();
        DbConnector DBConn = new DbConnector();

        public RecordTransaction()
        {
            InitializeComponent();
        }

        //Save information to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*DBConn.connect();
            Staff stff = new Staff();
            StaffHandler staffHandlr = new StaffHandler();

            tran.Type = comboBoxType.Text;
            tran.Amount = Decimal.Parse(textBoxAmount.Text);
            tran.Date = dateTimePicker1.Value.Date;
            tran.CustPayee = textBoxCustomerPayee.Text;
            tran.Expense = comboBoxExpense.Text;
            tran.Income = comboBoxIncome.Text;
            tran.Description = textBoxDescription.Text;

            staffHandlr.addNewStaff(DBConn.getConn(), stff);
            MessageBox.Show("A new transaction has been added!");

            this.Hide();
            StaffManagement stf = new StaffManagement();
            stf.Show();*/
        }

        //Clear all
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxCustomerPayee.Text = "";
            this.textBoxAmount.Text = "";
            comboBoxType.SelectedIndex = -1;
            this.textBoxDescription.Text = "";
            comboBoxExpense.SelectedIndex = -1;
            comboBoxIncome.SelectedIndex = -1;
        }

        //Different appearence of comboboxes and labels absed on transaction type
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //INCOME
            if (comboBoxType.SelectedText == "Income")
            {
                lblCustomer.Visible = true;
                lblPayee.Visible = false;
                comboBoxIncome.Visible = true;
                comboBoxExpense.Visible = false;
            }
            //EXPENSE
            else
            {
                lblCustomer.Visible = false;
                lblPayee.Visible = true;
                comboBoxIncome.Visible = false;
                comboBoxExpense.Visible = true;
            }
        }
    }
}
