using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class RatingRepository:IRepository<Rating>
    {
        CoursatOnlineDbContext db;
        public RatingRepository(CoursatOnlineDbContext _db)
        {
            db = _db;
        }
        public int Create(Rating rating)
        {
            db.Add(rating);
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
            Rating? rating = db.Rating.FirstOrDefault(r => r.Id == id);
            if (rating == null)
                return -1;
            else
            {
                db.Remove(rating);
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

        public int Edit(int id, Rating rating)
        {
            Rating? oldRating = db.Rating.FirstOrDefault(r => r.Id == id);
            if (oldRating == null)
                return -1;
            else
            {

                oldRating.Rate_Comment = rating.Rate_Comment;
                oldRating.Ratio = rating.Ratio;

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

        public ICollection<Rating> getAll()
        {
            return db.Rating.ToList();
        }



        public Rating getById(int id)
        {
            Rating? rating = db.Rating.FirstOrDefault(r => r.Id == id);
            return rating;

        }
    }
}
