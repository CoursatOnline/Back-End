using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        IRepositoryGetByName<Category> CatRepoGetByName;
        IRepositoryGetByName<Course> CourseRepoGetByName;
        public SearchController(IRepositoryGetByName<Category> _CatRepoGetByName, IRepositoryGetByName<Course> _CourseRepoGetByName)
        {
            CatRepoGetByName = _CatRepoGetByName;
            CourseRepoGetByName = _CourseRepoGetByName;
        }

        [HttpGet]
        public ActionResult getAny([FromBody]string s)
        {
            List<Course> crss = CourseRepoGetByName.getAllByName(s).ToList();
            if (crss.Count > 0)
                return Ok(crss);
            else
            {
                List<Category> categories = CatRepoGetByName.getAllByName(s).ToList();
                if (categories.Count > 0)
                    return Ok(categories);
                else
                    return NotFound();
            }
                    
        }

    }
}
