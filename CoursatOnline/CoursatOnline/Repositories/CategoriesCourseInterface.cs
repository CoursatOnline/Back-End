using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public interface CategoriesCourseInterface : IRepository<CategoriesCourses>
    {
        public CategoriesCourses getByIdComposit(int inst, int cat);
        public int DeleteComposit(int catId, int courseId);
        public int EditComposit(int catId, int courseId, CategoriesCourses obj);
        public List<Category> getAllCategory(int courseId);
        public List<Course> getAllCourses(int catId);
    }
}
