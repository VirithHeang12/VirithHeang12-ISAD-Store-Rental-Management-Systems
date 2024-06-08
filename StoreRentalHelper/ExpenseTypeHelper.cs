using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public static class ExpenseTypeHelper
    {
        public static SqlConnection Connection { get; set; } = default!;
    }
}
