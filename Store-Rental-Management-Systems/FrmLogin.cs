using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Store_Rental_Management_Systems
{
    public partial class FrmLogin : Form
    {
        public static event EventHandler? LoggedIn;

        public FrmLogin()
        {
            InitializeComponent();

            btnLogin.Click += handleBtnLoginClick;
        }

        private void handleBtnLoginClick(object? sender, EventArgs e)
        {
            LoggedIn?.Invoke(this, EventArgs.Empty);
        }
    }
}
