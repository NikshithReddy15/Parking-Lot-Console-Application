using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class Owner
    {
        private string ownerName;
        private string regVehicleNumber;
        public Owner()
        {
            Console.WriteLine("Please enter your name: ");
            Name = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your vehicle registration number:");
            RegVehicleNumber = Console.ReadLine().Trim();
        }
        public string Name
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public string RegVehicleNumber
        {
            get { return regVehicleNumber; }
            set { regVehicleNumber = value; }
        }
    }
}
