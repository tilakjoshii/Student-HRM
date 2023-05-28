using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student_Table()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
