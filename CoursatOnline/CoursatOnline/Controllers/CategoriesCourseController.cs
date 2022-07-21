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
        CategoriesCourseInterface CartcourseRepo;
        public CartegoriesCourseController(CategoriesCourseInterface _repo)
        {
            this.CartcourseRepo = _repo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (CartcourseRepo.getAll().Count > 0)
                return Ok(CartcourseRepo.getAll());
            else
                return NotFound();
        }

        //get all courses By catId
        [HttpGet("{id:int}")]
        public ActionResult getAllCourses(int categoryId)
        {
            List<Course> course = CartcourseRepo.getAllCourses(categoryId);
            if (CartcourseRepo == null )
                return NotFound();
            else
                return Ok(course);

        }

        //get all category By courseId
        [HttpGet("{id:int}")]
        public ActionResult getAllCategory(int courseId)
        {
            List<Category> category = CartcourseRepo.getAllCategory(courseId);
            if (CartcourseRepo == null)
                return NotFound();
            else
                return Ok(category);

        }

        //create
        [HttpPost]
        public ActionResult Create(CategoriesCourses catCourse)
        {
            if (ModelState.IsValid)
            {

                int num = CartcourseRepo.Create(catCourse);
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
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        int num = CartRepo.EditComposit(categoryId, courseId, catCourse);
            //        if(num >= 0)
            //        {
            //            return Content("Updated");
            //        }
            //        else
            //        {
            //            return NotFound();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        return BadRequest(ex.Message);
            //    }

            //}
             return BadRequest(ModelState);
        }
        //delete
        [HttpDelete("{id}")]
        public ActionResult delete(int categoryId, int courseId, CategoriesCourses? catCourse)
        {
            //int numOfRows = CartRepo.DeleteComposit(categoryId, courseId);
            //if (numOfRows <= 0)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    return Ok(catCourse);
            //}
            return Ok();
        }

    }
}
