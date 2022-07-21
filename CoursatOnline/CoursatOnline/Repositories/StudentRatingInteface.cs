using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public interface StudentRatingInteface:IRepository<StudentRating>
    {
        public StudentRating getByIdComposit(int inst, int cat, int courseId);
        public List<Student> getAllStudent(int rateId, int courseId);
        public List<Rating> getAllRating(int stdId, int courseId);
        public int DeleteComposit(int stdId, int catId, int courseId);
        public int EditComposit(int stdId, int catId, int courseId, StudentRating obj);
    }
}
