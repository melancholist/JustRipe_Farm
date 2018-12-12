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
    public partial class AddNewIncome : Form
    {
        DbConnector DBConn = new DbConnector();

        public AddNewIncome()
        {
            InitializeComponent();
        }

        //Save information to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Income income = new Income();
            IncomeHandler incomeHandler = new IncomeHandler();

            income.Amount = Decimal.Parse(textBoxAmount.Text);
            income.Date = dateTimePicker1.Value.Date;
            income.Customer = textBoxCustomer.Text;
            income.Category = comboBoxIncome.Text;
            income.Description = textBoxDescription.Text;

            incomeHandler.addNewIncome(DBConn.getConn(), income);
            MessageBox.Show("A new transaction has been added!");

            this.Hide();
        }

        //Clear all
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxCustomer.Text = "";
            this.textBoxAmount.Text = "";
            this.textBoxDescription.Text = "";
            comboBoxIncome.SelectedIndex = -1;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
