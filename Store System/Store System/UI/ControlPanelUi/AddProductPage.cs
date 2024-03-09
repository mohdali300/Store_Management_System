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

namespace Store_System.UI
{
    public partial class AddProductPage : UserControl
    {
        ProductService _productService;   
        Product _product; 
        public AddProductPage()
        {
            InitializeComponent();
            _productService = new ProductService();
            _product=new Product();
        }

        private async void AddProductPage_Load(object sender, EventArgs e)
        {
            var Categories =await _productService.GetALlCategories();
            CatComboBox.DataSource = Categories;
            CatComboBox.DisplayMember = "Name";
            CatComboBox.ValueMember = "Code";

        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هل انت متأكد من حذف هذا العنصر؟", "!انتبه", MessageBoxButtons.YesNo);
        }

        private async  void AddProductBtn_Click(object sender, EventArgs e)
        {
            _product.Barcode = int.Parse(barCodeBox.Text);
            _product.Name = productNameBox.Text;
            _product.Cost =double.Parse(costBox.Text);
            _product.SellingPrice = double.Parse(sellingPriceBox.Text);
            _product.StockAmount = int.Parse(stockBox.Text);
            _product.Description = noteBox.Text;
            _product.Discount= double.Parse(discountBox.Text);
            await _productService.AddProduct(_product);
            MessageBox.Show("تمت إضافة العنصر بنجاح", "system", MessageBoxButtons.OK);


        }
    }
}
