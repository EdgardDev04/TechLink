using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLink.Application.Dtos.Product.Response
{
    public class GetProductByCategoryIdDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
