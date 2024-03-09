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
    internal class ProductService
    {
        StoreContext _context;
        public ProductService()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddProduct(Product product)
        {
            if (product != null)
            {
                await _context.Product.AddAsync(product);
                await _context.SaveChangesAsync();
                return 1; 
            }
            else {
                return 0;
            }
            
        }
        public async Task<List<Category>> GetALlCategories()
        {
            var Categories = await _context.Category.ToListAsync();
            if (Categories != null)
            {
                return Categories;
            }
            else
            {
                return new List<Category>();
            }
        }
    }
}
