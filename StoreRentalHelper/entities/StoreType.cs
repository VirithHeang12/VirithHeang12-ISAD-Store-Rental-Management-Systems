using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class StoreType
    {
        public int StoreTypeID { get; set; } = default;
        public string StoreTypeDescription { get; set; } = default!;

        public double MonthlyLeasePrice { get; set; } = default;
        public byte ThreeMonthPaymentDiscount { get; set; } = default;
        public byte SixMonthPaymentDiscount { get; set; } = default;
        public byte OneYearPaymentDiscount { get; set; } = default;
    }
}
