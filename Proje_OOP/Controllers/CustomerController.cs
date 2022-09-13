using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if (p.Name.Length >= 6 && p.City != "" && p.City.Length > 3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            else {
                ViewBag.message = "Hatalı Kullanım";
                return View();
            }


        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.customers.Where(x => x.ID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.customers.Where(x => x.ID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.customers.Where(x => x.ID == p.ID).FirstOrDefault();
            value.City = p.City;
            value.Name = p.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
