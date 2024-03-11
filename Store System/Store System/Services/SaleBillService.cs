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
    internal class SaleBillService
    {
        StoreContext _context;
        public SaleBillService()
        {
            _context = new StoreContext();
        }
        public async Task<Product> GetProductCode(string Barcode)
        {
         var Product= await _context.Product.Include(c=>c.Category).FirstOrDefaultAsync(p => p.Barcode == Barcode);
            if(Product != null) {
            return Product;
            }
            else
            {
                return new Product();
            }

        }
        public async Task<List<User>> GetAllUser()
        {
           var Users= await _context.User.ToListAsync();
            return Users;

        }
    }
}
