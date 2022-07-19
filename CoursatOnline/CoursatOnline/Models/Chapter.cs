using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Chapter
    {
        public int Id { get; set; }


        [Required]
        public string? Title { get; set; }
        public string? Video { get; set; }


        [Required]
        public DateTime DateAdded { get; set; }
        public bool Show { get; set; }


        [ForeignKey("_Course")]
        [JsonIgnore]
        public int? CrsId { get; set; }


        [ForeignKey("_Instructor")]
        [JsonIgnore]

        public int? InsId { get; set; }

        [JsonIgnore]

        public virtual Course? _Course { get; set; }

        [JsonIgnore]
        public virtual Instructor? _Instructor { get; set; }

        [JsonIgnore]

        public virtual List<Comment>? _Comments { get; set; }
    }
}
