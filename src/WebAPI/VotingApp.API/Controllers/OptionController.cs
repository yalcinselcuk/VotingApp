using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
