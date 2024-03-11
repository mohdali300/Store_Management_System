using Store_System.Data;
using Store_System.Migrations;
using Store_System.Models;
using Store_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                ProductCodeBox.Text = Product.Barcode;
                ProductnameBox.Text = Product.Name;
                ClassificationBox.Text = Product.Category.Name;
                ColorBox.Text = Product.Color;
                SizeBox.Text = Product.Size.ToString();
                SelingPrice.Text = Product.SellingPrice.ToString();
                QuantityBox.Text = 1.ToString();
                _discountBox.Text = "";
            }
            else
            {
                ProductnameBox.Clear();
                ClassificationBox.Text = "";
                QuantityBox.Clear();
                ColorBox.Text = "";
                SizeBox.Text = "";
                SelingPrice.Clear();
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
            ProductCodeBox.Focus();
            var users=  await _saleBillService.GetAllUser();
            CustomerBox.DataSource = users;
            CustomerBox.DisplayMember = "Name";
            CustomerBox.ValueMember= "ID";

        }
        private AddCustomer addCustomer;

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomer = new AddCustomer();
            addCustomer.FormClosed += AddCustomer_FormClosed;
            addCustomer.ShowDialog();

        }

        private void AddCustomer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (addCustomer != null && !string.IsNullOrEmpty(addCustomer.CustomerName))
            {
                _CustomerNameBox.Text = addCustomer.CustomerName;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (_discountBox.Text == "")
            {
                _discountBox.Text = 0.ToString();
            }
            double Quantity = int.Parse(QuantityBox.Text);
            double Price = double.Parse(SelingPrice.Text);
            double Discount = double.Parse(_discountBox.Text);
            double TotalPrice = Quantity * Price;
            double afterDiscount = (TotalPrice * (1 - (Discount / 100)));
            string formattedResult = afterDiscount.ToString("0.000");
            Items.Rows.Add(ProductCodeBox.Text, ProductnameBox.Text, ClassificationBox.Text, QuantityBox.Text, ColorBox.Text, SizeBox.Text, SelingPrice.Text, _discountBox.Text, formattedResult, NotesBox.Text);

            ///------------------------------------------------------
            double sum = 0;
            for (int i = 0; i < Items.Rows.Count - 1; ++i)
            {
                sum += double.Parse(Items.Rows[i].Cells[8].Value.ToString());
            }
            TotalPriceBox.Text = sum.ToString("C3", new CultureInfo("ar-EG"));
            AfterDiscount.Text= sum.ToString("C3", new CultureInfo("ar-EG"));
            PaidUp.Text= sum.ToString("C3", new CultureInfo("ar-EG"));

        }

        private void Items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductCodeBox.Text = Items.CurrentRow.Cells[0].Value.ToString();
            ProductnameBox.Text = Items.CurrentRow.Cells[1].Value.ToString();
            ClassificationBox.Text = Items.CurrentRow.Cells[2].Value.ToString();
            QuantityBox.Text = Items.CurrentRow.Cells[3].Value.ToString();
            ColorBox.Text = Items.CurrentRow.Cells[4].Value.ToString();
            SizeBox.Text = Items.CurrentRow.Cells[5].Value.ToString();
            SelingPrice.Text = Items.CurrentRow.Cells[6].Value.ToString();
            _discountBox.Text = Items.CurrentRow.Cells[7].Value.ToString();
            NotesBox.Text = Items.CurrentRow.Cells[9].Value.ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (_discountBox.Text == "")
            {
                _discountBox.Text = 0.ToString();
            }
            double Quantity = int.Parse(QuantityBox.Text);
            double Price = double.Parse(SelingPrice.Text);
            double Discount = double.Parse(_discountBox.Text);
            double TotalPrice = Quantity * Price;
            double AfterDiscount = TotalPrice * (1 - (Discount / 100));
            string formattedResult = AfterDiscount.ToString("0.000");


            Items.CurrentRow.Cells[0].Value = ProductCodeBox.Text;
            Items.CurrentRow.Cells[1].Value = ProductnameBox.Text;
            Items.CurrentRow.Cells[2].Value = ClassificationBox.Text;
            Items.CurrentRow.Cells[3].Value = QuantityBox.Text;
            Items.CurrentRow.Cells[4].Value = ColorBox.Text;
            Items.CurrentRow.Cells[5].Value = SizeBox.Text;
            Items.CurrentRow.Cells[6].Value = SelingPrice.Text;
            Items.CurrentRow.Cells[7].Value = _discountBox.Text;
            Items.CurrentRow.Cells[8].Value = formattedResult;
            Items.CurrentRow.Cells[9].Value = NotesBox.Text;

        }
        private void Clear()
        {
            ProductCodeBox.Clear();
            ProductnameBox.Clear();
            ClassificationBox.Text = "";
            QuantityBox.Clear();
            ColorBox.Clear();
            SizeBox.Text = "";
            _discountBox.Clear();
            SelingPrice.Clear();
            NotesBox.Clear();

        }

        private void FaturaDiscountBox_TextChanged(object sender, EventArgs e)
        {
            if (FaturaDiscountBox.Text == "") {
                FaturaDiscountBox.Text = 0.ToString();
            }
            double TotalPrice = double.Parse(TotalPriceBox.Text,NumberStyles.Currency, new CultureInfo("ar-EG"));
            double Discount=double.Parse(FaturaDiscountBox.Text);
            double FinalPrice =   ((Discount / 100) - 1) * TotalPrice;
            AfterDiscount.Text = FinalPrice.ToString("C3", new CultureInfo("ar-EG"));
            PaidUp.Text= FinalPrice.ToString("C3", new CultureInfo("ar-EG")); 
        }
    }
}
