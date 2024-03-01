using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class OrderItems
    {
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Product")]
        public int product_Id { get; set; }
        [ForeignKey("Order")]

        public int Order_Id { get; set; }

       
    }
}
