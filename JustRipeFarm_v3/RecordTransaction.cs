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
    public partial class RecordTransaction : Form
    {
        public RecordTransaction()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

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
