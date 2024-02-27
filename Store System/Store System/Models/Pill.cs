using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Pill
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public string? QuantityInStock { get; set; }
        public double SellingPrice { get; set; }
        public double Cost { get; set; }
        public double Discount { get; set; }
        public int Size { get; set; }
        public Color color { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expiry_date { get; set; }
        public DateTime Time { get;set; }

    }
}
