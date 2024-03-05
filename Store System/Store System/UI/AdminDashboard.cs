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
    }
}
