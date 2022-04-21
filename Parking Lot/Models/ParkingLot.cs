using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot.Models
{
    internal class ParkingLot
    {
        public List<Slot> Slots;
        public List<Staff> Staff;
        public List<Vehicle> Vehicles;
        public List<TwoWheeler> TwoWheelers;
        public List<FourWheeler> FourWheelers;
        public List<HeavyVehicle> HeavyVehicles;
        public List<Ticket> Tickets;

        public ParkingLot()
        {
            Staff = new List<Staff>();
            Slots = new List<Slot>();
            Vehicles = new List<Vehicle>();
            Tickets = new List<Ticket>();
        }

        public void GetSlots()
        {
            var availableSlots = from slot in Slots select slot;
            foreach (var slot in availableSlots)
            {
                Console.WriteLine(slot.SlotId + " - " + slot.VehicleType + " - " + slot.Price);
            }
        }
        public void GetStaff()
        {
            var availableStaff = from staff in Staff select staff;
            foreach (var staff in availableStaff)
            {
                Console.WriteLine(staff.ID + " - " + staff.Name);
            }
        }
        public Ticket GetTicket(int slotId)
        {
            return Tickets.Find(x => x.SlotID == slotId);
        }
    }
}
