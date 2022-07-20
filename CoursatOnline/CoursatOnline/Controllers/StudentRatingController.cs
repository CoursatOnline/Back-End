using CoursatOnline.Models;
using CoursatOnline.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursatOnline.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StudentRatingController : ControllerBase
    {
        StudentRatingInteface StdRateRepo;
        public StudentRatingController(StudentRatingInteface _repo)
        {
            this.StdRateRepo = _repo;
        }
        //getall
        [HttpGet]
        public ActionResult GetAll()
        {
            if (StdRateRepo.getAll().Count > 0)
                return Ok(StdRateRepo.getAll());
            else
                return NotFound();
        }

        //get all Rating By StudentId
        [HttpGet("{id:int}")]
        public ActionResult getAllRating(int stdId, int courseId)
        {
            List<Rating> rates = StdRateRepo.getAllRating(stdId, courseId);
            if (StdRateRepo == null)
                return NotFound();
            else
                return Ok(rates);

        }

        //get all category By courseId
        [HttpGet("{id:int}")]
        public ActionResult getAllStudent(int rateId, int coursed)
        {
            List<Student> students = StdRateRepo.getAllStudent(rateId, coursed);
            if (StdRateRepo == null)
                return NotFound();
            else
                return Ok(students);

        }

        //create
        [HttpPost]
        public ActionResult Create(StudentRating stdRate)
        {
            if (ModelState.IsValid)
            {

                int num = StdRateRepo.Create(stdRate);
                if (num >= 0)
                {
                    return Created("url", stdRate);
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
        public ActionResult edit(int stdId, int rateId, int coursed, StudentRating stdRate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int num = StdRateRepo.EditComposit(stdId, rateId, coursed, stdRate);
                    if (num >= 0)
                    {
                        return Content("Updated");
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            return BadRequest(ModelState);
        }
        //delete
        [HttpDelete("{id}")]
        public ActionResult delete(int stdId, int rateId, int coursed, StudentRating? stdRate)
        {
            int numOfRows = StdRateRepo.DeleteComposit(stdId, rateId, coursed);
            if (numOfRows <= 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(stdRate);
            }
            return Ok();
        }

    }
}
