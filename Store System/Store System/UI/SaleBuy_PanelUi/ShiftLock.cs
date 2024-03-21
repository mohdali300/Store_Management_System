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
    public partial class ShiftLock : UserControl
    {
        //SaleBill saleBill;
        //ShiftLockService _shiftLockService;
        //OrderItems orderItem;
        //Order order;


        public ShiftLock()
        {
            InitializeComponent();

            //saleBill = new SaleBill();
            //_shiftLockService = new ShiftLockService();
            //orderItem= new OrderItems();
            //order = new Order();

            //GetUserMoneyStock();
        }

        //public void GetUserMoneyStock()
        //{

        //    var query =
        //        order.OrderItems.Where(o => o.Order_Id == order.ID)
        //        .Sum(o => o.FaturaPaidPrice);

        //    int userMoneyStock = (int)query;

        //    PriceBox.Text=userMoneyStock.ToString();
        //}
    }
}
