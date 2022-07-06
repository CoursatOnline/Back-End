using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursatOnline.Data;
using CoursatOnline.Models;

using CoursatOnline.Repositories;
namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IRepository<Student> StdRepo;
        public StudentController(IRepository<Student> repo)
        {
            this.StdRepo = repo;
        }
        
        //getall
        [HttpGet]
        public List<Student> GetAll()
        {
            return StdRepo.getAll().ToList();
        }

        //getById
        [HttpGet("{id}")]
        public ActionResult getById(int id)
        {
            Student std = StdRepo.getById(id);
            if (std == null)
                return NotFound();
            else
                return Ok(std);

        }

        //create
        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                StdRepo.Create(std);
                return Created("url", std);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut]
        public ActionResult edit(int id,Student std)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    StdRepo.Edit(id,std);
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
        public ActionResult delete(int id, Student? std)
        {
            int numOfRows = StdRepo.Delete(id);
            if(numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(std);
            }
        }
    }
}
