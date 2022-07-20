using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegisterController : ControllerBase
    {
        IRepository<StudentRegisters> repo;

        public StudentRegisterController(IRepository<StudentRegisters> _repo)
        {
            repo = _repo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (repo.getAll().Count > 0)
                return Ok(repo.getAll());
            else
                return NotFound();
        }

        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            StudentRegisters stdreg = repo.getById(id);
            if (stdreg == null)
                return NotFound();
            else
                return Ok(stdreg);

        }

        //create
        [HttpPost]
        public ActionResult Create(StudentRegisters stdreg)
        {
            if (ModelState.IsValid)
            {
                repo.Create(stdreg);
                return Created("url", stdreg);
            }

            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, StudentRegisters stdreg)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.Edit(id, stdreg);
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
        public ActionResult delete(int id, StudentRegisters? stdreg)
        {
            int numOfRows = repo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(stdreg);
            }
        }
    }
}
