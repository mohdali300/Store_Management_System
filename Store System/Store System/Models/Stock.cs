using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Stock
    {
        [Key]
        public int ID { get; set; }
        public int QuantityInStock { get; set; }
        public int MinQuantity { get; set; }
    }
}
