using FacultyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace FacultyManagement.Data
{
    public class FacultyDbContext : DbContext
    {
        public string DbPath { get; private set; }
        public FacultyDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}facultymanagement.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=FacultyManagementSystemDb;Trusted_Connection=True;");
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = Guid.Parse("bc64a391-91ab-4477-8423-dcc23ed0803b"),
                    UserName = "admin",
                    Password = "123456"
                });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses{ get; set; }
    }
}
