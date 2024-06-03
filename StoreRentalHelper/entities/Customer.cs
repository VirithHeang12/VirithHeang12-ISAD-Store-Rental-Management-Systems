using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class Customer
    {
        public int CustomerID { get; set; } = default;
        public string CustomerFirstName { get; set; } = default!;
        public string CustomerLastName { get; set; } = default!;
        public char Sex { get; set; } = default;
        public DateOnly BirthDate { get; set; } = default!;
        public string IdentityCardNumber { get; set; } = default!;
        public string HouseNo { get; set; } = default!;
        public string StreetNo { get; set; } = default!;
        public string Sangkat { get; set; } = default!;
        public string Khan { get; set; } = default!;
        public string ProvinceOrCity { get; set; } = default!;
        public string ContactNumber { get; set; } = default!;
        public byte[] Photo { get; set; } = default!;
        public string FullName => $"{CustomerFirstName} {CustomerLastName}";
        public bool IsFemale => Sex == 'F';
        public bool IsMale => Sex == 'M';
    }
}
