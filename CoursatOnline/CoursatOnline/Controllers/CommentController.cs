using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        IRepository<Comment> CommentRepo;
       
        public CommentController(IRepository<Comment> _CommentRepo)
        {
            CommentRepo = _CommentRepo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (CommentRepo.getAll().Count > 0)
                return Ok(CommentRepo.getAll());
            else
                return NotFound();
        }
       
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Comment comment = CommentRepo.getById(id);
            if (comment == null)
                return NotFound();
            else
                return Ok(comment);

        }
       
        //create
        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                CommentRepo.Create(comment);
                return Created("url", comment);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Comment comment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CommentRepo.Edit(id, comment);
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
        public ActionResult delete(int id, Comment? comment)
        {
            int numOfRows = CommentRepo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(comment);
            }
        }
    }
}
