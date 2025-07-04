namespace TODO_LIST_APP.Models
{
    public class Note 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
