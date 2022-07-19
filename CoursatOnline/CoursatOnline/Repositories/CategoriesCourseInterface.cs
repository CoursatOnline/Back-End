using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public interface CategoriesCourseInterface:IRepository<CategoriesCourses>
    {
        public CategoriesCourses getByIdComposit(int inst, int cat);
    }
}
