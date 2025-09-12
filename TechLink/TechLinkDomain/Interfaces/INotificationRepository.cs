using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface INotificationRepository 
    {
        Task<Notification> GetByIdAsync(int id);
        Task<List<Notification>> GetByUserIdAsync(int userId, bool onlyUnread = false);
        Task<List<Notification>> GetAllAsync();
        Task AddAsync(Notification notification);
        Task UpdateAsync(Notification notification);
        Task DeleteAsync(int id);
        Task MarkAsReadAsync(int notificationId);
    }

}
