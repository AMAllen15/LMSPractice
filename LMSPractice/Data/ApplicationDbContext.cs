using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LMSPractice.Models;

namespace LMSPractice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LMSPractice.Models.Book> Book { get; set; } = default!;
        public DbSet<LMSPractice.Models.Borrowing> Borrowing { get; set; } = default!;
        public DbSet<LMSPractice.Models.Reader> Reader { get; set; } = default!;
    }
}