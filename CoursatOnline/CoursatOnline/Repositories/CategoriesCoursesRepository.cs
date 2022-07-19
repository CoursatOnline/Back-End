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
            db.CategoriesCourses.Add(catCourse);
            try
            {
                int raw = db.SaveChanges();
                return raw;
            }catch(Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, CategoriesCourses obj)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            CategoriesCourses catcourse =  db.CategoriesCourses.FirstOrDefault(c => c.Id == id);
            if(catcourse == null)
            {
                return -1;
            }
            else
            {
                db.Remove(catcourse);
                int raw = db.SaveChanges();
                return raw;
            }
        }

        public ICollection<CategoriesCourses> getAll()
        {
            return db.CategoriesCourses.ToList();
        }

        public CategoriesCourses getById(int id)
        {
            CategoriesCourses catcourse = db.CategoriesCourses.Find(id);
            if (catcourse != null)
            {
                return catcourse;
            }
            else
                return null;
        }
        


    }
}
