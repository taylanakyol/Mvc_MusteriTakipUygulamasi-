using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc_MusteriTakipUygulaması.Models;

namespace Mvc_MusteriTakipUygulaması.Controllers
{
    public class MusteriOzetController : Controller
    {
        private Context c = new Context(); 
        public IActionResult Index()
        {
            var musteri = c.Clients.ToList();
            return View(musteri);
        }
    }
}
