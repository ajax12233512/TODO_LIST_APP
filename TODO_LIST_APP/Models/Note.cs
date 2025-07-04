using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TODO_LIST_APP.Models
{
    public class Note 
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [ValidateNever]
        public DateTime CreatedAt { get; set; }
        [ValidateNever]
        public string UserId { get; set; }
        [ValidateNever]
        public AppUser User { get; set; }
        [ValidateNever]
        public ICollection<Comment> Comments { get; set; }
    }
}
