using Microsoft.AspNetCore.Mvc;

namespace Cricket_Application.Controllers
{
    public class ChangeStatusController : Controller
    {
        public IActionResult ChangeStatus()
        {
            return View();
        }
    }
}
