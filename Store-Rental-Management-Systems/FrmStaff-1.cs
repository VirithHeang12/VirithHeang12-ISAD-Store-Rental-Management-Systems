using Microsoft.Data.SqlClient;
using StoreRentalHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public partial class FrmStaff1 : Form
    {
        public BindingSource StaffBindingSource {  get; set; }
        public FrmStaff1()
        {
            InitializeComponent();
            StaffBindingSource = new BindingSource();

            this.Load += LoadAllStaffs;
        }

        private void LoadAllStaffs(object? sender, EventArgs e)
        {
            var staffs = StaffHelper.GetAllStaffs(Program.Connection);
        }
    }
}
