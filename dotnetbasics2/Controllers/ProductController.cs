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
            string productName="İphone 13";
            int productPrice=50000;
            string productDescription="Geleceğin telefonu";
            string productImage="İphone13.jpg";
            bool satisDurumu=true;
            ViewData["ProductName"]=productName;
            ViewData["ProductPrice"]=productPrice;
            ViewData["ProductDescription"]=productDescription;
            ViewData["ProductImage"]=productImage;
            ViewData["SatisDurumu"]=satisDurumu;
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
