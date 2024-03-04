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
    public partial class AddProductPage : UserControl
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void AddProductPage_Load(object sender, EventArgs e)
        {
            addProductPanel.Visible = false;
            addSupplierPanel.Visible = false;
            productGridViewPanel.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            productsBtn.BackColor = Color.Snow;
            productsBtn.ForeColor = Color.Maroon;
            suppliersBtn.ForeColor = Color.Snow;
            suppliersBtn.BackColor = Color.Maroon;

            addProductPanel.Visible = true;
            productGridViewPanel.Visible = true;
            existProductsLbl.Visible = true;
            addSupplierPanel.Visible = false;
            existSupsLbl.Visible = false;
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            suppliersBtn.BackColor = Color.Snow;
            suppliersBtn.ForeColor = Color.Maroon;
            productsBtn.ForeColor = Color.Snow;
            productsBtn.BackColor = Color.Maroon;

            addSupplierPanel.Visible = true;
            productGridViewPanel.Visible = true;
            existSupsLbl.Visible = true;
            existProductsLbl.Visible = false;
            addProductPanel.Visible = false;
        }
    }
}
