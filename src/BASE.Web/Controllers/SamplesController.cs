using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BASE.Application.Sample;
using BASE.Application.Sample.Response;

namespace BASE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SamplesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Sample>> Get(int id)
        {
            var sample = await _mediator.Send(new GetSample {Id = id});
            return sample;
        }
    }
}
