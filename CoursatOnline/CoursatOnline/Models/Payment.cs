using CoursatOnline.Data;
using System.ComponentModel.DataAnnotations;

namespace CoursatOnline.Models
{
    public class Payment
    {
        public int Id { get; set; }
       // [Required]
        public PaymentMethod PaymentMethod { get; set; }
        //[Required]
        public DateTime DateDone { get; set; }
        //[Required]
        public double PaymentAmount { get; set; }
        public virtual StudentRegisters? _StudentRegistered { get; set; }
    }
}
