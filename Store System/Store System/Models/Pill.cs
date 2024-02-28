using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Pill
    {
        [Key]
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public string? QuantityInStock { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public Size Size { get; set; }
        public Color color { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expiry_date { get; set; }
        public DateTime Date { get;set; }
        public string? CustomerName { get; set; }
        public  bool IsSale { get; set; } //  0 for sale , 1 for buy
       
        /// one user to many Pills
        public virtual User user { get; set; }
        [ForeignKey("user")]
        public int user_id { get; set; }
        public virtual List<Pillitems> Pillitems { get; set; }
        public virtual Supplier Supplier  { get; set; }
        [ForeignKey("Supplier")]
        public int Supplier_Id { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
    }
}
