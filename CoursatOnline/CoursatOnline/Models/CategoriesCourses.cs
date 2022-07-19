using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class CategoriesCourses
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("_Category")]
        public int CatId { get; set; }


        [ForeignKey("_Course")]
        public int CourseId { get; set; }

        public DateTime DateAdded { get; set; }
        public bool Show { get; set; }

        [JsonIgnore]
        public virtual Category? _Category { get; set; }

       [JsonIgnore]
        public virtual Course? _Course { get; set; }
    }
}
