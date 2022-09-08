using Microsoft.AspNetCore.Mvc;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {


        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "merhaba proje çok iyi";
            ViewBag.m3 = "SELLAM";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int c= 2* (kisa+ uzun);
            return c;
        }
        public IActionResult Index()
        {
            mesajlar();
            
            return View();
        }
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = cevre();
            return  View();
        }
    }
}
