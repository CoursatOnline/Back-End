using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        IRepository<Cart> CartRepo;
        public CartController(IRepository<Cart> _repo)
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
            Cart cart = CartRepo.getById(id);
            if (cart == null)
                return NotFound();
            else
                return Ok(cart);

        }
        
        //create
        [HttpPost]
        public ActionResult Create(Cart cart)
        {
            if (ModelState.IsValid)
            {
                CartRepo.Create(cart);
                return Created("url", cart);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Cart cart)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CartRepo.Edit(id, cart);
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
        public ActionResult delete(int id, Cart? cart)
        {
            int numOfRows = CartRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(cart);
            }
        }

    }
}
