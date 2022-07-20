using CoursatOnline.Data;
using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        IRepository<Course> repo;
        IRepositoryGetByName<Course> CatRepoGetByName;
        public CourseController(IRepository<Course> _repo, IRepositoryGetByName<Course> _CatRepoGetByName)
        {
            this.repo = _repo;
            this.CatRepoGetByName = _CatRepoGetByName;
        }
        //-------------------------------------------- GetAll Courses--------------------------------------------
        [HttpGet]
        public ActionResult GetAll()
        {
            List<Course> course = repo.getAll().ToList();
            if (course != null)
                return Ok(repo.getAll());
            else
                return NotFound("Not Found");
        }

        //--------------------------------------------Get Course By Id--------------------------------------------
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Course course = repo.getById(id);
            if (course == null)
                return NotFound();
            else
                return Ok(course);

        }

        //--------------------------------------------getAllByName--------------------------------------------
        [HttpGet]
        public ActionResult GetAllByName(string word)
        {
            if (CatRepoGetByName.getAllByName(word).Count > 0)
                return Ok(CatRepoGetByName.getAllByName(word));
            else
                return NotFound();
        }
        //--------------------------------------------GetByName--------------------------------------------

        [HttpGet("{name}")]
        public ActionResult GetByName(string name)
        {
            Course course = CatRepoGetByName.getByName(name);
            if(course == null)
            {
                return NotFound("Not Found Course By This Name");
            }
            else
            {
                return Ok(course);
            }

        }
        //--------------------------------------------create--------------------------------------------
        [HttpPost]
        public ActionResult Create(Course crs)
            {
            if (ModelState.IsValid)
            {
                repo.Create(crs);
                return Created("url", crs);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //--------------------------------------------Edite Course--------------------------------------------
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Course course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.Edit(id, course);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            else return BadRequest(ModelState);
        }

        //--------------------------------------------delete--------------------------------------------
        [HttpDelete("{id}")]
        public ActionResult delete(int id, Course? course)
        {
            int numOfRows = repo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(course);
            }
        }
    }
}
