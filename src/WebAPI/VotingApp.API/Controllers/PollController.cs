using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Dto.Requests;
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

        [HttpGet("{id:int}")]//iki tane aynı get metodu çakışacağından diğerini belirtmemiz, ayırt etmemiz gerekiyor
        public IActionResult GetPolls(int id)
        {
            var polls = _pollService.GetPolls(id);
            if (polls == null)
            {
                return NotFound();
            }
            return Ok(polls);
        }

        [HttpGet("[action]")]//action dediğimizde artık metod adına göre cagirir
        public async Task<IActionResult> SearchPollByName(string name)
        {
            var polls = await _pollService.SearchByName(name);
            return Ok(polls);
        }
        //controller'da iki tane default httpget olmaz 

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewPollRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastPollId = await _pollService.CreatePollAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetPolls), routeValues: new { id = lastPollId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                           //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }

    }
}
