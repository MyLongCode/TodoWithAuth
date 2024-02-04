using Microsoft.AspNetCore.Mvc;
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
        // GET: api/<ApiController>
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(db.Users.ToList());
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
