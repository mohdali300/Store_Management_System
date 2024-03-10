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
    internal class CategoryService
    {
        StoreContext _context;
        public CategoryService()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddCategory(Category Category)
        {
            if (Category != null)
            {
                await _context.Category.AddAsync(Category);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public async Task<bool> IsUniqe(int code)
        {
          Category category=  await _context.Category.FirstOrDefaultAsync(c => c.Code == code);
            if (category == null)
            {
                return true;
            }
            else
                return false;
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
        public async Task<int> DeleteCategory(int code)
        {
            var category = await _context.Category.FirstOrDefaultAsync(u => u.Code == code);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
                return 0;
        }
       
    }
}
