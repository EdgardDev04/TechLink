using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLink.Domain.Models
{
    public class CouponModel
    {
        public string Code { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
