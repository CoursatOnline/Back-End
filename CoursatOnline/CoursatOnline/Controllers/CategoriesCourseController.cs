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
        CategoriesCourseInterface CartRepo;
        public CartegoriesCourseController(CategoriesCourseInterface _repo)
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
        public ActionResult getById(int categoryId, int courseId)
        {
            CategoriesCourses catCourse = CartRepo.getByIdComposit(categoryId,courseId);
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

                int num = CartRepo.Create(catCourse);
                if (num >= 0)
                {
                    return Created("url", catCourse);
                }
                else
                {
                    return BadRequest("This ID is Used");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int categoryId, int courseId, CategoriesCourses catCourse)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int num = CartRepo.EditComposit(categoryId, courseId, catCourse);
                    if(num >= 0)
                    {
                        return Content("Updated");
                    }
                    else
                    {
                        return NotFound();
                    }

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
        public ActionResult delete(int categoryId, int courseId, CategoriesCourses? catCourse)
        {
            int numOfRows = CartRepo.DeleteComposit(categoryId, courseId);
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
