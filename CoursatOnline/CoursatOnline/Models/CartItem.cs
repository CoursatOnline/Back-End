using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public virtual Cart _Cart { get; set; }
        //public Student _Student { get; set; }
        [JsonIgnore]
        public virtual Course _Course { get; set; }
    }
}
