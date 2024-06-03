using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper.entities
{
    public class ExpenseType
    {
        public int ExpenseTypeID { get; set; } = default;
        public string ExpenseDescription { get; set; } = default!;
    }
}
