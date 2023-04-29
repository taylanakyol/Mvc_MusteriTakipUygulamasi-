using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_MusteriTakipUygulaması.Models;

namespace Mvc_MusteriTakipUygulaması.Controllers
{
    public class AnaEkranController : Controller
    {
        private Context c = new Context();
        public IActionResult Index()
        {
            var work = c.WorkLists.Include(x => x.Client).ToList();
            return View(work);
        }

       


    }
}
