using Microsoft.EntityFrameworkCore;

namespace Lab14.Models
{
    public class EnrollmentContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1507-14\\SQLEXPRESS03; Database=Lab14; Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
