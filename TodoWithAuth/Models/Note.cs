﻿

using Microsoft.AspNetCore.Identity;

namespace TodoWithAuth.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId{ get; set; }
        public IdentityUser User { get; set; }

        public Note(string title, string description, string userId)
        {
            Title = title;
            Description = description;
            UserId = userId;
        }
    }
}
