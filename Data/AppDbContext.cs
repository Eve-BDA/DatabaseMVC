using Microsoft.EntityFrameworkCore;
using DatabaseMVC.Models;

namespace DatabaseMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Coursework> Courseworks { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Rubric> Rubrics { get; set; }
    }
}
