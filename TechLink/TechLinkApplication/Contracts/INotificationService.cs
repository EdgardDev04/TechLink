using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Notification.Request;
using TechLink.Application.Dtos.Notification.Response;

namespace TechLink.Application.Contracts
{
    public interface INotificationService
    {
        Task<GetNotificationByIdDto> GetByIdAsync(int id);
        Task<int> CreateAsync(CreateNotificationDto dto);
        Task MarkAsReadAsync(int notificationId);
        Task MarkAllAsReadAsync(int userId);
        Task DeleteAsync(int id);
        Task DeleteAllByUserIdAsync(int userId);
        Task<int> GetUnreadCountAsync(int userId);
    }
}
