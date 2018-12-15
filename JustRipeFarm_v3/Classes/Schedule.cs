using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Schedule
    {
        private int id;
        private string labourerName;
        private int farmSector;
        private string taskStatus;
        private DateTime startDate;
        private DateTime endDate;

        public int Id { get => id; set => id = value; }
        public string LabourerName { get => labourerName; set => labourerName = value; }
        public int FarmSector { get => farmSector; set => farmSector = value; }
        public string TaskStatus { get => taskStatus; set => taskStatus = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }

    public class Sowing : Schedule
    {
        private string method;
        private string seed;
        private decimal quantity;
        private DateTime startTime;
        private DateTime endTime;

        public string Method { get => method; set => method = value; }
        public string Seed { get => seed; set => seed = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
    }

    public class Harvest : Schedule
    {
        private string method;
        private string storageUnit;
        private string machine;
        private DateTime startTime;
        private DateTime endTime;

        public string Method { get => method; set => method = value; }
        public string StorageUnit { get => storageUnit; set => storageUnit = value; }
        public string Machine { get => machine; set => machine = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
    }

    public class Treating : Schedule
    {
        private string fertiliserUsed;
        private decimal quantity;
        private DateTime startTime;
        private DateTime endTime;

        public string FertiliserUsed { get => fertiliserUsed; set => fertiliserUsed = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
    }

    public class Driving : Schedule
    {
        private string vehicleUsed;

        public string VehicleUsed { get => vehicleUsed; set => vehicleUsed = value; }
    }
}
