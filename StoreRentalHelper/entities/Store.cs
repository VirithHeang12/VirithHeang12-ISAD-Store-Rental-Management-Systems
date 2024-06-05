using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class Store
    {
        public int StoreID { get; set; } = default;
        public byte FloorNumber { get; set; } = default;
        public int ElectricityLastRecord { get; set; } = default;
        public int WaterLastRecord { get; set; } = default;
        public bool Status { get; set; } = default;
        public int StoreTypeID { get; set; } = default;
    }
}
