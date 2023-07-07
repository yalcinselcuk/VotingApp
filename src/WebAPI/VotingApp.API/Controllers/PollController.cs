using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Services;

namespace VotingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollController : ControllerBase
    {
        private readonly IPollService _pollService;
        public PollController(IPollService _pollService)
        {
            this._pollService = _pollService;
        }

        [HttpGet]
        public IActionResult GetPolls()
        {
            var polls = _pollService.GetPollResponse();
            return Ok(polls);
        }
    }
}
