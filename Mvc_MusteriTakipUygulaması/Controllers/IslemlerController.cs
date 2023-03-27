using Microsoft.AspNetCore.Mvc;
using Mvc_MusteriTakipUygulaması.Models;

namespace Mvc_MusteriTakipUygulaması.Controllers
{

    public class IslemlerController : Controller
    {
        private Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Clients.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult AddClient()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddClient(Client p)
        {
            c.Clients.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DeleteClient(int id)
        {
            var client = c.Clients.Find(id);
            c.Clients.Remove(client);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult GetClient(int id)
        {

            var getClient = c.Clients.Find(id);
            return View("GetClient", getClient);

        }


        public IActionResult UpdateClient(Client p)
        {

            var x = c.Clients.Find(p.MusteriID);
            x.Unvan = p.Unvan;
            x.VergiNo = p.VergiNo;
            x.VergiDairesi = p.VergiDairesi;
            x.TelNo = p.TelNo;
            x.Adres = p.Adres;
            x.WebSitesi = p.WebSitesi;
            x.Email = p.Email;
            x.ImzaYetkilisiAdiSoyadi1 = p.ImzaYetkilisiAdiSoyadi1;
            x.ImzaYetkilisiAdiSoyadi2 = p.ImzaYetkilisiAdiSoyadi2;
            x.ImzaYetkilisiAdiSoyadi3 = p.ImzaYetkilisiAdiSoyadi3;
            x.ImzaYetkilisiMail1 = p.ImzaYetkilisiMail1;
            x.ImzaYetkilisiMail2 = p.ImzaYetkilisiMail2;
            x.ImzaYetkilisiMail3 = p.ImzaYetkilisiMail3;
            x.IletisimYetkilisiAdiSoyadi1 = p.IletisimYetkilisiAdiSoyadi1;
            x.IletisimYetkilisiAdiSoyadi2 = p.IletisimYetkilisiAdiSoyadi2;
            x.IletisimYetkilisiAdiSoyadi3 = p.IletisimYetkilisiAdiSoyadi3;
            x.Marka = p.Marka;
            x.Tarih = p.Tarih;

            c.SaveChanges();
            return RedirectToAction("Index", "Islemler");
            
        }

        public IActionResult ClientDetailTable(int id)
        {

            var detail = c.Clients.Find(id);
            return View("ClientDetailTable", detail);
        }



    }
}
