namespace CoursatOnline.Models
{
    public class Instructor : User
    {
        //List of Courses that can be added by instructor 
        public virtual List<Course> _Courses { get; set; }
        public virtual List<Chapter> _Chapters { get; set; }
    }
}
