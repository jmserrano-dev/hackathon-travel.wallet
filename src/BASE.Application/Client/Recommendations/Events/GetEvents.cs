using System.Threading;
using System.Threading.Tasks;
using BASE.Application.Client.Cards;
using BASE.Data;
using MediatR;

namespace BASE.Application.Client.Recommendations.Events
{
    public class GetEvents : IRequest<EventsResponse>
    {
        public int Id { get; set; }
    }

    public class GetEventsHandler : IRequestHandler<GetEvents, EventsResponse>
    {
        private readonly BaseContext _context;

        public GetEventsHandler(BaseContext context)
        {
            _context = context;
        }

        Task<EventsResponse> IRequestHandler<GetEvents, EventsResponse>.Handle(GetEvents request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new EventsResponse());
        }
    }
}