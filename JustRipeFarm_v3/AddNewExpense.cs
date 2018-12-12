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
    public partial class AddNewExpense : Form
    {
        AddNewExpense expense = new AddNewExpense();
        DbConnector DBConn = new DbConnector();

        public AddNewExpense()
        {
            InitializeComponent();
        }

        //Clear all
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxPayee.Text = "";
            this.textBoxAmount.Text = "";
            this.textBoxDescription.Text = "";
            comboBoxExpense.SelectedIndex = -1;
        }

        //Save information to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Expense expense = new Expense();
            ExpenseHandler expenseHandler = new ExpenseHandler();

            expense.Amount = Decimal.Parse(textBoxAmount.Text);
            expense.Date = dateTimePicker1.Value.Date;
            expense.Payee = textBoxPayee.Text;
            expense.Category = comboBoxExpense.Text;
            expense.Description = textBoxDescription.Text;

            expenseHandler.addNewExpense(DBConn.getConn(), expense);
            MessageBox.Show("A new transaction has been added!");

            this.Hide();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
