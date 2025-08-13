using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Models
{
    public class AddressModel : BaseEntity
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string StateOrProvince { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
