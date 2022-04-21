using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class EnumTypes
    {
    }
}

public enum CustomerType
{
    Owner = 0, Staff = 1
}
public enum VehicleType
{
    TwoWheeler = 1, FourWheeler = 2, HeavyVehicles = 3
}
public enum Availability
{
    Parked = 0, Unparked = 1
}
