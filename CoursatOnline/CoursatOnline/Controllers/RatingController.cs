using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        IRepository<Rating> RatingRepo;

        public RatingController(IRepository<Rating> _RatingRepo)
        {
            RatingRepo = _RatingRepo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (RatingRepo.getAll().Count > 0)
                return Ok(RatingRepo.getAll());
            else
                return NotFound();
        }

        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Rating rating = RatingRepo.getById(id);
            if (rating == null)
                return NotFound();
            else
                return Ok(rating);

        }

        //create
        [HttpPost]
        public ActionResult Create(Rating rating)
        {
            if (ModelState.IsValid)
            {
                RatingRepo.Create(rating);
                return Created("url", rating);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Rating rating)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RatingRepo.Edit(id, rating);
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
        public ActionResult delete(int id, Rating? rating)
        {
            int numOfRows = RatingRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(rating);
            }
        }
    }
}
