using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;
using TodoWithAuth.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoWithAuth.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        ApplicationDbContext db;
        public ApiController(ApplicationDbContext context) => db = context;

        [Route("user")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(db.Users.ToList());
        }
        [Route("user/{id}")]
        [HttpGet("{id}")]
        public IActionResult Get(string? id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return BadRequest("user not found");
            return Ok(user);
        }
        [Route("user/")]
        [HttpDelete]
        public void Post([FromBody] string value)
        {
        }

    }
}
