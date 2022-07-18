using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class StudentRatingRepository : IRepository<StudentRating>, IRepositoryGetByName<StudentRating>
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
                db.Add(stdrepo);
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

        public int Edit(int id, StudentRating obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentRating> getAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentRating> getAllByName(string word)
        {
            throw new NotImplementedException();
        }

        public StudentRating getById(int id)
        {
            throw new NotImplementedException();
        }

        public StudentRating getByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
