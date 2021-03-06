﻿using System;
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
    public partial class AddNewProduct : Form
    {
        DbConnector DBConn = new DbConnector();

        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            Product product = new Product();
            ProductHandler productHandler = new ProductHandler();

            product.ProductName = textBoxProductName.Text;
            product.Price = Decimal.Parse(textBoxPrice.Text);
            product.QuantityAvailable = Convert.ToInt32(textBoxQuantityAvailable.Text);
            product.Category = comboBoxCategory.Text;
            product.Status = comboBoxStatus.Text;
            product.Description = textBoxDescription.Text;

            productHandler.addNewProduct(DBConn.getConn(), product);
            MessageBox.Show("A new product has been added!");

            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxProductName.Text = "";
            this.textBoxPrice.Text = "";
            this.textBoxQuantityAvailable.Text = "";
            this.textBoxDescription.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBoxPrice.Text.IndexOf('.') != 1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46) //8 is backspace
            {
                e.Handled = true;
            }
        }
    }
}
