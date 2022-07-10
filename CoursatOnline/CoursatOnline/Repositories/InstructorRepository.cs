using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class InstructorRepository : IRepository<Instructor>,IRepositoryGetByName<Instructor>
    {
        CoursatOnlineDbContext db;
        public InstructorRepository(CoursatOnlineDbContext _db)
        {
            db = _db;
        }
        public int Create(Instructor instructor)
        {
            db.Add(instructor);
            try
            {
                int raws = db.SaveChanges();
                return raws;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            Instructor? instructor = db.Instructor.FirstOrDefault(i => i.Id == id);
            if (instructor == null)
                return -1;
            else
            {
                instructor.Show = false;
                try
                {
                    int raws = db.SaveChanges();
                    return raws;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }


        }

        public int Edit(int id, Instructor instructor)
        {
            Instructor? oldInstructor = db.Instructor.FirstOrDefault(i => i.Id == id);
            if (oldInstructor == null)
                return -1;
            else
            {
                oldInstructor.Id = instructor.Id;
                oldInstructor.First_Name = instructor.First_Name;
                oldInstructor.Last_Name = instructor.Last_Name;
                oldInstructor.Email = instructor.Email;
                oldInstructor.Password = instructor.Password;
                oldInstructor.Show = instructor.Show;
                try
                {
                    int raws = db.SaveChanges();
                    return raws;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public ICollection<Instructor> getAll()
        {
            return db.Instructor.ToList();
        }

        public ICollection<Instructor> getAllByName(string word)
        {
            return db.Instructor.Where(i => i.User_Name.Contains(word)).ToList();
        }

        public Instructor getById(int id)
        {
            Instructor? instructor = db.Instructor.FirstOrDefault(i => i.Id == id);
            return instructor;

        }

        public Instructor getByName(string name)
        {
            Instructor? instructor = db.Instructor.FirstOrDefault(i => i.User_Name == name);
            return instructor;
        }
    }
}
