﻿using System.ComponentModel.DataAnnotations.Schema;
namespace CoursatOnline.Models
{
    public class CategoriesCourses
    {
        [ForeignKey("_Category")]
        public int CatId { get; set; }
        [ForeignKey("_Course")]
        public int CourseId { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual Category _Category { get; set; }
        public virtual Course _Course { get; set; }
    }
}
