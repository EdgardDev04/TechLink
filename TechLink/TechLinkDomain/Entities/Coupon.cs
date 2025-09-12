using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;

namespace TechLink.Domain.Entities
{
    public class Coupon : BaseEntity
    {
        [Required]
        public string Code { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Discount must be greater than 0.")]
        public decimal Discount { get; set; }

        [Required]
        public DateOnly ExpirationDate { get; set; }
        public bool IsActive { get; set; }

    }
}
