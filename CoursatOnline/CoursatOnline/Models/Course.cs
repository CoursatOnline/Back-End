namespace CoursatOnline.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsPaid { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Instructor")]
        public int InsId { get; set; }
        public Instructor _Instructor { get; set; }
        public virtual List<CategoriesCourses> _CategoriesCourses { get; set; }
        public virtual List<Chapter> _Chapters { get; set; }
        public virtual List<Rating> _Ratings { get; set; }
        //List of cart items courses added in
        public virtual List<CartItem> _CartItems { get; set; }
        public virtual List<StudentRating> _StudentRatings { get; set; }
        public virtual List<StudentRegisters> _StudentRegistered { get; set; }
    }
}
