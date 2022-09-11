using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

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

        int faktoriyel(int p)
        {
            int f = 1;
            for(int i=1;i<=p;i++)
            {
                f = f * i;
            }
            return f;
        }
        public IActionResult Index()
        {
            mesajlar();
            ViewBag.faktor = faktoriyel(6);
            return View();
        }
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = cevre();
            return  View();
        }

        public IActionResult Deneme()
        {

            Sehirler sehirler = new Sehirler();
            Bayrak bayrak = new Bayrak();  


            sehirler.AD = "Kiev";
            sehirler.ID = 1;
            sehirler.Nufus = 1000000;
            sehirler.ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Beyaz";


            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.ulke;
            ViewBag.v3 = sehirler.AD;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            sehirler.ID = 2;
            sehirler.AD = "Üsküp";
            sehirler.ulke = "Makedonya";
            sehirler.Nufus = 500000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";


            ViewBag.z1=sehirler.ID;
            ViewBag.z2=sehirler.ulke;
            ViewBag.z3=sehirler.AD;
            ViewBag.z4=sehirler.Nufus;
            ViewBag.z5=sehirler.Renk1;
            ViewBag.z6=sehirler.Renk2;
            ViewBag.z7=sehirler.Renk3;



            return View();
        }
    }
}
