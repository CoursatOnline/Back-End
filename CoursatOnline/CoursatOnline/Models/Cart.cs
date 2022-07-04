using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public double Discount { get; set; }
        [ForeignKey("_Student")]
        public int StdId { get; set; }
        public Student _Student { get; set; }
        public bool Show { get; set; }
        //list of cart items added to the cart
        public virtual List<CartItem> _CartItems { get; set; }
    }
}
