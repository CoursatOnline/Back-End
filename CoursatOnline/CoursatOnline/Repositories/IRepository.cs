using CoursatOnline.Models;
namespace CoursatOnline.Repositories
{
    public interface IRepository<T>
    {
        public ICollection<T> getAll();
        public T getById(int id);
        public int Create(T obj);
        public int Edit(int id,T obj);
        public int Delete(int id);
    }
}
