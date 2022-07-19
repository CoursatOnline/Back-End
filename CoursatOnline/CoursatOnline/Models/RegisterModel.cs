using System.ComponentModel.DataAnnotations;

namespace CoursatOnline.Models
{
    public class RegisterModel
    {

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }

        public string? Image { get; set; }
    }
}
