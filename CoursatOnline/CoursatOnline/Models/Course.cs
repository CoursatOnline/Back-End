namespace CoursatOnline.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public class Course
    {
        public int Id { get; set; }

        [Required]
        //[Range(minimum: 3, maximum: 30)]
        public string Name { get; set; }

        //[Range(minimum: 0, maximum: 500)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool? IsPaid { get; set; }

        public bool? Show { get; set; }

        [ForeignKey("_Instructor")]
        
        public int? InsId { get; set; }

        [JsonIgnore]
        public virtual Instructor? _Instructor { get; set; }

        [JsonIgnore]
        public virtual List<CategoriesCourses>? _CategoriesCourses { get; set; }

        [JsonIgnore]
        public virtual List<Chapter>? _Chapters { get; set; }
        [JsonIgnore]
        public virtual List<Rating>? _Ratings { get; set; }

        
        
       
        //List of cart items courses added in
        [JsonIgnore]
        public virtual List<CartItem>? _CartItems { get; set; }
        [JsonIgnore]
        public virtual List<StudentRating>? _StudentRatings { get; set; }
        [JsonIgnore]
        public virtual List<StudentRegisters>? _StudentRegistered { get; set; }
    }
}
