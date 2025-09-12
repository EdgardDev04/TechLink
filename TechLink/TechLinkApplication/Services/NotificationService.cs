using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Notification.Request;
using TechLink.Application.Dtos.Notification.Response;

namespace TechLink.Application.Services
{
    public class NotificationService : INotificationService
    {
        public Task<int> CreateAsync(CreateNotificationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetNotificationByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUnreadCountAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task MarkAllAsReadAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task MarkAsReadAsync(int notificationId)
        {
            throw new NotImplementedException();
        }
    }
}
