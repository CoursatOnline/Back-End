using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class StudentRatingRepository : StudentRatingInteface
    {
        CoursatOnlineDbContext db;
        public StudentRatingRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }

        public int Create(StudentRating stdrepo)
        {
            try
            {
                db.StudentRating.Add(stdrepo);
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
            throw new NotImplementedException();
        }

        public int DeleteComposit(int stdId, int rateId, int courseId)
        {
            StudentRating? stdRate = db.StudentRating.Find(stdId, rateId,  courseId);
            if (stdRate == null)
            {
                return -1;
            }
            else
            {
                db.Remove(stdRate);
                int raw = db.SaveChanges();
                return raw;
            }
        }

        public int Edit(int id, StudentRating obj)
        {
            throw new NotImplementedException();
        }

        public int EditComposit(int stdId, int rateId, int courseId, StudentRating stdRate)
        {
            StudentRating? studentRate = db.StudentRating.Find(stdId, rateId,courseId);
            if(studentRate != null)
            {
                db.Update(studentRate);
                int raw = db.SaveChanges();
                return raw;
            }
            else
            {
                return -1;
            }
        }

        public ICollection<StudentRating> getAll()
        {
            return db.StudentRating.ToList();
        }

        public List<Rating> getAllRating(int stdId, int courseId)
        {
            if ((db.Student.Find(stdId) != null) )
            {
                List<Rating> ratings = new List<Rating>();
                List<StudentRating> stdRete = db.StudentRating.ToList();
                foreach (var item in stdRete)
                {
                    if (item.StudentId == stdId && item._CourseId == courseId)
                    {
                        Rating? rate = db.Rating.Find(item.RateId);
                        ratings.Add(rate);
                    }
                }
                return ratings;
            }
            else
            
                return null;
            
        }

        public List<Student> getAllStudent(int rateId, int courseId)
        {
            if (db.Rating.Find(rateId) != null)
            {
                List<Student> students = new List<Student>();
                List<StudentRating> stdRete = db.StudentRating.ToList();
                foreach (var item in stdRete)
                {
                    if (item.RateId == rateId && item._CourseId == courseId)
                    {
                        Student? student = db.Student.Find(item.StudentId);
                        students.Add(student);
                    }
                }
                return students;
            }
            else

                return null;
        }

        public StudentRating getById(int id)
        {
            throw new NotImplementedException();
        }

        public StudentRating getByIdComposit(int stdId, int rateId, int courseId)
        {
            StudentRating stdRate = db.StudentRating.Find(stdId, rateId, courseId);
            if (stdRate != null)
            {
                return stdRate;
            }
            else
                return null;
        }
    }
}
