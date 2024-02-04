using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoWithAuth.Data;
using Microsoft.AspNetCore.Authorization;

namespace TodoWithAuth.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        public ApplicationDbContext db;
        public AdminController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
