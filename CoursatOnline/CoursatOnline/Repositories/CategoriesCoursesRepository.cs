using CoursatOnline.Models;
using CoursatOnline.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Repositories
{
    
    public class CategoriesCoursesRepository : CategoriesCourseInterface
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
            }
            catch (Exception ex)
            {
                return -1;
            }
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

        public ICollection<CategoriesCourses> getAll()
        {
            return db.CategoriesCourses.ToList();
        }

        CategoriesCourses IRepository<CategoriesCourses>.getById(int id)
        {
            throw new NotImplementedException();
        }
        //---------------To Get All Course In This Category
        public List<Course> getAllCourses(int catId)
        {
            if(db.Category.Find(catId) == null)
            {
                return null;
            }
            else
            {
                List<Course> courses = new List<Course>();
                List<CategoriesCourses> catCourse = db.CategoriesCourses.ToList();


                foreach (var item in catCourse)
                {
                    if (item.CatId == catId)
                    {
                        Course course = db.Course.Find(item.CourseId);
                        courses.Add(course);
                    }
                }
                return courses;
            }
        }
            


        //---------------To Get All Category In This Course
        public List<Category> getAllCategory(int courseId)
        {
            if(db.Course.Find(courseId) == null)
            {
                return null;
            }else
            {
                List<Category>? categories = new List<Category>();
                List<CategoriesCourses>? catCourse = db.CategoriesCourses.ToList();


                foreach (var item in catCourse)
                {
                    if (item.CourseId == courseId)
                    {
                        Category? category = db.Category.Find(item.CatId);
                        categories.Add(category);
                    }
                }
                return categories;
            }
            
        }

        public CategoriesCourses getByIdComposit(int inst, int cat)
        {
            throw new NotImplementedException();
        }

        public int DeleteComposit(int catId, int courseId)
        {
            CategoriesCourses catcourse = db.CategoriesCourses.Find(catId, courseId);
            if (catcourse == null)
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

        public int EditComposit(int catId, int courseId, CategoriesCourses obj)
        {
            throw new NotImplementedException();
        }
    }

}
