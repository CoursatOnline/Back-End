using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        [ForeignKey("_Cart")]
        public int CartId { get; set; }
        //[ForeignKey("_Student")]
        //public int StdId { get; set; }
        [ForeignKey("_Course")]
        public int CrsId { get; set; }
        public DateTime DateAdded { get; set; }
        public Cart _Cart { get; set; }
        //public Student _Student { get; set; }
        public Course _Course { get; set; }
    }
}
