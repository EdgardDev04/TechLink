using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;

namespace TechLink.Domain.Entities
{
    public class WishList : BaseEntity
    {
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
