using CoursatOnline.Data;
using CoursatOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursatOnline.Repositories
{
    public class CourseRepository : IRepository<Course>,IRepositoryGetByName<Course>,IRepositoryGetAllCoursesByInsId
    {
        private readonly CoursatOnlineDbContext db;

        public CourseRepository(CoursatOnlineDbContext _db)
        {
            db = _db;
        }
        public int Create(Course crs)
        {
            try
            {
                db.Add(crs);
                int raws = db.SaveChanges();
                return raws;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            Course? crs = db.Course.FirstOrDefault(a => a.Id == id);
            if(crs == null)
            {
                return -1;
            }
            else
            {
                crs.Show = false;
            }
            try
            {
                int raws = db.SaveChanges();
                return raws;
            }catch(Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, Course crs)
        {
            Course? course = db.Course.FirstOrDefault(a => a.Id == id);
            if(course == null)
            {
                return -1;
            }
            else
            {
                course.Name = crs.Name;
                course.Price = crs.Price;
                course.Description = crs.Description;
                course.IsPaid = crs.IsPaid;
                try
                {
                    int raws = db.SaveChanges();
                    return raws;
                }catch(Exception ex)
                {
                    return -1;
                }
            }
        }


        public ICollection<Course> getAll()
        {
            List<Course>? course = db.Course.Where(c => c.Show == true).ToList();
            return course;
        }

        public ICollection<Course> getAllByName(string word)
        {
            List<Course>? courses = db.Course.Where(a => a.Name.Contains(word) && a.Show == true).ToList();
            return courses;
        }

        public Course getById(int id)
        {
            Course? course = db.Course.FirstOrDefault(a => a.Id == id);
            if (course.Show == false)
                return null;
            else
                return course;
        }

        public Course getByName(string name)
        {
            Course? course = db.Course.FirstOrDefault(c => c.Name == name && c.Show == true);
            return course;
        }

        public ICollection<Course> getAllByInsId(int id)
        {
            List<Course>? courses = db.Course.Where(a => a.InsId == id && a.Show == true).ToList();
            return courses;
        }
    }
}
