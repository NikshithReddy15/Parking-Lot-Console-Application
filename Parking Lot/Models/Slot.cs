using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class Slot
    {
        private int slotID;
        private int price;
        private int vehicleType;
        public Slot(int slot_id, int price, int vehicletype)
        {
            SlotId = slot_id;
            Price = price;
            VehicleType = vehicletype;
        }
        public int SlotId
        {
            get { return slotID; }
            set { slotID = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
    }
}
