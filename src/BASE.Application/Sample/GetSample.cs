using BASE.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BASE.Application.Sample
{
    public class GetSample : IRequest<Response.Sample>
    {
        public int Id { get; set; }
    }

    public class GetTestHandler : IRequestHandler<GetSample, Response.Sample>
    {
        private readonly BaseContext _context;

        public GetTestHandler(BaseContext context)
        {
            _context = context;
        }

        public async Task<Response.Sample> Handle(GetSample request, CancellationToken cancellationToken)
        {
            var test = await _context.Tests.FindAsync(request.Id);
            return new Response.Sample{ Id = test.Id, Name = test.Name };
        }
    }
}
