using CoursatOnline.Data;
namespace CoursatOnline.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DateDone { get; set; }
        public double PaymentAmount { get; set; }
        public virtual StudentRegisters _StudentRegistered { get; set; }
    }
}
