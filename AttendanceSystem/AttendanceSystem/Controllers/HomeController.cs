using AttendanceSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Schedule()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Schedule(IFormCollection f)
        {
            AttendanceSystemContext con = new AttendanceSystemContext();
           
            var query = from schedule in con.Schedules
                        join subject in con.Subjects
                        on schedule.SubjectId equals subject.SubjectId
                        select new
                        {
                            schedule.Slot,
                            schedule.DateTime,
                            subject.SubjectName
                        };

            var result = query.ToList();

            var sortedSchedules = result
                .OrderBy(schedule => schedule.DateTime.Value.DayOfWeek)
                .ToList();
            ViewBag.Schedule = sortedSchedules;
            return View();
        }

    }
}
