using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Pillitems
    {
        public virtual Product Product { get; set; }
        public virtual Pill Pill { get; set; }

        public int product_Id { get; set; }

        public int Pill_Id { get; set; }
    }
}
