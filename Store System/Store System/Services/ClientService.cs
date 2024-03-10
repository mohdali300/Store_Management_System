using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class ClientService
    {
        StoreContext _context;
        public ClientService()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddCustomer(Customer customer)
        {
            if(customer != null) {
                await _context.Customer.AddAsync(customer);
               await _context.SaveChangesAsync();
                return 1;
            
            }
            else
            {
                return 0;
            }

        }
    }
}
