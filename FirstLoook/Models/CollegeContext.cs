using Microsoft.EntityFrameworkCore;

namespace FirstLoook.Models
{
    public class CollegeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-822AO13\\SQLSERVER;Initial Catalog=Collage;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<CrsResult> Results { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

    }
}
