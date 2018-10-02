using BASE.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BASE.Application.Client.Recommendations.Hotels
{
    public class GetHotels : IRequest<HotelsResponse>
    {
        public int Id { get; set; }
    }

    public class GetHotelsHandler : IRequestHandler<GetHotels, HotelsResponse>
    {
        private readonly BaseContext _context;

        public GetHotelsHandler(BaseContext context)
        {
            _context = context;
        }

        public Task<HotelsResponse> Handle(GetHotels request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new HotelsResponse());
        }
    }
}