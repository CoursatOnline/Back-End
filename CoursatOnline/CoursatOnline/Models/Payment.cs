using CoursatOnline.Data;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Payment
    {
        // public int Id { get; set; }
        //// [Required]
        // public PaymentMethod PaymentMethod { get; set; }
        // //[Required]
        // public DateTime DateDone { get; set; }
        // //[Required]
        // public double PaymentAmount { get; set; }
        // public virtual StudentRegisters? _StudentRegistered { get; set; }

        public int Id { get; set; }
        public string cardnumber { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string cvc { get; set; }
        public int value { get; set; }


        [JsonIgnore]
        public virtual StudentRegisters? _StudentRegistered { get; set; }
    }
}
