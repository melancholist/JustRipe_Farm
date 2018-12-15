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
    public partial class UpdateTaskStatus : Form
    {
        DbConnector dbcon = new DbConnector();

        public UpdateTaskStatus()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Driving Task
        private void btnDrive_Click(object sender, EventArgs e)
        {
            groupBoxDriv.Visible = true;
            groupBoxHarv.Visible = false;
            groupBoxTreat.Visible = false;
            groupBoxUpSow.Visible = false;
        }
        private void btnUpdDrv_Click(object sender, EventArgs e)
        {
            dbcon.connect();
            Driving drv = new Driving();
            drv.LabourerName = txtBoxDrv.Text;
            drv.TaskStatus = comBoxUpdDrvTask.Text;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.updateDrvTask(dbcon.getConn(), drv);
            MessageBox.Show("Task Updated!");
        }
        private void btnDrvClear_Click(object sender, EventArgs e)
        {
            txtBoxDrv.Text = "";
            comBoxUpdDrvTask.Text = "";
        }

        //Treatment Task
        private void btnTreat_Click(object sender, EventArgs e)
        {
            groupBoxDriv.Visible = false;
            groupBoxHarv.Visible = false;
            groupBoxTreat.Visible = true;
            groupBoxUpSow.Visible = false;
        }
        private void btnUpdTreat_Click(object sender, EventArgs e)
        {
            dbcon.connect();
            Treating trt = new Treating();
            trt.LabourerName = txtBoxTrtLabr.Text;
            trt.TaskStatus = comBoxUpdTrtTask.Text;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.updateTrtTask(dbcon.getConn(), trt);
            MessageBox.Show("Task Updated!");
        }
        private void btnTrtClear_Click(object sender, EventArgs e)
        {
            txtBoxTrtLabr.Text = "";
            comBoxUpdTrtTask.Text = "";
        }

        //Harvest Task
        private void btnHarv_Click(object sender, EventArgs e)
        {
            groupBoxDriv.Visible = false;
            groupBoxHarv.Visible = true;
            groupBoxTreat.Visible = false;
            groupBoxUpSow.Visible = false;
        }
        private void btnHarvUpd_Click(object sender, EventArgs e)
        {
            dbcon.connect();
            Harvest harv = new Harvest();
            harv.LabourerName = txtBoxHarvLabr.Text;
            harv.TaskStatus = comBoxUpdHarvTask.Text;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.updateHarvTask(dbcon.getConn(), harv);
            MessageBox.Show("Task Updated!");
        }
        private void btnHarvClear_Click(object sender, EventArgs e)
        {
            txtBoxHarvLabr.Text = "";
            comBoxUpdHarvTask.Text = "";
        }

        //Sowing Task
        private void btnSow_Click(object sender, EventArgs e)
        {
            groupBoxDriv.Visible = false;
            groupBoxHarv.Visible = false;
            groupBoxTreat.Visible = false;
            groupBoxUpSow.Visible = true;
        }
        private void btnSowUpd_Click(object sender, EventArgs e)
        {
            dbcon.connect();
            Sowing sow = new Sowing();
            sow.LabourerName = txtBoxSowLabr.Text;
            sow.TaskStatus = comBoxUpdSowTask.Text;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.updateSowTask(dbcon.getConn(), sow);
            MessageBox.Show("Task Updated!");
        }
        private void btnSowClear_Click(object sender, EventArgs e)
        {
            txtBoxSowLabr.Text = "";
            comBoxUpdSowTask.Text = "";
        }
    }
}
