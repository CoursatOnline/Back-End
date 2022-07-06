namespace CoursatOnline.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [Range(minimum: 3, maximum: 30)]
        public string Name { get; set; }
        [Range(minimum: 0, maximum: 500)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Instructor")]
        public int InsId { get; set; }
        public virtual Instructor _Instructor { get; set; }
        public virtual List<CategoriesCourses> _CategoriesCourses { get; set; }
        public virtual List<Chapter>? _Chapters { get; set; }
        public virtual List<Rating>? _Ratings { get; set; }
        //List of cart items courses added in
        public virtual List<CartItem>? _CartItems { get; set; }
        public virtual List<StudentRating>? _StudentRatings { get; set; }
        public virtual List<StudentRegisters>? _StudentRegistered { get; set; }
    }
}
