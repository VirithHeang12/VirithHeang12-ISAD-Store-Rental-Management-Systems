using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class Insurance
    {
        public int InsuranceID { get; set; } = default!;
        public string InsuranceName { get; set; } = default!;
        public string InsuranceWebsite { get; set; } = default!;
    }
}
