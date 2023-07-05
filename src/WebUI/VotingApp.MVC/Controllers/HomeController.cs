using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VotingApp.MVC.Models;
using VotingApp.Services;

namespace VotingApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPollService pollService;

        public HomeController(ILogger<HomeController> logger, IPollService pollService)
        {
            _logger = logger;
            this.pollService = pollService;
        }

        public IActionResult Index()
        {
            var polls = pollService.GetPollResponse();
            return View(polls);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}