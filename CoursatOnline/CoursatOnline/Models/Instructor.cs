using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Instructor : User
    {
        //List of Courses that can be added by instructor 
        [JsonIgnore]
        public virtual List<Course>? _Courses { get; set; }
        [JsonIgnore]
        public virtual List<Chapter>? _Chapters { get; set; }
    }
}
