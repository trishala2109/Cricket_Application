using Cricket_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cricket_Application.Controllers
{
    public class CreateTeamController : Controller
    {
        public IActionResult CreateTeam(CreateTeam createTeam)
        {
            if (ModelState.IsValid)
            {
                CreateTeamDBHandler ihandler = new CreateTeamDBHandler();
                if (ihandler.insertCreateTeam(createTeam))
                {
                    ViewBag.message = "Record Inserted Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

    }
}
