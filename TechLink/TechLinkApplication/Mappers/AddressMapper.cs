using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Address;
using TechLink.Application.Dtos.Address.Request;
using TechLink.Application.Dtos.User;
using TechLink.Domain.Entities;

namespace TechLink.Application.Mappers
{
    public static class AddressMapper
    {
        public static AddressDto ToAddressDto(this Address addressModel)
        {
            return new AddressDto
            { 
                Id = addressModel.Id,
                Street = addressModel.Street,
                City = addressModel.City,
                StateOrProvince = addressModel.StateOrProvince,
                PostalCode = addressModel.PostalCode,
                Country = addressModel.Country
            };
        }

        public static AddressDto ToAddressEntity(this AddressDto dto)
        {
            return new AddressDto
            {
                Id = dto.Id,
                Street = dto.Street,
                City = dto.City,
                StateOrProvince = dto.StateOrProvince,
                PostalCode = dto.PostalCode,
                Country = dto.Country
            };
        }

        public static Address ToAddressFromCreatedDto(this CreateAddressDto dto)
        {
            return new Address
            {
                Street = dto.Street,
                City = dto.City,
                StateOrProvince = dto.StateOrProvince,
                PostalCode = dto.PostalCode,
                Country = dto.Country
            };
        }

        public static Address ToAddressFromUpdateDto(this UpdateAddressDto dto)
        {
            return new Address
            {
                Street = dto.Street,
                City = dto.City,
                StateOrProvince = dto.StateOrProvince,
                PostalCode = dto.PostalCode,
                Country = dto.Country
            };
        }
    }
}
