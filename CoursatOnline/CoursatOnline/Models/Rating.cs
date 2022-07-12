using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [Required]
        public double Ratio { get; set; }
        //[Range(minimum: 0, maximum: 100)]
        public string Rate_Comment { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [ForeignKey("_Course")]
        [JsonIgnore]
        public int? CrsId { get; set; }
        [JsonIgnore]
        public virtual Course? _Course { get; set; }
        [JsonIgnore]
        public virtual StudentRating? _StudentRating { get; set; }
    }
}
