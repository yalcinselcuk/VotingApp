using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Dto.Requests;
using VotingApp.Services;

namespace VotingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUserResponse();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewUserRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastUserId = await _userService.CreateUserAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetUsers), routeValues: new { id = lastUserId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                      //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }
    }
}
