using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class Supplier
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        [RegularExpression("^01[0-9]{9}$")]
        [Phone(ErrorMessage = "رقم هاتف غير صالح يرجى ادخال الرقم مرة اخرى ")]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
