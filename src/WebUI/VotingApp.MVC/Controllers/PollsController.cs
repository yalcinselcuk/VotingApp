using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using VotingApp.Dto.Requests;
using VotingApp.Services;

namespace VotingApp.MVC.Controllers
{
    [Authorize(Roles = "Admin, Editor")]
    public class PollsController : Controller
    {
        private readonly IPollService pollService;
        public PollsController(IPollService pollService)
        {
            this.pollService = pollService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var polls = pollService.GetPollResponse();
            return View(polls);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewPollRequest createNewPollRequest)
        {
            if (!ModelState.IsValid)
            {
                await pollService.CreatePollAsync(createNewPollRequest);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var poll = await pollService.GetPollForUpdateAsync(id);

            return View(poll);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdatePollRequest updatePollRequest)
        {
            if (await pollService.PollIsExists(id))
            {
                if (ModelState.IsValid)
                {
                    await pollService.UpdatePoll(updatePollRequest);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var poll = await pollService.GetPollForDeleteAsync(id);
            return View(poll);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id, DeletePollRequest deletePollRequest)
        {
            if (await pollService.PollIsExists(id))
            {
                if (!ModelState.IsValid)
                {
                    await pollService.DeletePoll(deletePollRequest);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }

            return RedirectToAction("Index"); // Silme işlemi tamamlandıktan sonra yönlendirme yapabilirsiniz
        }
    }
}
