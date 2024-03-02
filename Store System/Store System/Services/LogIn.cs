using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using Store_System.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class Login
    {
        StoreContext context = new StoreContext();
        public async Task<User> AdminLogIn(string userName)
        {
           User? user= await context.User.FirstOrDefaultAsync(x => x.UserName == userName);
           return  user;         
        }
    }
}
