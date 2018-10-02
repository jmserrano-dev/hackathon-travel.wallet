using BASE.Application.Client.Shared;
using BASE.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BASE.Application.Client.Recommendations.Airports
{
    public class GetAirports : IRequest<AirportsResponse>
    {
        public int Id { get; set; }
        public Location Location { get; set; }
    }

    public class GetAirportstHandler : IRequestHandler<GetAirports, AirportsResponse>
    {
        private readonly BaseContext _context;

        public GetAirportstHandler(BaseContext context)
        {
            _context = context;
        }

        Task<AirportsResponse> IRequestHandler<GetAirports, AirportsResponse>.Handle(GetAirports request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(new AirportsResponse());
        }
    }
}