using CoursatOnline.Models;
using CoursatOnline.Data;

namespace CoursatOnline.Repositories
{
    public class CartRepository : IRepository<Cart>
    {
        private readonly CoursatOnlineDbContext db;

        public CartRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }
        public int Create(Cart cart)
        {
            try
            {
                db.Add(cart);
                int raw =db.SaveChanges();
                return raw;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            Cart cart = db.Cart.FirstOrDefault(c => c.Id == id);
            if (cart == null)
                return -1;
            else
                db.Remove(cart);
            try
            {
                int raw =db.SaveChanges();
                return raw;
            }catch(Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, Cart cart)
        {
            Cart? oldCart = db.Cart.FirstOrDefault(c => c.Id == id);
            if(oldCart != null)
            {
                db.Update(cart);
                //oldCart.TotalPrice = cart.TotalPrice;
                //oldCart.Discount = cart.Discount;
                //oldCart.StdId = cart.StdId;
                try
                {
                    int raw = db.SaveChanges();
                    return raw;
                }catch(Exception ex)
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public ICollection<Cart> getAll()
        {
            return db.Cart.ToList();
        }

        public Cart getById(int id)
        {
            Cart cart = db.Cart.FirstOrDefault(c => c.Id == id);
            return cart;
        }
    }
}
