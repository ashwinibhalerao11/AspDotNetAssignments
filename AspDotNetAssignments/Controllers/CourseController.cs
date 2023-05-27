using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspDotNetAssignments.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult CreateCourse()
        {
            List<string> options = new List<string>() { "Select Option", "Yes", "No" };
            ViewData["options"] = new SelectList(options);
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Gender = form["gender"];
            ViewBag.Course = form["course"];
            ViewBag.Option = form["options"];
            return View("Details");
        }
    }
}

