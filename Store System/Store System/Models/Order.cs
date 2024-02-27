using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Order
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public long TotalAmount { get; set; }

    }
}
