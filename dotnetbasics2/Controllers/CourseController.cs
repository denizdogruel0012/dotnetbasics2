using dotnetbasics2.Models;
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
           
            Course kurs1 = new Course();
            kurs1.Title = "Django kursu";
            kurs1.Image = "1.jpg";
            return View(kurs1);
        }
        public IActionResult List()
        {
          
            
       
            return View();
        }
    }
}
