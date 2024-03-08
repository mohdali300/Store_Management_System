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
        public AddCategoryPage()
        {
            InitializeComponent();
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هل انت متأكد من حذف هذا العنصر؟","!انتبه",MessageBoxButtons.YesNo);
        }
    }
}
