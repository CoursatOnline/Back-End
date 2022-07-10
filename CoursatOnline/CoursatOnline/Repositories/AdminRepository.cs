using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class AdminRepository : IRepository<Admin>,IRepositoryGetByName<Admin>
    {
        CoursatOnlineDbContext db;
        public AdminRepository(CoursatOnlineDbContext _db)
        {
            db = _db;   
        }
        public int Create(Admin admin)
        {
            db.Add(admin);
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
            Admin? admin = db.Admin.FirstOrDefault(a => a.Id == id);
            if (admin == null)
                return -1;
            else
            {
                admin.Show = false;
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

        public int Edit(int id, Admin admin)
        {
            Admin? oldAdmin = db.Admin.FirstOrDefault(a => a.Id == id);
            if (oldAdmin == null)
                return -1;
            else
            {
                oldAdmin.Id = admin.Id;
                oldAdmin.First_Name = admin.First_Name;
                oldAdmin.Last_Name = admin.Last_Name;
                oldAdmin.Email = admin.Email;
                oldAdmin.Password = admin.Password;
                oldAdmin.Show = admin.Show;
                try
                {
                    int raws = db.SaveChanges();
                    return raws;
                }
                catch(Exception ex)
                {
                    return -1;
                }
            }
        }

        public ICollection<Admin> getAll()
        {
            return db.Admin.ToList();
        }

        public ICollection<Admin> getAllByName(string word)
        {
            return db.Admin.Where(a=>a.User_Name.Contains(word)).ToList();
        }

        public Admin getById(int id)
        {
            Admin? admin =  db.Admin.FirstOrDefault(a=>a.Id == id);
            return admin;

        }

        public Admin getByName(string name)
        {
            Admin? admin = db.Admin.FirstOrDefault(a=>a.User_Name == name);
            return admin;
        }
    }
}
