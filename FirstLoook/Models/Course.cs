using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstLoook.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public decimal MinDegree { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<CrsResult> Results { get; set; } = new HashSet<CrsResult>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
