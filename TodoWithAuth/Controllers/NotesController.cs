using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;
using TodoWithAuth.Data;
using TodoWithAuth.Models;

namespace TodoWithAuth.Controllers
{
    [Authorize]
    public class NotesController : Controller
    {
        public ApplicationDbContext db;
        public string userId;

        public NotesController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var userId = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            return View(db.Notes
                .Where(item => item.UserId == userId)
                .ToList());
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string description)
        {
            var userId = db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            db.Notes.Add(new Note(title, description, userId));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var note = db.Notes.FirstOrDefault(u => u.Id == id);
            db.Notes.Remove(note);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
