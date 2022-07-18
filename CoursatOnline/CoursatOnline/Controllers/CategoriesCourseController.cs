using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CartegoriesCourseController : ControllerBase
    {
        IRepository<CategoriesCourses> CartRepo;
        public CartegoriesCourseController(IRepository<CategoriesCourses> _repo)
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
            CategoriesCourses catCourse = CartRepo.getById(id);
            if (catCourse == null )
                return NotFound();
            else
                return Ok(catCourse);

        }

        //create
        [HttpPost]
        public ActionResult Create(CategoriesCourses catCourse)
        {
            if (ModelState.IsValid)
            {
                CartRepo.Create(catCourse);
                return Created("url", catCourse);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, CategoriesCourses catCourse)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CartRepo.Edit(id, catCourse);
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
        public ActionResult delete(int id, CategoriesCourses? catCourse)
        {
            int numOfRows = CartRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(catCourse);
            }
        }

    }
}
