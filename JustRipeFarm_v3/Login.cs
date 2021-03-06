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
    public partial class Login : Form
    {
        DbConnector DBConn = new DbConnector();
        MySqlDataAdapter da;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        //Exit the form
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetPasswordLabel_Click(object sender, EventArgs e)
        {
            //Hides this form
            this.Hide();

            //Proceeds to the reset password form
            ResetPassword reset = new ResetPassword();
            reset.Show();
        }

        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConn.connect();
            string loginQuery = "SELECT *  from staffdata WHERE Username = binary '" + txtBoxUsername.Text + "' and Password = binary '" + txtBoxPassword.Text + "'";

            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text) || string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Please provide Username and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    da = new MySqlDataAdapter(loginQuery, DBConn.getConn());
                    DataTable dta = new DataTable();
                    da.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        Main mn = new Main();
                        this.Hide();
                        mn.Show();

                        string role = dta.Rows[0]["staffRole"].ToString();

                        switch (role)
                        {
                            case "Manager":
                                mn.Show();
                                this.Hide();
                                mn.btnStaffManagement.Visible = true;
                                mn.lblManager.Visible = true;
                                mn.picBoxManager.Visible = true;
                                mn.btnAccounting.Visible = true;
                                mn.btnStock.Visible = true;
                                mn.btnAddStorage.Visible = true;
                                mn.btnAddVehic.Visible = true;
                                mn.btnAddMach.Visible = true;
                                mn.btnAddCrops.Visible = true;
                                mn.btnAddFertilisers.Visible = true;
                                mn.btnAddPesticides.Visible = true;
                                mn.btnAddEquipment.Visible = true;
                                mn.btnUpdateFert.Visible = true;
                                mn.btnUpdatePest.Visible = true;
                                mn.btnPrintCrops.Visible = true;
                                mn.btnPrintFertilisers.Visible = true;
                                mn.btnPrintPesticides.Visible = true;
                                mn.btnPrntEquipment.Visible = true;
                                mn.printStorage.Visible = true;
                                mn.PrintMachine.Visible = true;
                                mn.printVehicle.Visible = true;
                                break;

                            case "Sales Staff":
                                mn.Show();
                                mn.lblSalesStaff.Visible = true;
                                mn.picBoxManager.Visible = true;
                                mn.btnAccounting.Visible = true;
                                mn.btnStock.Visible = true;
                                mn.btnAddStorage.Visible = true;
                                mn.btnAddVehic.Visible = true;
                                mn.btnAddMach.Visible = true;
                                mn.btnAddCrops.Visible = true;
                                mn.btnAddFertilisers.Visible = true;
                                mn.btnAddPesticides.Visible = true;
                                mn.btnAddEquipment.Visible = true;
                                mn.btnUpdateFert.Visible = true;
                                mn.btnUpdatePest.Visible = true;
                                mn.btnPrntEquipment.Visible = true;
                                mn.printStorage.Visible = true;
                                mn.PrintMachine.Visible = true;
                                mn.printVehicle.Visible = true;
                                this.Hide();
                                break;

                            case "Driver":
                                mn.Show();
                                this.Hide();
                                mn.lblLabourer.Visible = true;
                                mn.picboxLabourer.Visible = true;
                                mn.btnUpdateTaskStatus.Visible = true;
                                break;

                            case "Field Worker":
                                mn.Show();
                                this.Hide();
                                mn.lblLabourer.Visible = true;
                                mn.picboxLabourer.Visible = true;
                                mn.btnUpdateTaskStatus.Visible = true;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your username and password is incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
