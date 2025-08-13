using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;

namespace TechLink.Domain.Models
{
    public class OrderModel
    {
        public DateTime OrderDate { get; set; }
        public StatusOrder Status { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public int UserId { get; set; }
        public User User { get; set; }
        public int ShippingId { get; set; }
        public Shipping Shipping { get; set; }
        public int CouponId { get; set; }
        public Coupon Coupon { get; set; }
    }
}
