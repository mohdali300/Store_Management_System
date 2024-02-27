using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    internal class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [RegularExpression("^01[0-9]{9}$")]
        [Phone(ErrorMessage ="رقم هاتف غير صالح يرجى ادخال الرقم مرة اخرى ")]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public Role Type { get; set; }
    }
    public enum Role { 
    Admin,
    Cashier,
   }
}
