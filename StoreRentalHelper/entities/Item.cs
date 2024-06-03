using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class Item
    {
        public int ItemID { get; set; } = default;
        public string ItemDescription { get; set; } = default!;
        public int StockQty { get; set; } = default;
        public double UnitPrice { get; set; } = default;
        public string Category { get; set; } = default!;
        public string Unit { get; set; } = default!;

    }
}
