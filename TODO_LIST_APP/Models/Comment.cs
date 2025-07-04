namespace TODO_LIST_APP.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int NoteId { get; set; }
        public Note Note { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
