using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace CoursatOnline.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        //[Range(minimum: 2, maximum: 50, ErrorMessage = "Category Name must be betwen 2 to 50 charactars")]
        public string Name { get; set; }
        public bool Show { get; set; }
        public string? Image { get; set; }
        [JsonIgnore]
        [ForeignKey("_Admin")]
        public int? AdminId { get; set; }
        [JsonIgnore]
        public virtual Admin? _Admin { get; set; }
        [JsonIgnore]
        public virtual List<CategoriesCourses>? _CategoriesCourses { get; set; }
    }
}
