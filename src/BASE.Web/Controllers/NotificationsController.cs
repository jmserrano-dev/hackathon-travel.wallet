using BASE.Application.Client.Recommendations.Events;
using BASE.Application.Client.Recommendations.Hotels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BASE.Application.Client.Recommendations.Airports;

namespace BASE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}/hotels")]
        public async Task<ActionResult<HotelsResponse>> Hotels(int id)
        {
            var hotels = await _mediator.Send(new GetHotels { Id = id });
            return hotels;
        }

        [HttpGet("{id}/events")]
        public async Task<ActionResult<EventsResponse>> Events(int id)
        {
            var events = await _mediator.Send(new GetEvents { Id = id });
            return events;
        }

        [HttpGet("{id}/airports")]
        public async Task<ActionResult<AirportsResponse>> Airports(int id)
        {
            var airports = await _mediator.Send(new GetAirports { Id = id });
            return airports;
        }
    }
}