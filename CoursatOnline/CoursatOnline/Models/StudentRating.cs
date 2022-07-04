using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class StudentRating
    {
        [ForeignKey("_Student")]
        public int StudentId { get; set; }
        [ForeignKey("_Rate")]
        public int RateId { get; set; }
        public Student _Student { get; set; }
        public Rating _Rate { get; set; }
        public Course _Course { get; set; }
    }
}
