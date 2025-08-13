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
    public class ProductModel
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public StatusProduct State { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
