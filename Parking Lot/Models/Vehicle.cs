namespace Parking_Lot.Models
{
    internal class Vehicle
    {
        private string vehicleNumber;
        private string vehicleType;
        private string ownerName;
        private int? slotID;
        public Vehicle(string vehicleNumber, string vehicleType, string ownerName, int slotID)
        {
            VehicleNumber = vehicleNumber;
            VehicleType = vehicleType;
            OwnerName = ownerName;
            SlotID = slotID;
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
        public int? SlotID
        {
            get { return slotID; }
            set { slotID = value; }
        }
    }
}
