using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class StudentRating
    {
        [ForeignKey("_Student")]
        public int StudentId { get; set; }
        [ForeignKey("_Rate")]
        public int RateId { get; set; }

        [ForeignKey("_Course")]
        public int _CourseId { get; set; }

        [JsonIgnore]
        public virtual  Student? _Student { get; set; }

        [JsonIgnore]
        public virtual Rating? _Rate { get; set; }

        [JsonIgnore]

        public virtual Course? _Course { get; set; }
    }
}
