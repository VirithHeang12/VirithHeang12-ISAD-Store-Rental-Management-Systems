using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class SalaryPayment
    {
        public int SalaryPaymentID { get; set; } = default;
        public DateOnly SalaryPaymentDate { get; set; } = default;
        public decimal SalaryPaymentAmount { get; set; } = default;
        public int StaffID { get; set; } = default;
        public string StaffName { get; set; } = default!;
        public string StaffPosition { get; set; } = default!;
    }
}
