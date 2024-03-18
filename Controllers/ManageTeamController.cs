using Microsoft.AspNetCore.Mvc;

namespace Cricket_Application.Controllers
{
    public class ManageTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
