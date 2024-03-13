using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class BuyBillService
    {
        StoreContext storeContext;

        public BuyBillService()
        {
            storeContext = new StoreContext();
        }


        public async Task<int> AddOrder(Order order)
        {
            if (order != null)
            {
                await storeContext.Order.AddAsync(order);
                int row = await storeContext.SaveChangesAsync();
                return row;
            }
            else
                return 0;
        }


        public int AddOrderItem(OrderItems orderItems)
        {
            if (orderItems != null)
            {
                storeContext.OrderItems.Add(orderItems);
                int row = storeContext.SaveChanges();
                return row;
            }
            else
                return 0;
        }


        public async Task<Order> GetLastOrderID()
        {
            Order id = await storeContext.Order.OrderByDescending(o => o.ID).FirstOrDefaultAsync();
            return id;
        }

        public async Task<Product> GetProductCode(string barcode)
        {
            var Product = await storeContext.Product.Include(c => c.Category).FirstOrDefaultAsync(p => p.Barcode == barcode);
            if (Product != null)
            {
                return Product;
            }
            else
            {
                return new Product();
            }
        }
    }
}
