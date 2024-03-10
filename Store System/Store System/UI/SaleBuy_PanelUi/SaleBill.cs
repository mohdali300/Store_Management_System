using Store_System.Data;
using Store_System.Models;
using Store_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI.ControlPanelUi
{
    public partial class SaleBill : UserControl
    {
        CategoryService _categoryService;

        SaleBillService _saleBillService;

        public SaleBill()
        {
            InitializeComponent();
            _saleBillService = new SaleBillService();
            _categoryService = new CategoryService();
        }
        public string CustomerName { get; set; }


        private async void ProductCodeBox_TextChanged(object sender, EventArgs e)
        {
            string barcode = ProductCodeBox.Text;

            Product Product = await _saleBillService.GetProductCode(barcode);

            if (Product != null)
            {
                StoreContext storeContext = new StoreContext();

                ProductCodeBox.Text = Product.Barcode;
                ProductnameBox.Text = Product.Name;
                ClassificationBox.Text = Product.Category.Name;
                QuantityBox.Text = Product.StockAmount.ToString();
                ColorBox.Text = Product.Color;
                SizeBox.Text = Product.Size.ToString();
                SelingPrice.Text = Product.SellingPrice.ToString();
                DiscountBox.Text = Product.Discount.ToString();
            }
            else
            {
                ProductnameBox.Clear();
                ClassificationBox.Text = "";
                QuantityBox.Clear();
                ColorBox.Text = "";
                SizeBox.Text = "";
                SelingPrice.Clear();
                DiscountBox.Clear();
            }
        }

        private async void SaleBill_Load(object sender, EventArgs e)
        {
            Order order = new Order();
            StoreContext storeContext = new StoreContext();
            order.ID = storeContext.Order.Select(o => o.ID).FirstOrDefault(); // last id inserted in database 
            BillCodeBox.Text = (order.ID + 1).ToString(); // add one to last id to insert it ( 0 ==> 0 + 1 = 1 ) ههههه
            var Categories = await _categoryService.GetALlCategories();
            ClassificationBox.DataSource = Categories;
            ClassificationBox.DisplayMember = "Name";
            ClassificationBox.ValueMember = "ID";
            ClassificationBox.SelectedIndex = -1;

        }
        private AddCustomer addCustomer; 

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomer = new AddCustomer(); 
            addCustomer.ShowDialog();
            addCustomer.FormClosed += AddCustomer_FormClosed;
        }

        private void AddCustomer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (addCustomer != null && !string.IsNullOrEmpty(addCustomer.CustomerName))
            {
                _CustomerNameBox.Text = addCustomer.CustomerName;
            }
        }


    }
}
