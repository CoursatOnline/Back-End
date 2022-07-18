using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        IRepository<CartItem> CartRepo;
        public CartItemController(IRepository<CartItem> _repo)
        {
            this.CartRepo = _repo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (CartRepo.getAll().Count > 0)
                return Ok(CartRepo.getAll());
            else
                return NotFound();
        }
        //getAllByName

        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            CartItem cartitem = CartRepo.getById(id);
            if (cartitem == null)
                return NotFound();
            else
                return Ok(cartitem);

        }

        //create
        [HttpPost]
        public ActionResult Create(CartItem cartitem)
        {
            if (ModelState.IsValid)
            {
                CartRepo.Create(cartitem);
                return Created("url", cartitem);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, CartItem cartitem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CartRepo.Edit(id, cartitem);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            else return BadRequest(ModelState);
        }
        //delete
        [HttpDelete("{id}")]
        public ActionResult delete(int id, CartItem? cartitem)
        {
            int numOfRows = CartRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(cartitem);
            }
        }

    }
}
