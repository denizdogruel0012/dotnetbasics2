using System.Diagnostics;
using dotnetbasics2.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetbasics2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int sayi=10;
            int sayi2=20;
            int toplam=sayi+sayi2;
            ViewData["Toplam"]=toplam;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
