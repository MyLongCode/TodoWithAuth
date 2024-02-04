using Microsoft.AspNetCore.Identity;

namespace TodoWithAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Id { get; set; }
        public string Email { get; set; }

    }
}
