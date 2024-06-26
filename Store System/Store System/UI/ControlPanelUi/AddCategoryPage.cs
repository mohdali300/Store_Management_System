﻿using Store_System.Models;
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

    public partial class AddCategoryPage : UserControl
    {
        private readonly CategoryService _categoryService;
        private readonly Category _category;

        public AddCategoryPage()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            _category = new Category();
        }

        private async void deleteCategoryBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذا العنصر؟", "!انتبه", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (categoryCodeBox.Text != "")
                {

                    int isDeleted = await _categoryService.DeleteCategory(int.Parse(categoryCodeBox.Text));
                    if (isDeleted == 1)
                    {
                        MessageBox.Show("تم حذف التصنيف بنجاح", "system", MessageBoxButtons.OK);
                        Clear();
                        existCategoriesGridView.ClearSelection();
                        await RefreshGridView();

                    }
                }
                else
                {
                    MessageBox.Show("قم بتحديد تصنيف لحذفه اولا", "system", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }

        private async void AddCatBtn_Click(object sender, EventArgs e)
        {
            if (categoryCodeBox.Text != "" && catNameBox.Text != "")
            {
                if (await _categoryService.IsUniqe(int.Parse(categoryCodeBox.Text)))
                {
                    _category.Code = int.Parse(categoryCodeBox.Text);
                    _category.Name = catNameBox.Text;
                    _category.Description = catDescriptionBox.Text;
                    await _categoryService.AddCategory(_category);
                    MessageBox.Show("تمت إضافة التصنيف بنجاح", "System", MessageBoxButtons.YesNo);
                    Clear();
                    await RefreshGridView();
                    existCategoriesGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("هذا الكود موجود من قبل ", "System", MessageBoxButtons.YesNo);
                }
            }
            else
            {
                MessageBox.Show("يرجى إدخال جميع البيانات المطلوبة", "System", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void existCategoriesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            categoryCodeBox.Text = existCategoriesGridView.CurrentRow.Cells[1].Value.ToString();
            catNameBox.Text = existCategoriesGridView.CurrentRow.Cells[0].Value.ToString();
            catDescriptionBox.Text = existCategoriesGridView.CurrentRow.Cells[2].Value.ToString();

        }
        private async Task RefreshGridView()
        {
            List<Category> Suppliers = await _categoryService.GetALlCategories();

            existCategoriesGridView.DataSource = Suppliers;
        }

        private async void AddCategoryPage_Load(object sender, EventArgs e)
        {
            var Categories = await _categoryService.GetALlCategories();
            existCategoriesGridView.AutoGenerateColumns = false;
            existCategoriesGridView.DataSource = Categories;
            existCategoriesGridView.Columns["_name"].DataPropertyName = "Name";
            existCategoriesGridView.Columns["Code"].DataPropertyName = "Code";
            existCategoriesGridView.Columns["Discription"].DataPropertyName = "Description";
            existCategoriesGridView.ClearSelection();
        }
        private void Clear()
        {
            categoryCodeBox.Clear();
            catNameBox.Clear();
            catDescriptionBox.Clear();
        }

        private async void searchCatBox_TextChanged(object sender, EventArgs e)
        {
            if (searchCatBox.Text == "")
            {
              await  RefreshGridView();
            }
            else
            {
                var Products = await _categoryService.Search(searchCatBox.Text);
                existCategoriesGridView.DataSource = Products;
            }
        }
    }
}
