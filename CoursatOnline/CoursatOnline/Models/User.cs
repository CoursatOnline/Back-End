namespace CoursatOnline.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Show { get; set; }
        public virtual List<Comment> _Comments { get; set; }
    }
}
