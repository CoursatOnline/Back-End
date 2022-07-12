using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Chapter")]
        [JsonIgnore]
        public int? ChapterId { get; set; }
        [ForeignKey("_User")]
        [JsonIgnore]
        public int? UserId { get; set; }
        [JsonIgnore]
        public virtual Chapter? _Chapter { get; set; }
        [JsonIgnore]
        public virtual User? _User { get; set; }
    }
}
