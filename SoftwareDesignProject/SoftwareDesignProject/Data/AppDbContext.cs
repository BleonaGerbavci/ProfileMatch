using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Fakulteti> Fakultetet { get; set; }
        public DbSet<Aplikimi> Aplikimet { get; set; }
        public DbSet<FileDetails> FileDetails { get; set; }
    }
}
