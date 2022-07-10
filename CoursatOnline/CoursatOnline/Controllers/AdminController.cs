using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IRepository<Admin> AdminRepo;
        IRepositoryGetByName<Admin> AdminRepoGetByName;
        public AdminController(IRepository<Admin> _AdminRepo, IRepositoryGetByName<Admin> _AdminRepoGetByName)
        {
            AdminRepo = _AdminRepo;
            AdminRepoGetByName = _AdminRepoGetByName;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (AdminRepo.getAll().Count > 0)
                return Ok(AdminRepo.getAll());
            else
                return NotFound();
        }
        //getAllByName
        [HttpGet]
        public ActionResult GetAllByName(string word)
        {
            if (AdminRepoGetByName.getAllByName(word).Count > 0)
                return Ok(AdminRepoGetByName.getAllByName(word));
            else
                return NotFound();
        }
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Admin admin = AdminRepo.getById(id);
            if (admin == null)
                return NotFound();
            else
                return Ok(admin);

        }
        //getByName
        [HttpGet("{name:alpha}")]
        public ActionResult getByName(string name)
        {
            Admin admin = AdminRepoGetByName.getByName(name);
            if (admin == null)
                return NotFound();
            else
                return Ok(admin);
        }
        //create
        [HttpPost]
        public ActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                AdminRepo.Create(admin);
                return Created("url", admin);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Admin admin)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AdminRepo.Edit(id, admin);
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
        public ActionResult delete(int id,Admin? admin)
        {
            int numOfRows = AdminRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(admin);
            }
        }
    }
}
