using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class StudentRegisterIRepository : IRepository<StudentRegisters>
    {
        private readonly CoursatOnlineDbContext db;

        public StudentRegisterIRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }
    
        public int Create(StudentRegisters stdReg)
        {
            db.RegisteredStudent.Add(stdReg);
            try
            {
                int raw = db.SaveChanges();
                return raw;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            StudentRegisters stdReg = db.RegisteredStudent.FirstOrDefault(c => c.StdId == id);
            if(stdReg == null)
            {
                return -1;
            }
            else
            {
                db.RegisteredStudent.Remove(stdReg);
                try
                {
                    int raw = db.SaveChanges();
                    return raw;
                }
                catch(Exception ex)
                {
                    return -1;
                }

            }
        }

        public int Edit(int id, StudentRegisters stdreg)
        {
            StudentRegisters stdregister = db.RegisteredStudent.Find(id);
            if (stdregister == null)
            {
                return -1;
            }
            else
            {
                db.Update(stdreg);
                try
                {
                    int raw = db.SaveChanges();
                    return raw;
                }
                catch(Exception ex)
                {
                    return -1;
                }
            }
        }

        public ICollection<StudentRegisters> getAll()
        {
            return db.RegisteredStudent.ToList();
        }

        public StudentRegisters getById(int id)
        {
            StudentRegisters stdregister = db.RegisteredStudent.Find(id);
            if (stdregister == null)
            {
                return null;
            }
            else
            {
                return stdregister;
            }
        }
    }
}
