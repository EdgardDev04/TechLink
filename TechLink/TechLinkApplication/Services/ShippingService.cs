using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Shipping.Request;
using TechLink.Application.Dtos.Shipping.Response;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository _repo;

        public ShippingService(IShippingRepository repo)
        {
            _repo = repo;
        }

        public Task AssignShippingToOrderAsync(int orderId, int shippingId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> CalculateShippingCostAsync(ShippingCalculationRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateShippingDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DateTime> EstimateDeliveryDateAsync(ShippingEstimationRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllShippingDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetShippingByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetShipmentsByCarrierDto>> GetShipmentsByCarrierAsync(string carrier)
        {
            throw new NotImplementedException();
        }

        public Task<GetShippingByOrderIdDto> GetShippingByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TrackShipmentAsync(int shippingId, out string trackingInfo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateShippingDto dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateShippingStatusAsync(int shippingId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
