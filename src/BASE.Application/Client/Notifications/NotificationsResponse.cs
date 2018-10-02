using System;
using System.Collections.Generic;

namespace BASE.Application.Client.Notifications
{
    public class NotificationsResponse
    {
        public IEnumerable<Notification> Notifications { get; set; }
    }

    public class Notification
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        
    }
}