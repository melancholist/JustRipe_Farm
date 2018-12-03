﻿using System;
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
    public partial class LabourerManagement : Form
    {
        public LabourerManagement()
        {
            InitializeComponent();
            pnlAddLabourer.Show();
            pnlBtnIndic1.Show();
        }

        private void backpictureBox_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            main.picBoxManager.Visible = true;
            main.lblManager.Visible = true;
            main.btnLabourerManagement.Visible = true;
            main.manageraccountPictureBox.Visible = true;

            this.Hide();
        }

        private void btnAddLabourer_Click(object sender, EventArgs e)
        {
            pnlAddLabourer.Show();

            if(btnAddLabourer.Enabled)
            {
                pnlBtnIndic1.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            ageTextBox.Text = "";
            sexComboBox.Text = "";
            maritalComboBox.Text = "";
            addressRichTextBox.Text = "";
            zipTextBox.Text = "";
            nricTextBox.Text = "";
            handphoneTextBox.Text = "";
            houseTextBox.Text = "";
            statusComboBox.Text = "";
            wageTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            Labourer labr = new Labourer();
            labr.FirstName1 = fnameTextBox.Text;
            labr.LastName1 = lnameTextBox.Text;
            labr.Age1 = Decimal.Parse(ageTextBox.Text);
            labr.Sex1 = sexComboBox.Text;
            labr.MaritalStatus1 = maritalComboBox.Text;
            labr.Address1 = addressRichTextBox.Text;
            labr.ZipCode1 = zipTextBox.Text;
            labr.NRIC1 = nricTextBox.Text;
            labr.DateOfBirth1 = birthDateTimePicker.Value.Date;
            labr.HandphoneNumber1 = handphoneTextBox.Text;
            labr.HouseNumber1 = houseTextBox.Text;
            labr.Status1 = statusComboBox.Text;
            labr.DateOfHire1 = hireDateTimePicker.Value.Date;
            labr.HourlyWage1 = Decimal.Parse(wageTextBox.Text);
            labr.Username1 = usernameTextBox.Text;
            labr.Password1 = passwordTextBox.Text;


            LabourerHandler labHnd = new LabourerHandler();
            labHnd.addNewLabourer(dbConn.getConn(), labr);
            MessageBox.Show("Labourer record has been added!");

            //Clears the textboxes
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            ageTextBox.Text = "";
            sexComboBox.Text = "";
            maritalComboBox.Text = "";
            addressRichTextBox.Text = "";
            zipTextBox.Text = "";
            nricTextBox.Text = "";
            handphoneTextBox.Text = "";
            houseTextBox.Text = "";
            statusComboBox.Text = "";
            wageTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            
        }
    }
}
