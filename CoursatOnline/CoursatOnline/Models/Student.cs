using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Student : User
    {
        //Student Owns One Cart
        [JsonIgnore]
        public virtual Cart? _Cart { get; set; }
        //List of Courses That a student Rated (Ternary Relationship)
        [JsonIgnore]
        public virtual List<StudentRating>? _RatedCourses { get; set; }

        //List of Courses That are registered in by students(Ternary RelationShip)
        [JsonIgnore]
        public virtual List<StudentRegisters>? _RegisteredCourses { get; set; }
        //List of Cart Items added by a student 
        //public virtual List<CartItem> _Items { get; set; }

    }
}
