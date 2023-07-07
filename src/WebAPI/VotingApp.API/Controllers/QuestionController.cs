using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
