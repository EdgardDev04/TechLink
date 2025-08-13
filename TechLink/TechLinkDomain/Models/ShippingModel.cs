using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLink.Domain.Models
{
    public class ShippingModel
    {
        public string Carrier { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        public DateTime ShippedDate { get; set; }
        public DateTime EstimatedDelivery { get; set; }
    }
}
