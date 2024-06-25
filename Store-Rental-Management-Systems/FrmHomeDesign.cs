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




namespace Store_Rental_Management_Systems
{

    public partial class FrmHomeDesign : FrmHome
    {
        public FrmHomeDesign()
        {

            InitializeComponent();


            #region Get All Counts 
            GetRentedStores();
            GetAllStores();
            GetAllStaffs();
            GetAllCustomers();
            GetAllInsurances();
            #endregion

        }

        #region GetRentedStores
        private void GetRentedStores()
        {
            string rentedStoreCount = HomeDesignHelper.GetRentedStoreCount(Program.Connection);
            label5.Text = rentedStoreCount;
        }

        #endregion

        #region GetAllStores
        private void GetAllStores()
        {
            string allStoresCount = HomeDesignHelper.GetAllStores(Program.Connection);
            label3.Text = allStoresCount;
        }
        #endregion

        #region GetAllStaffs
        private void GetAllStaffs()
        {
            string allStaffsCount = HomeDesignHelper.GetAllStaffs(Program.Connection);
            label7.Text = allStaffsCount;
        }
        #endregion

        #region GetAllCustomers
        private void GetAllCustomers()
        {
            string allCustomersCount = HomeDesignHelper.GetAllCustomers(Program.Connection);
            label9.Text = allCustomersCount;
        }
        #endregion

        #region GetAllInsurances
        private void GetAllInsurances()
        {
            string allCustomersCount = HomeDesignHelper.GetAllInsurances(Program.Connection);
            label11.Text = allCustomersCount;
        }
        #endregion
    }
}
