using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Range(minimum: 2, maximum: 50, ErrorMessage = "Category Name must be betwen 2 to 50 charactars")]
        public string Name { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Admin")]
        public int AdminId { get; set; }
        public virtual Admin _Admin { get; set; }
        public virtual List<CategoriesCourses>? _CategoriesCourses { get; set; }
    }
}
