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

namespace Store_System.UI
{
    public partial class AddSupplierPage : UserControl
    {
        SupplierService supplierService;
        Supplier supplier;

        public AddSupplierPage()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            supplier = new Supplier();
        }



        private async void AddSupplierPage_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliers = await supplierService.GetAllSuppliers();
            existSuppliersGridView.AutoGenerateColumns = false;
            existSuppliersGridView.DataSource = suppliers;

            SupCodeBox.Text = supplier.ID.ToString();
            existSuppliersGridView.Columns["Name"].DataPropertyName = "Name";
            existSuppliersGridView.Columns["phone"].DataPropertyName = "Phone";
            existSuppliersGridView.Columns["Email"].DataPropertyName = "Email";
            existSuppliersGridView.Columns["Address"].DataPropertyName = "Address";
            if (existSuppliersGridView.Columns["ContractDate"] != null)
            {
                existSuppliersGridView.Columns["ContractDate"].DataPropertyName = "ContractDate";
                existSuppliersGridView.Columns["ContractDate"].ValueType = typeof(DateTime);
                existSuppliersGridView.Columns["ContractDate"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";

            }
            existSuppliersGridView.ClearSelection();

        }


        private async void saveSupplierBtn_Click(object sender, EventArgs e)
        {
            if (supplierNameBox.Text != "" && SupPhoneBox.Text != "")
            {
                supplier.Name = supplierNameBox.Text;
                supplier.Email = SupMailBox.Text;
                supplier.Phone = SupPhoneBox.Text;
                supplier.Address = SupAddressBox.Text;
                supplier.ContractDate = contractDateBox.Value;
                await supplierService.AddSupplier(supplier);
                MessageBox.Show("تمت إضافة المورد بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //existSuppliersGridView.Rows.Add(supplierNameBox.Text, SupPhoneBox.Text, SupMailBox.Text, SupAddressBox.Text, contractDateBox.Text);
                RefreshGridView();
                //AddSuppliers();
                Clear();
            }

            else
            {
                if (supplierNameBox.Text == "")
                    nameError.Visible = true;
                else nameError.Visible = false;
                if (SupPhoneBox.Text == "")
                    phoneError.Visible = true;
                else phoneError.Visible = false;
                if (contractDateBox.Text == "")
                    dateError.Visible = true;
                else dateError.Visible = false;
            }
        }

        private void Clear()
        {
            supplierNameBox.Clear();
            SupAddressBox.Clear();
            SupMailBox.Clear();
            SupPhoneBox.Clear();
            contractDateBox.Value = DateTime.Now;
        }

        private async void deleteSupplierBtn_ClickAsync(object sender, EventArgs e)
        {
            MessageBox.Show("هل انت متأكد من حذف هذا العنصر؟", "!system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string SupName = supplierNameBox.Text;
            if (supplierNameBox.Text != "")
            {

                await supplierService.DeleteSupplier(supplierNameBox.Text);
                MessageBox.Show("تم حذف المورد بنجاح", "!system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("يرجى تحديد المورد لحذفه", "!system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            RefreshGridView();
            Clear();
        }


        private async Task RefreshGridView()
        {
            List<Supplier> Suppliers = await supplierService.GetAllSuppliers();

            existSuppliersGridView.DataSource = Suppliers;
        }

        private void existSuppliersGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplierNameBox.Text = existSuppliersGridView.CurrentRow.Cells[0].Value.ToString();
            SupPhoneBox.Text = existSuppliersGridView.CurrentRow.Cells[1].Value.ToString();
            SupMailBox.Text = existSuppliersGridView.CurrentRow.Cells[3].Value.ToString();
            SupAddressBox.Text = existSuppliersGridView.CurrentRow.Cells[2].Value.ToString();
            if (existSuppliersGridView.CurrentRow.Cells[4].Value != null)
            {
                contractDateBox.Text = existSuppliersGridView.CurrentRow.Cells[4].Value.ToString();
            }
        }

        public void AddSuppliers()
        {
            DataGridViewTextBoxColumn boxColumn = new DataGridViewTextBoxColumn();
            boxColumn.DataPropertyName = "dateTime";
            boxColumn.ValueType = typeof(DateTime);
            boxColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            //existSuppliersGridView.Rows.Add(supplierNameBox.Text, SupPhoneBox.Text, SupMailBox.Text, SupAddressBox.Text, dateTimePicker1.Text);
            existSuppliersGridView.CurrentRow.Cells[4].Value = contractDateBox.Value;
        }
    }
}
