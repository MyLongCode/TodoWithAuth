using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;
using TodoWithAuth.Data;

namespace TodoWithAuth.Controllers
{
    [Authorize]
    public class NotesController : Controller
    {
        public ApplicationDbContext db;

        public NotesController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var asdfasdf = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var authUserId = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            return View(db.Notes
                .Where(item => item.UserId == authUserId.Id)
                .ToList());
            
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
