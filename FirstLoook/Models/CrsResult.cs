using System.ComponentModel.DataAnnotations.Schema;

namespace FirstLoook.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public decimal degree { get; set; }
        [ForeignKey("Course")]
        public int crsId { get; set; }
        [ForeignKey("Trainee")]
        public int traineeId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}
