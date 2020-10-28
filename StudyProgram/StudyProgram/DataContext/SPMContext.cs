using Microsoft.EntityFrameworkCore;
using StudyProgram.Entity;
using System.Security.Cryptography.X509Certificates;

namespace StudyProgram.DataContext
{
    public class SPMContext : DbContext
    {
        public SPMContext(DbContextOptions<SPMContext> options) : base(options) { }
        public DbSet<Book> Book { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Course_Faculty_Mapping> Course_Faculty_Mapping { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Course_Speciality_Mapping> Course_Speciality_Mapping { get; set; }
        public DbSet<Entity.Faculty_Speciality_Mapping> Faculty_Speciality_Mapping { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Speciality_Subject_Mapping> Speciality_Subject_Mapping { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Subject_Detail> Subject_Detail { get; set; }
        public DbSet<System_MasterData> System_MasterData { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<User_Detail> User_Detail { get; set; }
        public DbSet<User_Role> User_Role { get; set; }



    }
}
