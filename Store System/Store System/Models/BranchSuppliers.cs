using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class BranchSuppliers
    {
        public Branch Branch { get; set; }
        public Supplier Supplier  { get; set; }
        public int Branch_Id { get; set; }
        public int Supplier_Id { get; set; }
    }
}
