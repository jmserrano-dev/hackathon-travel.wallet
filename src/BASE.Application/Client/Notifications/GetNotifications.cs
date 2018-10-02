using System.Threading;
using System.Threading.Tasks;
using BASE.Data;
using MediatR;

namespace BASE.Application.Client.Notifications
{
    public class GetNotifications : IRequest<NotificationsResponse>
    {
        public int Id { get; set; }
    }

    public class GetNotificationsHandler : IRequestHandler<GetNotifications, NotificationsResponse>
    {
        private readonly BaseContext _context;

        public GetNotificationsHandler(BaseContext context)
        {
            _context = context;
        }
        
        Task<NotificationsResponse> IRequestHandler<GetNotifications, NotificationsResponse>.Handle(GetNotifications request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new NotificationsResponse());
        }
    }
}