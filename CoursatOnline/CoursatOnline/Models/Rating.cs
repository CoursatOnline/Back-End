using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [Required]
        public double Ratio { get; set; }
        [Range(minimum: 0, maximum: 100)]
        public string Rate_Comment { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [ForeignKey("_Course")]
        public int CrsId { get; set; }
        public virtual Course? _Course { get; set; }
        public virtual StudentRating? _StudentRating { get; set; }
    }
}
