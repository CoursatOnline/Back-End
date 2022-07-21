using CoursatOnline.Data;
using CoursatOnline.Models;

namespace CoursatOnline.Repositories
{
    public class ChapterRepository : IRepository<Chapter>, IRepositoryGetByName<Chapter>, IRepositoryGetAllChaptersByCrsId
    {
        private readonly CoursatOnlineDbContext db;

        public ChapterRepository(CoursatOnlineDbContext _db)
        {
            db = _db;
        }
        public int Create(Chapter chr)
        {
            try
            {
                db.Add(chr);
                int raw = db.SaveChanges();
                return raw;
            }catch (Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            Chapter? chr = db.Chapter.FirstOrDefault(a => a.Id == id);
            if (chr == null)
            {
                return -1;
            }
            else
                chr.Show = false;
            try
            {
                int raw = db.SaveChanges();
                return raw;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, Chapter chr)
        {
            Chapter chapter = db.Chapter.FirstOrDefault(c => c.Id == id);
            if (chapter == null)
            {
                return -1;
            }else
            {
                chapter.Title = chr.Title;
                chapter.Video = chr.Video;
                chapter.Show = chr.Show;
                chapter.DateAdded = chr.DateAdded;
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

        public ICollection<Chapter> getAll()
        {
            List<Chapter> chapter = db.Chapter.Where(ch => ch.Show == true).ToList();
            return chapter;
        }

        public ICollection<Chapter> getAllByName(string word)
        {
            return  db.Chapter.Where(a => a.Title.Contains(word)).ToList();
        }
        public ICollection<Chapter> getAllByCrsId(int id)
        {
            return db.Chapter.Where(a => a.CrsId == id).ToList();
        }

        public Chapter getById(int id)
        {
            Chapter? chapter = db.Chapter.FirstOrDefault(c => c.Id == id);
            if (chapter.Show == false)
                return null;
            else
                return chapter;
        }

        public Chapter getByName(string name)
        {
            Chapter? chapter = db.Chapter.FirstOrDefault(c => c.Title == name);
            return chapter;
        }
    }
}
