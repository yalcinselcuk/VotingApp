using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VotingApp.Services;
using VotingApp.MVC.Models;
using VotingApp.Dto.Requests;

namespace VotingApp.MVC.Controllers
{
    public class UsersController : Controller
    {
        private IUserService userService;
        private readonly IPollService pollService;

        public UsersController(IUserService userService, IPollService pollService)
        {
            this.userService = userService;
            this.pollService = pollService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string? gidilecekSayfa)
        {
            ViewBag.ReturnUrl = gidilecekSayfa;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel, string? gidilecekSayfa)
        {
            if (ModelState.IsValid)
            {

                var user = userService.ValidateUser(userLoginViewModel.UserName, userLoginViewModel.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]//claim = istek
                    {
                        new Claim(ClaimTypes.Name, user.FirstName),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    if (!string.IsNullOrEmpty(gidilecekSayfa) && Url.IsLocalUrl(gidilecekSayfa))
                    {
                        return Redirect(gidilecekSayfa);
                    }
                    return Redirect("/");
                }
                ModelState.AddModelError("login", "Kullanıcı adı veya şifre yanlış");
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateNewUserRequest createNewUserRequest)
        {
            if (ModelState.IsValid)
            {
                await userService.CreateUserAsync(createNewUserRequest);
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
    }
}
