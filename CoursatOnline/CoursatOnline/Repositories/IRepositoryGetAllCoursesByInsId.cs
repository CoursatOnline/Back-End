using CoursatOnline.Models;
namespace CoursatOnline.Repositories
{
    public interface IRepositoryGetAllCoursesByInsId
    {
        public ICollection<Course> getAllByInsId(int id);
    }
}
