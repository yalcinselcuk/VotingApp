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

        [HttpPut("{id}")]//ıdempotent = hep aynı sonuc
        public async Task<IActionResult> Update(int id, UpdateVoteRequest updateVoteRequest)
        {
            var isExist = await _voteService.VoteIsExists(id);
            if (isExist)//varsa güncelleyeceğiz
            {
                if (ModelState.IsValid)//kurallara uyuyor mu
                {
                    await _voteService.UpdateVote(updateVoteRequest);
                    return Ok();//201 de dönebiliriz
                }
                return BadRequest(ModelState);
            }
            return NotFound();//yoksa 
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _voteService.VoteIsExists(id))//böyle bir şey varsa
            {
                var vote = await _voteService.GetVoteForDeleteAsync(id);
                await _voteService.DeleteVote(vote);
                return Ok();
            }
            return NotFound();
        }
    }
}
