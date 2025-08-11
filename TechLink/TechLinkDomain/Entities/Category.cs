using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;
using TechLink.Domain.Enums;

namespace TechLink.Domain.Entities
{
    public class Category : BaseEntity
    {
        public CategoryType Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

