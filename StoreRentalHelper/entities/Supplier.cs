using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class Supplier
    {
        public int SupplierID { get; set; } = default;
        public string SupplierName { get; set; } = default!;
        public string ContactNumber { get; set; } = default!;
        public string SupplierAddress { get; set; } = default!;
    }
}
