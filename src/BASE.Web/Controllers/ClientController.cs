using System.Threading.Tasks;
using BASE.Application.Client;
using BASE.Application.Client.Cards;
using BASE.Application.Client.Notifications;
using BASE.Application.Client.PointsOfInterest;
using BASE.Application.Client.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BASE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}/cards")]
        public async Task<ActionResult<CardsResponse>> Cards(int id)
        {
            var cards = await _mediator.Send(new GetCards { Id = id });
            return cards;
        }

        [HttpGet("{id}/flights")]
        public async Task<ActionResult<CardsResponse>> Flights(int id)
        {
            var flights = await _mediator.Send(new GetCards { Id = id });
            return flights;
        }

        [HttpGet("{id}/notifications")]
        public async Task<ActionResult<NotificationsResponse>> Notifications(int id)
        {
            var notifications = await _mediator.Send(new GetNotifications() { Id = id });
            return notifications;
        }

        [HttpGet("{id}/points-of-interest")]
        public async Task<ActionResult<PointsOfInterestResponse>> PointsOfInterest(int id, string latitude, string longitude)
        {
            var pointsOfInterest = await _mediator.Send(new GetPointsOfInterest
            {
                Id = id,
                Location = new Location(latitude, longitude)
            });
            return pointsOfInterest;
        }
    }
}