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
    public partial class FrmStaff : Form
    {
        public BindingSource StaffBindingSource { get; set; }
        public FrmStaff()
        {
            InitializeComponent();
            StaffBindingSource = new BindingSource();

            this.Load += LoadAllStaffs;
        }

        private void LoadAllStaffs(object? sender, EventArgs e)
        {
            var staffs = StaffHelper.GetAllStaffs(Program.Connection);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
