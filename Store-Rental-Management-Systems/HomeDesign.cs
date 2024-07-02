using Microsoft.Data.SqlClient;
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
    public partial class HomeDesign : FrmHome
    {
        private SqlDataAdapter _storeCountAdapter = new();

        private DataSet _dataSet = new();
        public HomeDesign()
        {
            InitializeComponent();

            _storeCountAdapter.SelectCommand = new SqlCommand("SELECT dbo.fnCountRentedStores()", Program.Connection);

            _storeCountAdapter.Fill(_dataSet);

            lblStoreRentedCount.Text = _dataSet.Tables["Table"]!.Rows[0]["Column1"].ToString();
        }
    }
}
