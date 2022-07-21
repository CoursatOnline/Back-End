using CoursatOnline.Models;
namespace CoursatOnline.Repositories
{
    public interface IRepositoryGetAllChaptersByCrsId
    {
        public ICollection<Chapter> getAllByCrsId(int id);
    }
}
