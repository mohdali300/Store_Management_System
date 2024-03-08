using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            addUserPage1.Visible = false;
            addProductPage1.Visible = false;
            addCategoryPage1.Visible = false;
            addSupplierPage1.Visible = false;
            mainStockPage1.Visible = false;
            shortFallsPage1.Visible = false;
            buyBill1.Visible = false;
            saleBill1.Visible = false;
            returnedItems1.Visible = false;
            shiftLock1.Visible = false;

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            addUserPage1.Visible = true;
            addUserPage1.BringToFront();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addProductPage1.Visible = true;
            addProductPage1.BringToFront();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            addCategoryPage1.Visible = true;
            addCategoryPage1.BringToFront();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            addSupplierPage1.Visible = true;
            addSupplierPage1.BringToFront();
        }

        private void mainStockBtn_Click(object sender, EventArgs e)
        {
            mainStockPage1.Visible = true;
            mainStockPage1.BringToFront();
        }

        private void shortFallsBtn_Click(object sender, EventArgs e)
        {
            shortFallsPage1.Visible = true;
            shortFallsPage1.BringToFront();
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            welcomePage1.Visible = true;
            welcomePage1.BringToFront();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close(); //this.Hide();
        }

        private void buyBillBtn_Click(object sender, EventArgs e)
        {
            buyBill1.Visible = true;
            buyBill1.BringToFront();
        }

        private void saleBillBtn_Click(object sender, EventArgs e)
        {
            saleBill1.Visible = true;
            saleBill1.BringToFront();
        }

        private void returnedBillBtn_Click(object sender, EventArgs e)
        {
            returnedItems1.Visible = true;
            returnedItems1.BringToFront();
        }

        private void shiftLockBtn_Click(object sender, EventArgs e)
        {
            shiftLock1.Visible = true;
            shiftLock1.BringToFront();
        }
    }
}
