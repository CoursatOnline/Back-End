using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class StudentRegisters
    {
        [ForeignKey("_Student")]
        public int StdId { get; set; }
        [ForeignKey("_Payment")]
        public int PaymentId { get; set; }
        public virtual Student _Student { get; set; }
        public virtual Payment _Payment { get; set; }
        public virtual Course _Course { get; set; }
    }
}
