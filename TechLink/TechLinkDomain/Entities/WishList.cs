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
        public List<WishListProduct> WishListProducts { get; set; } = new List<WishListProduct>();
        public List<Product> Products { get; set; } = new List<Product>();
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
