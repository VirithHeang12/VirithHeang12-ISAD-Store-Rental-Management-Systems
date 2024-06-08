using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRentalHelper
{
    public class TableStatus
    {
        public DataTable Table { get; set; } = default!;
        public DataRow[] Addeds => Table.Select(null, null, DataViewRowState.Added);
        public bool HasAdded => Addeds.Length > 0;
        public DataRow[] Modifieds => Table.Select(null, null, DataViewRowState.ModifiedCurrent);
        public bool HasModified => Modifieds.Length > 0;
        public bool HasAnyEffected => (HasAdded || HasModified);
    }
}
