using CoursatOnline.Models;
namespace CoursatOnline.Repositories
{
    public interface IRepository<T>
    {
        public ICollection<T> getAll();
        public T getById(int id);
        public int Create(Student std);
        public int Edit(int id,Student std);
        public int Delete(int id);
    }
}
