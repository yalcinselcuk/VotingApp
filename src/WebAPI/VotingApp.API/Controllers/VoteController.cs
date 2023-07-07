using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Services;

namespace VotingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly IVoteService _voteService;
        public VoteController(IVoteService _voteService)
        {
            this._voteService = _voteService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var votes = _voteService.GetVoteResponse();
            return Ok(votes);
        }
    }
}
