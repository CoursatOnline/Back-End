using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Ratio { get; set; }
        public string Rate_Comment { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("_Course")]
        public int CrsId { get; set; }
        public Course _Course { get; set; }
        public virtual StudentRating _StudentRating { get; set; }
    }
}
