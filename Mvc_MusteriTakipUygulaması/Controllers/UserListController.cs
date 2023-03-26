using Microsoft.AspNetCore.Mvc;
using Mvc_MusteriTakipUygulaması.Models;
using Mvc_MusteriTakipUygulaması.Models.Repositories;

namespace Mvc_MusteriTakipUygulaması.Controllers
{
    public class UserListController : Controller
    {
        private UserListRepository userListRepository = new UserListRepository();
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

        public IActionResult DeleteUser(int id)
        {
            var user = c.Admins.Find(id);
            c.Admins.Remove(user);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetUser(int id)
        {
            var getUser = c.Admins.Find(id);
            return View("GetUser", getUser);
        }

        
        public IActionResult UpdateUser(Admin p)
        {
            var x = c.Admins.Find(p.AdminID);
            x.Name=p.Name;
            x.Surname=p.Surname;
            x.Company=p.Company;
            x.UserName=p.UserName;
            x.Password=p.Password;
            x.AdminRole=p.AdminRole;

            c.SaveChanges();
            return RedirectToAction("Index","UserList");



        }


    }
}
