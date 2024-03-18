using Microsoft.AspNetCore.Mvc;

namespace Cricket_Application.Controllers
{
    public class CreateTeamController : Controller
    {
        public IActionResult CreateTeam()
        {
            return View();
        }
        
    }
}
