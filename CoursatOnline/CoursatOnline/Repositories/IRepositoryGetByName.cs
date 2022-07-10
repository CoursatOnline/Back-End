namespace CoursatOnline.Repositories
{
    public interface IRepositoryGetByName<T>
    {
        public ICollection<T> getAllByName(string word);
        public T getByName(string name);
    }
}
