using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Show { get; set; }
        [ForeignKey("_Admin")]
        public int AdminId { get; set; }
        public Admin _Admin { get; set; }
        public virtual List<CategoriesCourses> _CategoriesCourses { get; set; }
    }
}
