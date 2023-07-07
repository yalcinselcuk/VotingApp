using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Dto.Requests;
using VotingApp.Services;

namespace VotingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionService _optionService;
        public OptionController(IOptionService _optionService)
        {
            this._optionService = _optionService;
        }

        [HttpGet]
        public IActionResult GetOptions()
        {
            var options = _optionService.GetOptionResponse();
            return Ok(options);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewOptionRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastOptiontId = await _optionService.CreateOptionAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetOptions), routeValues: new { id = lastOptiontId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                           //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }
    }
}
