using Microsoft.AspNetCore.Mvc;
using Mvc_MusteriTakipUygulaması.Models;
using Mvc_MusteriTakipUygulaması.Models.Repositories;

namespace Mvc_MusteriTakipUygulaması.Controllers
{
    public class UserListController : Controller
    {
        private Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult AddUser()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddUser(Admin p)
        {
            c.Admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}
