using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TODO_LIST_APP.Models;

namespace TODO_LIST_APP.Data
{
    
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // ✅ Allow cascade delete from Note → Comments
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Note)
                .WithMany(n => n.Comments)
                .HasForeignKey(c => c.NoteId)
                .OnDelete(DeleteBehavior.Cascade);

            // ❌ Disable cascade delete from User → Comments
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ❌ Disable cascade delete from User → Notes
            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
