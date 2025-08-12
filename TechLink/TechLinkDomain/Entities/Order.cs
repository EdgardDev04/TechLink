using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;
using TechLink.Domain.Enums;

namespace TechLink.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public StatusOrder Status { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total amount must be non-negative.")]
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        
        [ForeignKey(nameof(Shipping))]
        public int ShippingId { get; set; }
        public Shipping Shipping { get; set; }

        [ForeignKey(nameof(Coupon))]
        public int CouponId { get; set; } 
        public Coupon Coupon { get; set; }
    }
}
