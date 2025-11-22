using dotnetbasics2.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetbasics2.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Product urun1 = new Product();
            urun1.UrunBaslik = "Samsung Galaxy S24";
            urun1.UrunAciklama = "Samsung Galaxy S24, üstün performans ve şık tasarımıyla dikkat çekiyor.";
            urun1.UrunResim = "samsung-s24.jpg";
            urun1.Fiyat = 999.99;
            urun1.Yayindami = true;
            return View(urun1);
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
