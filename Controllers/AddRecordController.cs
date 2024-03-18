using Microsoft.AspNetCore.Mvc;

namespace Cricket_Application.Controllers
{
    public class AddRecordController : Controller
    {
        public IActionResult AddRecord()
        {
            return View();
        }
    }
}
