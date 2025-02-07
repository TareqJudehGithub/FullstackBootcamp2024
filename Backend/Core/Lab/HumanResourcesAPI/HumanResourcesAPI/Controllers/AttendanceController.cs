using HumanResourcesAPI.Data;
using HumanResourcesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase    // Api Parent ControllerBase
    {
        #region Fields
        private AppDbContext _dbContext;

        public AttendanceController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        #endregion
        #region Action Methods

        [HttpGet]
        public ActionResult<List<Attendance>> GetAll()
        {
            var model = _dbContext.Attendances.ToList();

            return model;
        }
        [HttpPost]
        public ActionResult Create([FromBody] Attendance attendance)
        {
            if (attendance.CheckIn.Day == DateTime.Now.Day &&
                attendance.CheckIn.Month == DateTime.Now.Month &&
                attendance.CheckIn.Year == DateTime.Now.Year)
            {
                ModelState.AddModelError("CheckIn", "Invalid CheckIn Error");
            }
            if (attendance.CheckOut.Day == DateTime.Now.Day &&
             attendance.CheckOut.Month == DateTime.Now.Month &&
             attendance.CheckOut.Year == DateTime.Now.Year)
            {
                ModelState.AddModelError("CheckIn", "Invalid CheckOut Error");
            }
            if (attendance.AttendDate.Day == DateTime.Now.Day &&
          attendance.AttendDate.Month == DateTime.Now.Month &&
          attendance.AttendDate.Year == DateTime.Now.Year)
            {
                ModelState.AddModelError("CheckIn", "Invalid AttendDate Error");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            if (attendance == null)
            {
                return BadRequest();
            }

            // If all is well
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok("Create was successful!");
        }
        #endregion

        #region Put
        [HttpPut]
        public ActionResult<Attendance> Update(Attendance attendance)
        {
            if (attendance == null)
            {
                return BadRequest();
            }
            // Check if there was no record found
            if (!_dbContext.Attendances.Any(x => x.Id == attendance.Id))
            {
                return NotFound();
            }

            _dbContext.Attendances.Update(attendance);
            _dbContext.SaveChanges();

            return attendance;
        }
        #endregion
    }
}
