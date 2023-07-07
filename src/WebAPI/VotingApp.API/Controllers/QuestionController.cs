using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Dto.Requests;
using VotingApp.Services;

namespace VotingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService _questionService)
        {
            this._questionService = _questionService;
        }

        [HttpGet]
        public IActionResult GetQuestions()
        {
            var questions = _questionService.GetQuestionResponse();
            return Ok(questions);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewQuestionRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastQuestionId = await _questionService.CreateQuestionAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetQuestions), routeValues: new { id = lastQuestionId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                      //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }

        [HttpPut("{id}")]//ıdempotent = hep aynı sonuc
        public async Task<IActionResult> Update(int id, UpdateQuestionRequest updateQuestionRequest)
        {
            var isExist = await _questionService.QuestionIsExists(id);
            if (isExist)//varsa güncelleyeceğiz
            {
                if (ModelState.IsValid)//kurallara uyuyor mu
                {
                    await _questionService.UpdateQuestion(updateQuestionRequest);
                    return Ok();//201 de dönebiliriz
                }
                return BadRequest(ModelState);
            }
            return NotFound();//yoksa 
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _questionService.QuestionIsExists(id))//böyle bir şey varsa
            {
                var question = await _questionService.GetQuestionForDeleteAsync(id);
                await _questionService.DeleteQuestion(question);
                return Ok();
            }
            return NotFound();
        }
    }
}
