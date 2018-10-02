using BASE.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BASE.Application.Client.Flights
{
    public class GetFlights : IRequest<FlightsResponse>
    {
        public int Id { get; set; }
    }

    public class GetCardsHandler : IRequestHandler<GetFlights, FlightsResponse>
    {
        private readonly BaseContext _context;

        public GetCardsHandler(BaseContext context)
        {
            _context = context;
        }
        
        Task<FlightsResponse> IRequestHandler<GetFlights, FlightsResponse>.Handle(GetFlights request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new FlightsResponse());
        }
    }
}