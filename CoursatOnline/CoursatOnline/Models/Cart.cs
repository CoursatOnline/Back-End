using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Cart
    {
        public int Id { get; set; }
       
        public double TotalPrice { get; set; }
        public double Discount { get; set; }
        [ForeignKey("_Student")]
        public int StdId { get; set; }
        [JsonIgnore]
        public virtual Student? _Student { get; set; }
        //list of cart items added to the cart
        [JsonIgnore]
        public virtual List<CartItem>? _CartItems { get; set; }
    }
}
