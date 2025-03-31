using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Places.Application.Dtos;
using Places.Domain.Entities;
using Places.Infrastructure.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Places.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationsService _notificationsService;
        private readonly IMapper _mapper;

        public NotificationsController(INotificationsService notificationsService, IMapper mapper)
        {
            _notificationsService = notificationsService;
            _mapper = mapper;
        }
    
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetNotifications(string userId)
        {
            var notifications = await _notificationsService.GetNotificationsbyUserId(int.Parse(userId));
            return Ok(notifications);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotification([FromBody] NotificationDto notification)
        {
            var entity = new Notification
            {
                UserId = notification.UserId,
                Message = notification.Message,
                Timestamp = notification.Timestamp,
                IsRead = false
            };
            var notificationResult = await _notificationsService.CreateNotification(entity);
            return Ok(notificationResult);
        }

        [HttpPut("{id}/read")]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            var notification = await _notificationsService.GetNotificationsbyId(id);
            if (notification == null) return NotFound();
            notification.IsRead = true;
            await _notificationsService.UpdateNotification(notification);
            return Ok();
        }
    }

}