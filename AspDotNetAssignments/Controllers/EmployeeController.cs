using AspDotNetAssignments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetAssignments.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return View();
        }
    }
}
