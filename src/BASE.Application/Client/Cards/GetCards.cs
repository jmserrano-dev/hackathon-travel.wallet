using System.Collections.Generic;
using BASE.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BASE.Application.Client.Cards
{
    public class GetCards : IRequest<CardsResponse>
    {
        public int Id { get; set; }
    }

    public class GetCardsHandler : IRequestHandler<GetCards, CardsResponse>
    {
        private readonly BaseContext _context;

        public GetCardsHandler(BaseContext context)
        {
            _context = context;
        }
        
        Task<CardsResponse> IRequestHandler<GetCards, CardsResponse>.Handle(GetCards request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CardsResponse());
        }

        //private CardsResponse CardsMock()
        //{
        //    return new CardsResponse { new Cards }
        //}
    }
}