using Microsoft.AspNetCore.Identity;

namespace TODO_LIST_APP.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<Note> Notes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
