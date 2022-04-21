using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    internal class Staff
    {
        private int staffID;
        private string name;
        public Staff(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
