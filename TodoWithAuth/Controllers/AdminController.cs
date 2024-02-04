using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoWithAuth.Data;
using Microsoft.AspNetCore.Authorization;

namespace TodoWithAuth.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
