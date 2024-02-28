using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class ProductsSuppliers
    {
        public virtual Supplier Supplier { get; set; }
        public virtual Product Product  { get; set; }
        public int product_Id { get; set; }
        public int Supplier_Id { get; set; }
    }
}
