using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ChapterController : Controller
    {
        IRepository<Chapter> repo;
        IRepositoryGetByName<Chapter> ChapterRepoGetByName;
        IRepositoryGetAllChaptersByCrsId ChaptersRepoGetByCrsId;
        public ChapterController(IRepository<Chapter> _repo, IRepositoryGetByName<Chapter> _ChapterRepoGetByName, IRepositoryGetAllChaptersByCrsId _ChaptersRepoGetByCrsId)
        {
            this.repo = _repo;
            this.ChapterRepoGetByName = _ChapterRepoGetByName;
            this.ChaptersRepoGetByCrsId = _ChaptersRepoGetByCrsId;
        }
        //--------------------------------------------Get All Chapters--------------------------------------------

        [HttpGet]
        public ActionResult GetAll()
        {
            if (repo.getAll().Count > 0)
                return Ok(repo.getAll());
            else
                return NotFound("Not Found Any Chapter");
        }
        //--------------------------------------------Get Chapter By Id--------------------------------------------
        //getById
        [HttpGet("{id:int}")]
        public ActionResult getById(int id)
        {
            Chapter chapter = repo.getById(id);
            if (chapter == null)
                return NotFound();
            else
                return Ok(chapter);

        }
        //--------------------------------------------getAllByName--------------------------------------------
        [HttpGet]
        public ActionResult GetAllByName(string word)
        {
            if (ChapterRepoGetByName.getAllByName(word).Count > 0)
                return Ok(ChapterRepoGetByName.getAllByName(word));
            else
                return NotFound("Not Found Any Chapter");
        }
        //--------------------------------------------getAllChaptersByCrsId--------------------------------------------
        [HttpGet("{crsid:int}")]
        public ActionResult GetAllByCrsId(int crsid)
        {
            if (ChaptersRepoGetByCrsId.getAllByCrsId(crsid).Count > 0)
                return Ok(ChaptersRepoGetByCrsId.getAllByCrsId(crsid));
            else
                return NotFound("Not Found Any Chapter");
        }

        //--------------------------------------------GetByName--------------------------------------------

        [HttpGet("{name:alpha}")]
        public ActionResult GetByName(string name)
        {
            Chapter chapter = ChapterRepoGetByName.getByName(name);
            if (chapter == null)
            {
                return NotFound("Not Found Chapter By This Name");
            }
            else
            {
                return Ok(chapter);
            }

        }

        //--------------------------------------------create--------------------------------------------
        [HttpPost]
        public ActionResult Create(Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                repo.Create(chapter);
                return Created("url", chapter);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        //--------------------------------------------Edite Course--------------------------------------------
        //update
        [HttpPut("{id}")]
        public ActionResult edit(int id, Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.Edit(id, chapter);
                    return Content("Updated");
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
        public ActionResult delete(int id, Chapter? chapter)
        {
            int numOfRows = repo.Delete(id);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(chapter);
            }
        }
    }
}
