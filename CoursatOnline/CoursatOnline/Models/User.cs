using System.ComponentModel.DataAnnotations;

namespace CoursatOnline.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]{3,15}$")]
        public string First_Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]{3,15}$")]
        public string Last_Name { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9_#*$.-!%]{7,29}$")]
        public string User_Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?#&-])[A-Za-z\d@$!%*?#&-]{8,}$")]
        public string Password { get; set; }
        public bool Show { get; set; }
        public virtual List<Comment> _Comments { get; set; }
    }
}
