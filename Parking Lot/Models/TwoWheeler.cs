using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class TwoWheeler : Vehicle
    {
        private string vehicleNumber;
        private int engineCapacity;
        private string engineType;
        private int seatingCapacity;
        private int fuelCapacity;
        private int maxWeight;
        private string steeringType;

        public TwoWheeler(string vehicleNumber, string vehicleType, string ownerName, int slotID, int engineCapacity, int seatingCapacity, int fuelCapacity, int maxWeight) : base(vehicleNumber, vehicleType, ownerName, slotID)
        {
            VehicleNumber = vehicleNumber;
            EngineCapacity = engineCapacity;
            EngineType = "Petrol";
            SeatingCapacity = seatingCapacity;
            FuelCapacity = fuelCapacity;
            SteeringType = "Handle";
            MaxWeight = maxWeight;
        }

        public string VehicleNumber { get { return vehicleNumber; } set { vehicleNumber = value; } }
        public int EngineCapacity { get { return engineCapacity; } set { engineCapacity = value; } }
        public string EngineType { get { return engineType; } set { engineType = value; } }
        public int SeatingCapacity { get { return seatingCapacity; } set { seatingCapacity = value; } }
        public int FuelCapacity { get { return fuelCapacity; } set { fuelCapacity = value;} }
        public int MaxWeight { get { return maxWeight; } set { maxWeight = value; } }
        public string SteeringType { get { return steeringType; } set { steeringType = value; } }
    }
}
