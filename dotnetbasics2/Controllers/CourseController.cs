using Microsoft.AspNetCore.Mvc;

namespace dotnetbasics2.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
