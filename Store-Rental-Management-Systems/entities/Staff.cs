using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Rental_Management_Systems.entities
{
    public class Staff
    {
        public int StaffID { get; set; } = default;
        public string StaffFirstName { get; set; } = default!;
        public string StaffLastName { get; set; } = default!;
        public char Sex { get; set; } = default;
        public DateOnly BirthDate { get; set; } = default!;
        public string IdentityCardNumber { get; set; } = default!;
        public string StaffPosition { get; set; } = default!;
        public string HouseNo { get; set; } = default!;
        public string StreetNo { get; set; } = default!;
        public string Sangkat {  get; set; } = default!;
        public string Khan {  get; set; } = default!;
        public string ProvinceOrCity { get; set; } = default!;
        public string ContactNumber { get; set; } = default!;
        public string PersonalNumber { get; set; } = default!;
        public double Salary { get; set; } = default;
        public DateOnly HiredDate { get; set; } = default!;
        public byte[] Photo { get; set; } = default!;
    }
}
