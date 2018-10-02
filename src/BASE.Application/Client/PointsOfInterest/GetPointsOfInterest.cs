using System.Threading;
using System.Threading.Tasks;
using BASE.Application.Client.Shared;
using BASE.Data;
using MediatR;

namespace BASE.Application.Client.PointsOfInterest
{
    public class GetPointsOfInterest : IRequest<PointsOfInterestResponse>
    {
        public int Id { get; set; }
        public Location Location { get; set; }
    }

    public class GetPointsOfInterestHandler : IRequestHandler<GetPointsOfInterest, PointsOfInterestResponse>
    {
        private readonly BaseContext _context;

        public GetPointsOfInterestHandler(BaseContext context)
        {
            _context = context;
        }

        Task<PointsOfInterestResponse> IRequestHandler<GetPointsOfInterest, PointsOfInterestResponse>.Handle(GetPointsOfInterest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PointsOfInterestResponse());
        }
    }
}