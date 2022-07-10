using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        IRepository<Instructor> InstrucrorRepo;
        IRepositoryGetByName<Instructor> InstructorRepoGetByName;
        public InstructorController(IRepository<Instructor> _InstrucrorRepo, IRepositoryGetByName<Instructor> _InstructorRepoGetByName)
        {
            InstrucrorRepo = _InstrucrorRepo;
            InstructorRepoGetByName = _InstructorRepoGetByName;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (InstrucrorRepo.getAll().Count > 0)
                return Ok(InstrucrorRepo.getAll());
            else
                return NotFound();
        }
        //getAllByName
        [HttpGet]
        public ActionResult GetAllByName(string word)
        {
            if (InstructorRepoGetByName.getAllByName(word).Count > 0)
                return Ok(InstructorRepoGetByName.getAllByName(word));
            else
                return NotFound();
        }
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Instructor instructor = InstrucrorRepo.getById(id);
            if (instructor == null)
                return NotFound();
            else
                return Ok(instructor);

        }
        //getByName
        [HttpGet("{name:alpha}")]
        public ActionResult getByName(string name)
        {
            Instructor instructor = InstructorRepoGetByName.getByName(name);
            if (instructor == null)
                return NotFound();
            else
                return Ok(instructor);
        }
        //create
        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                InstrucrorRepo.Create(instructor);
                return Created("url", instructor);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InstrucrorRepo.Edit(id, instructor);
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
        public ActionResult delete(int id, Instructor? instructor)
        {
            int numOfRows = InstrucrorRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(instructor);
            }
        }
    }
}
