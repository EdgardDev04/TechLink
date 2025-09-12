using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Shipping.Request;
using TechLink.Application.Dtos.Shipping.Response;

namespace TechLink.Application.Contracts
{
    public interface IShippingService
    {
        Task<GetShippingByIdDto> GetByIdAsync(int id);
        Task<List<GetAllShippingDto>> GetAllAsync();
        Task<int> CreateAsync(CreateShippingDto dto);
        Task UpdateAsync(int id, UpdateShippingDto dto);
        Task DeleteAsync(int id);
        Task AssignShippingToOrderAsync(int orderId, int shippingId);
        Task<GetShippingByOrderIdDto> GetShippingByOrderIdAsync(int orderId);
        Task UpdateShippingStatusAsync(int shippingId, string status); 
        Task<List<GetShipmentsByCarrierDto>> GetShipmentsByCarrierAsync(string carrier);
        Task<bool> TrackShipmentAsync(int shippingId, out string trackingInfo); 
        Task<decimal> CalculateShippingCostAsync(ShippingCalculationRequestDto request);
        Task<DateTime> EstimateDeliveryDateAsync(ShippingEstimationRequestDto request);
    }
}
