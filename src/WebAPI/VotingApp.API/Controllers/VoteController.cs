using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Dto.Requests;
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
        public IActionResult GetVotes()
        {
            var votes = _voteService.GetVoteResponse();
            return Ok(votes);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewVoteRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastVoteId = await _voteService.CreateVoteAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetVotes), routeValues: new { id = lastVoteId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                              //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }
    }
}
