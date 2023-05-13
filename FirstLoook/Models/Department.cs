using System.Collections.Generic;

namespace FirstLoook.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manger_Name { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
