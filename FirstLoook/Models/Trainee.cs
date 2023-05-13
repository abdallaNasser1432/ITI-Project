using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstLoook.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        
        public string Image { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<CrsResult> Results { get; set; } = new HashSet<CrsResult>();
    }
}
