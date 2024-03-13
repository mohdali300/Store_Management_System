using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Store_System.Services
{
    internal class SupplierService
    {
        StoreContext _context;

        public SupplierService()
        {
            _context = new StoreContext();
        }

        public async Task<int> AddSupplier(Supplier supplier)
        {
            await _context.Supplier.AddAsync(supplier);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Supplier>> GetAllSuppliers()
        {
            var suppliers= await _context.Supplier.ToListAsync();
            if(suppliers!=null)
            {
                return suppliers;
            }
            else
            {
                return new List<Supplier>();
            }
        }

        public async Task<int> DeleteSupplier(string supplierName)
        {
            var supplier = await _context.Supplier.FirstOrDefaultAsync(s => s.Name == supplierName);
            if (supplier != null)
            {
                _context.Supplier.Remove(supplier);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
                return 0;
        }

        

    }
}
