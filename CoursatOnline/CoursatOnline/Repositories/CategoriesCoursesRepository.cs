using CoursatOnline.Models;
using CoursatOnline.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Repositories
{
    
    public class CategoriesCoursesRepository : IRepository<CategoriesCourses>
    {
        private readonly CoursatOnlineDbContext db;

        public CategoriesCoursesRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }
        public int Create(CategoriesCourses catCourse)
        {
            try
            {
                db.CategoriesCourses.Add(catCourse);
                int raw = db.SaveChanges();
                return raw;
            }catch(Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            CategoriesCourses catCourse = db.CategoriesCourses.FirstOrDefault(cc => (cc.CatId) + (cc.CourseId) == id);
            if(catCourse == null)
                return -1;
            else
                catCourse.Show = false;
            try
            {
                int raw = db.SaveChanges();
                return raw;
            }catch(Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, CategoriesCourses catCourse)
        {
            CategoriesCourses oldcatCourse = db.CategoriesCourses.FirstOrDefault(cc => (cc.CatId) + (cc.CourseId) == id);
            if(oldcatCourse == null)
            {
                return -1;
            }
            else
            {
                oldcatCourse.CourseId = catCourse.CourseId;
                oldcatCourse.CatId = catCourse.CatId;
                oldcatCourse.DateAdded = catCourse.DateAdded;
                oldcatCourse.Show = catCourse.Show;
                try
                {
                    int raw = db.SaveChanges();
                    return raw;
                }catch(Exception ex)
                {
                    return -1;
                }
            }
        }

        public ICollection<CategoriesCourses> getAll()
        {
            List<CategoriesCourses> catCourse = db.CategoriesCourses.Where(cc => cc.Show == true).ToList();
            return catCourse;
        }

        
        public CategoriesCourses getById(int id)
        {
            CategoriesCourses? catCourse = db.CategoriesCourses.FirstOrDefault(cc => (cc.CatId) + (cc.CourseId) == id);
            
                return catCourse;
        }

    }
}
