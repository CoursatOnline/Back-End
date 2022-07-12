using Microsoft.AspNetCore.Mvc;
using CoursatOnline.Data;
using CoursatOnline.Models;
namespace CoursatOnline.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        CoursatOnlineDbContext db;
        public StudentRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }
            
        //getall
        public ICollection<Student> getAll()
        {
            return db.Student.ToList();
        }
        //get by ID
        public Student getById(int id)
        {
            Student std = db.Student.Where(S => S.Id == id).FirstOrDefault();
            return std;

        }
        //create
        public int Create(Student std)
        {
            int rows = 0;
            db.Student.Add(std);
            rows = db.SaveChanges();
            if(rows > 0)
            {
                int stdId = std.Id;
                Cart cart = new Cart();
                cart.StdId = stdId;
                cart.Discount = 0;
                cart.TotalPrice = 0;
                db.Cart.Add(cart);
                rows = db.SaveChanges();
            }
          
            return rows;

        }
        //update
        public int Edit(int id,Student std)
        {
            int rows = 0;
            //db.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Student oldStudent = db.Student.FirstOrDefault(S => S.Id == id);
            oldStudent.First_Name = std.First_Name ?? oldStudent.First_Name;
            oldStudent.Last_Name = std.Last_Name ?? oldStudent.Last_Name;
            oldStudent.User_Name = std.User_Name ?? oldStudent.User_Name;
            oldStudent.Email = std.Email ?? oldStudent.Email;
            oldStudent.Password = std.Password ?? oldStudent.Password;
            oldStudent.Show = std.Show;


            try
            {
                rows = db.SaveChanges();
            }catch (Exception ex)
            {
                return rows;
            }
            return rows;
                
        }
        //delete
        public int Delete(int id)
        {
            int rows = 0;
            Student std = db.Student.Where(s => s.Id == id).FirstOrDefault();
            if(std != null)
            {
                db.Student.Remove(std);
                rows = db.SaveChanges();
            }
            return rows;
        }

        
    }
}
