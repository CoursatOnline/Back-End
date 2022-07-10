using System.Text.Json.Serialization;

namespace CoursatOnline.Models
{
    public class Admin : User
    {
        //List of categories that can be added by The Admin
        [JsonIgnore]
        public virtual List<Category>? _Categories { get; set; }
    }
}
