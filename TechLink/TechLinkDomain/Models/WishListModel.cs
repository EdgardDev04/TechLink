using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Models
{
    public class WishListModel : BaseEntity
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
