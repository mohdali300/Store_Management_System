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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ExpandAction = Expand;
        }

        Action<Panel, int> ExpandAction;
        bool isExpand = false;    //to expand menu of each Btn

        void Expand(Panel panel, int Btns)
        {
            if (isExpand == false)
            {
                panel.Height += Btns * 50;
                panel.BringToFront();
                if (panel.Height <= panel.MaximumSize.Height)
                {
                    isExpand = true;
                }

            }

            else
            {
                panel.Height -= Btns * 50;
                if (panel.Height <= panel.MinimumSize.Height)
                {
                    isExpand = false;
                }
            }
        }


        private void orderMenuBtn_Click(object sender, EventArgs e)
        {
            ExpandAction(orderPanel, 3);
        }

        private void stockMenuBtn_Click(object sender, EventArgs e)
        {
            ExpandAction(stockPanel, 2);
        }

        private void reportsMenuBtn_Click(object sender, EventArgs e)
        {
            ExpandAction(reportsPanel, 4);
        }

        private void supCustBtn_Click(object sender, EventArgs e)
        {
            ExpandAction(supplierCustomerPanel, 3);
        }

        private void controlMenuBtn_Click(object sender, EventArgs e)
        {
            ExpandAction(ControlPanel, 4);
        }




    }
}
