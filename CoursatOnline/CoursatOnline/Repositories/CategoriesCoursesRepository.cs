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

        public int Create(CategoriesCourses catId)
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

        public List<int> getById(int id)
        {
            List<int> course = new List<int>();
            List<CategoriesCourses> catC = db.CategoriesCourses.ToList();
            foreach(var item in catC)
            {
                if(item.CatId == id)
                {
                    course.Add(item.CourseId);
                }
            }
            return course;
        }
        public int Delete(int id)
        {
            throw null;
        }



        //public CategoriesCourses getByIdComposit(int inst, int cat)
        //{
        //    CategoriesCourses catcourse = db.CategoriesCourses.Find(inst,cat);
        //    if (catcourse != null)
        //    {
        //        return catcourse;
        //    }
        //    else
        //        return null;
        //}

        //public int DeleteComposit(int catId, int courseId)
        //{
        //    CategoriesCourses catcourse = db.CategoriesCourses.Find(catId, courseId);
        //    if (catcourse == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        db.Remove(catcourse);
        //        int raw = db.SaveChanges();
        //        return raw;
        //    }
        //}

        //public int EditComposit(int catId, int courseId, CategoriesCourses obj)
        //{
        //    CategoriesCourses? catcourse = db.CategoriesCourses.Find(catId, courseId);
        //    if(catcourse == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        db.CategoriesCourses.Update(obj);
        //        int raw = db.SaveChanges();
        //        return raw;
        //    }
        //}

        public int Edit(int id, CategoriesCourses obj)
        {
            throw new NotImplementedException();
        }

        CategoriesCourses IRepository<CategoriesCourses>.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
