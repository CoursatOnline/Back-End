using CoursatOnline.Models;
using CoursatOnline.Data;

namespace CoursatOnline.Repositories
{
    public class CartItemRepository : IRepository<CartItem>
    {
        private readonly CoursatOnlineDbContext db;

        public CartItemRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }
        
        public int Create(CartItem cartItem)
        {
            try
            {
                db.Add(cartItem);
                int raw = db.SaveChanges();
                return raw;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            CartItem cartitem = db.CartItem.FirstOrDefault(c => c.Id == id);
            if (cartitem == null)
                return -1;
            else
                db.Remove(cartitem);
            try
            {
                int raw = db.SaveChanges();
                return raw;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, CartItem cartitem)
        {
            CartItem? oldCartitem = db.CartItem.FirstOrDefault(c => c.Id == id);
            if (oldCartitem != null)
            {
                oldCartitem.CartId = cartitem.CartId;
                oldCartitem.CrsId = cartitem.CrsId;
                oldCartitem.DateAdded = cartitem.DateAdded;
                try
                {
                    int raw = db.SaveChanges();
                    return raw;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public ICollection<CartItem> getAll()
        {
            return db.CartItem.ToList();
        }

        public CartItem getById(int id)
        {
            CartItem? cartitem = db.CartItem.FirstOrDefault(c => c.Id == id);
            return cartitem;
        }
    }
}
