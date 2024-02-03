using Microsoft.AspNetCore.Mvc;

namespace TodoWithAuth.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
