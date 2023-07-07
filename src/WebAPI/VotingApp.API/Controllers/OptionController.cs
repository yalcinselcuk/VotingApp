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

        [HttpPut("{id}")]//ıdempotent = hep aynı sonuc
        public async Task<IActionResult> Update(int id, UpdateOptionRequest updateOptionRequest)
        {
            var isExist = await _optionService.OptionIsExists(id);
            if (isExist)//varsa güncelleyeceğiz
            {
                if (ModelState.IsValid)//kurallara uyuyor mu
                {
                    await _optionService.UpdateOption(updateOptionRequest);
                    return Ok();//201 de dönebiliriz
                }
                return BadRequest(ModelState);
            }
            return NotFound();//yoksa 
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _optionService.OptionIsExists(id))//böyle bir şey varsa
            {
                var option = await _optionService.GetOptionForDeleteAsync(id);
                await _optionService.DeleteOption(option);
                return Ok();
            }
            return NotFound();
        }
    }
}
