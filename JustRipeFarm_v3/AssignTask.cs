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
    public partial class AssignTask : Form
    {
        DbConnector dbconn = new DbConnector();

        public AssignTask()
        {
            InitializeComponent();
        }

        private void AssignTask_Load(object sender, EventArgs e)
        {
            pnlSowing.Visible = true;
            pnlSowing.BringToFront();
        }

        //Buttons to show panels
        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffManagement stffMng = new StaffManagement();
            stffMng.Show();
        }

        private void btnSowing_Click(object sender, EventArgs e)
        {
            while (btnSowing.Enabled)
            {
                pnlSowing.Visible = true;
                pnlSowing.BringToFront();
                break;
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            while (btnHarvest.Enabled)
            {
                pnlHarvest.Visible = true;
                pnlHarvest.BringToFront();
                break;
            }
        }

        private void btnTreating_Click(object sender, EventArgs e)
        {
            while (btnTreating.Enabled)
            {
                pnlTreatment.Visible = true;
                pnlTreatment.BringToFront();
                break;
            }
           
        }

        private void btnDriving_Click(object sender, EventArgs e)
        {
            while (btnDriving.Enabled)
            {
                pnlDriving.Visible = true;
                pnlDriving.BringToFront();
                break;
            }
        }

        //Calender values to input in textbox
        private void monthCalendarSowing_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxSowDate.Text = monthCalendarSowing.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendarHarvest_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxHarvDate.Text = monthCalendarHarvest.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendarTreatment_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxTreatmentDate.Text = monthCalendarTreatment.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendarDriving_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDrivingDate.Text = monthCalendarDriving.SelectionRange.Start.ToShortDateString();
        }

        //Buttons to save data into the database
        private void btnSaveSow_Click(object sender, EventArgs e)
        {
            dbconn.connect();

            Sowing sow = new Sowing();
            sow.LabourerName = comboBoxWorkers.Text;
            sow.FarmSector = int.Parse(comboBoxFarmSectorSow.Text);
            sow.Date = DateTime.ParseExact(textBoxSowDate.Text, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            sow.Method = comboBoxMethods.Text;
            sow.Seed = comboBoxSeeds.Text;
            sow.Quantity = numericUpDownQauntity.Value;
            sow.StartTime = dateTimePickerStartSow.Value.Date;
            sow.EndTime = dateTimePickerEndSow.Value.Date;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.addSowingSchedule(dbconn.getConn(), sow);
            MessageBox.Show("Task Assigned!");
        }

        private void btnSaveHarv_Click(object sender, EventArgs e)
        {
            dbconn.connect();

            Harvest harv = new Harvest();
            harv.LabourerName = comboBoxWorkerHarv.Text;
            harv.FarmSector = int.Parse(comboBoxFarmSectorHarv.Text);
            harv.Date = DateTime.ParseExact(textBoxHarvDate.Text, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            harv.Method = comboBoxHarvestMehtod.Text;
            harv.PlantType = comboBoxPlantType.Text;
            harv.StorageUnit = int.Parse(comboBoxStorageUnit.Text);
            harv.StartTime = dateTimePickerStartHarv.Value.Date;
            harv.EndTime = dateTimePickerEndHarv.Value.Date;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.addHarvestSchedule(dbconn.getConn(), harv);
            MessageBox.Show("Task Assigned!");
        }

        private void btnSaveT_Click(object sender, EventArgs e)
        {
            dbconn.connect();

            Treating trt = new Treating();
            trt.LabourerName = comboBoxWorkerT.Text;
            trt.FarmSector = int.Parse(comboBoxFarmT.Text);
            trt.Date = DateTime.ParseExact(textBoxTreatmentDate.Text, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            trt.FertiliserUsed = comboBoxFertilisers.Text;
            trt.Quantity = numericUpDownFertilisers.Value;
            trt.StartTime = dateTimePickerStartTr.Value.Date;
            trt.EndTime = dateTimePickerEndTr.Value.Date;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.addTreatingSchedule(dbconn.getConn(), trt);
            MessageBox.Show("Task Assigned!");
        }

        private void btnSaveDrive_Click(object sender, EventArgs e)
        {
            dbconn.connect();

            Driving drv = new Driving();
            drv.LabourerName = comboBoxDriver.Text;
            drv.FarmSector = int.Parse(comboBoxFarmD.Text);
            drv.Date = DateTime.ParseExact(textBoxDrivingDate.Text, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            drv.VehicleUsed = comboBoxVehicles.Text;

            ScheduleHandler scHand = new ScheduleHandler();
            scHand.addDrivingSchedule(dbconn.getConn(), drv);
            MessageBox.Show("Task Assigned!");
        }

        //Clears the textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxWorkers.Text = "";
            comboBoxFarmSectorSow.Text = "";
            textBoxSowDate.Text = "";
            comboBoxMethods.Text = "";
            comboBoxSeeds.Text = ""; 
        }

        private void btnClearHarv_Click(object sender, EventArgs e)
        {
            comboBoxWorkerHarv.Text = "";
            comboBoxFarmSectorHarv.Text = "";
            textBoxHarvDate.Text = "";
            comboBoxHarvestMehtod.Text = "";
            comboBoxPlantType.Text = "";
            comboBoxStorageUnit.Text = "";
        }

        private void btnClearT_Click(object sender, EventArgs e)
        {
            comboBoxWorkerT.Text = "";
            comboBoxFarmT.Text = "";
            textBoxTreatmentDate.Text = "";
            comboBoxFertilisers.Text = "";
            numericUpDownFertilisers.Value = 0;
        }

        private void btnClearDrive_Click(object sender, EventArgs e)
        {
            comboBoxDriver.Text = "";
            comboBoxFarmD.Text = "";
            textBoxDrivingDate.Text = "";
            comboBoxVehicles.Text = "";
        }
    }
}
