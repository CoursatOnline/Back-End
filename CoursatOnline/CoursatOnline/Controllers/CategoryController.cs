using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IRepository<Category> CatRepo;
        IRepositoryGetByName<Category> CatRepoGetByName;
        public CategoryController(IRepository<Category> _repo, IRepositoryGetByName<Category> _CatRepoGetByName)
        {
            this.CatRepo = _repo;
            this.CatRepoGetByName = _CatRepoGetByName;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (CatRepo.getAll().Count > 0)
                return Ok(CatRepo.getAll());
            else
                return NotFound();
        }
        //getAllByName
        [HttpGet]
        public ActionResult GetAllByName(string word)
        {
            if (CatRepoGetByName.getAllByName(word).Count > 0)
                return Ok(CatRepoGetByName.getAllByName(word));
            else
                return NotFound();
        }
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Category category = CatRepo.getById(id);
            if (category == null)
                return NotFound();
            else
                return Ok(category);

        }
        //getByName
        [HttpGet("{name:alpha}")]
        public ActionResult getByName(string name)
        {
            Category category = CatRepoGetByName.getByName(name);
            if (category == null)
                return NotFound();
            else
                return Ok(category);
        }
        //create
        //[Authorize("Admin")]
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                CatRepo.Create(category);
                return Created("url", category);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CatRepo.Edit(id, category);
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
        public ActionResult delete(int id, Category? category)
        {
            int numOfRows = CatRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(category);
            }
        }

    }
}
