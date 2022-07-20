using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class StudentRegisters
    {
        [ForeignKey("_Student")]
        public int StdId { get; set; }
        [ForeignKey("_Payment")]
        public int PaymentId { get; set; }
        [ForeignKey("_Course")]
        public int CourseId { get; set; }
        [JsonIgnore]
        public virtual Student? _Student { get; set; }
        [JsonIgnore]
        public virtual Payment? _Payment { get; set; }
        [JsonIgnore]
        public virtual Course? _Course { get; set; }
    }
}
