using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Chapter")]
        public int ChapterId { get; set; }
        [ForeignKey("_User")]
        public int UserId { get; set; }
        public Chapter _Chapter { get; set; }
        public virtual User _User { get; set; }
    }
}
