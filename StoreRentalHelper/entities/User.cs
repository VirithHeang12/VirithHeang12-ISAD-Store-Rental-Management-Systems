using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class User
    {
        public int UserID { get; set; } = default;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public int StaffID { get; set; } = default;
        public string StaffName { get; set; } = default!;
        public string StaffPosition { get; set; } = default!;
    }
}
