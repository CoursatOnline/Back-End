namespace CoursatOnline.Models
{
    public class Admin : User
    {
        //List of categories that can be added by The Admin
        public virtual List<Category> _Categories { get; set; }
    }
}
