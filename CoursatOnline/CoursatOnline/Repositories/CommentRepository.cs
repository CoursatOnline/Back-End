using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        CoursatOnlineDbContext db;
        public CommentRepository(CoursatOnlineDbContext _db)
        {
            db = _db;
        }
        public int Create(Comment comment)
        {
            db.Add(comment);
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
            Comment? comment = db.Comment.FirstOrDefault(c => c.Id == id);
            if (comment == null)
                return -1;
            else
            {
                comment.Show = false;
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

        public int Edit(int id, Comment comment)
        {
            Comment? oldComment = db.Comment.FirstOrDefault(c => c.Id == id);
            if (oldComment == null)
                return -1;
            else
            {

                oldComment.Title = comment.Title;
                oldComment.Show = comment.Show;
                oldComment.Content = comment.Content;

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

        public ICollection<Comment> getAll()
        {
            return db.Comment.ToList();
        }

       

        public Comment getById(int id)
        {
            Comment? comment = db.Comment.FirstOrDefault(c => c.Id == id);
            return comment;

        }

    }
}
