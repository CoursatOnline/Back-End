using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Video { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Course")]
        public int CrsId { get; set; }
        [ForeignKey("_Instructor")]
        public int InsId { get; set; }
        public virtual Course _Course { get; set; }
        public virtual Instructor _Instructor { get; set; }
        public virtual List<Comment>? _Comments { get; set; }
    }
}
