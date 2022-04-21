using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class Ticket
    {
        private int? slotID;
        private string vehicleNumber;
        private string vehicleType;
        private string ownerName;
        private DateTime parkingTime;
        private DateTime unparkingTime;
        public Ticket(int slotID, string vehicleNumber, string vehicleType, string ownerName, DateTime parkingTime)
        {
            SlotID = slotID;
            VehicleNumber = vehicleNumber;
            VehicleType = vehicleType;
            OwnerName = ownerName;
            ParkingTime = parkingTime;
        }
        public int? SlotID
        {
            get { return slotID; }
            set { slotID = value; }
        }
        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }
        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public DateTime ParkingTime
        {
            get { return parkingTime; }
            set { parkingTime = value; }
        }
        public DateTime UnparkingTime
        {
            get { return unparkingTime; }
            set { unparkingTime = value; }
        }
    }
}
