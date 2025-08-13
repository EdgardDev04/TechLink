using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly TechLinkDbContext _context;

        public NotificationRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Notification entity)
        {
            _context.Notification.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Notification entity)
        {
            _context.Notification.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _context.Notification.ToListAsync();
        }

        public Task<Notification?> GetByIdAsync(int id)
        {
            var getNotification = _context.Notification.FirstOrDefaultAsync(u => u.Id == id);

            if (getNotification == null)
            {
                throw new Exception("User does not exist");
            }
            return getNotification;
        }

        public async Task<IEnumerable<Notification>> GetUnreadByUserIdAsync(int userId)
        {
            var notification = await _context.Notification.Where(p => p.UserId == userId && p.IsRead == false).ToListAsync();

            if (!notification.Any())
            {
                return null;
            }

            return notification;
        }

        public async Task UpdateAsync(Notification entity)
        {
             _context.Notification.Update(entity);
             await _context.SaveChangesAsync();
        }
    }
}
