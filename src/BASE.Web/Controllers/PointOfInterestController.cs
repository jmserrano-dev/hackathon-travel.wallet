using System.Threading.Tasks;
using BASE.Application.Client;
using BASE.Application.Client.Cards;
using BASE.Application.Client.PointsOfInterest;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BASE.Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PointOfInterestController : Controller
    {
        private readonly IMediator _mediator;

        public PointOfInterestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
    }
}