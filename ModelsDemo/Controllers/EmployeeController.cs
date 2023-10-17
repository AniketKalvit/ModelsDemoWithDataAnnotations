using Microsoft.AspNetCore.Mvc;
using ModelsDemo.Models;

namespace ModelsDemo.Controllers
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
