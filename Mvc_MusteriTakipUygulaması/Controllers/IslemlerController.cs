using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_MusteriTakipUygulaması.Models;
using Mvc_MusteriTakipUygulaması.Models.ResponseModel;

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
            var client = c.Clients.FirstOrDefault(x => x.MusteriID == id);
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
            x.IconLogo = p.IconLogo;

            c.SaveChanges();
            return RedirectToAction("Index", "Islemler");

        }

        public IActionResult ClientDetailTable(int id)
        {

            var detail = c.Clients.Find(id);
            return View("ClientDetailTable", detail);
        }


        public IActionResult WorkList()
        {
            var work = c.WorkLists.Include(x => x.Client).ToList();
            return View(work);
        }


        [HttpGet]
        public IActionResult YeniIsEkle(int? id)
        {
            ViewBag.ClientId = id.HasValue;

            return View();
        }


        [HttpPost]
        public IActionResult YeniIsEkle(WorkList p)
        {

            var ekle = c.Clients.SingleOrDefault(x => x.MusteriID == p.MusteriID);

            if (ekle != null)
            {
                c.WorkLists.Add(p);
                c.SaveChanges();
            }

            return RedirectToAction("WorkList");
        }


        [HttpGet]
        public IActionResult GetClientList()
        {
            var data = c.Clients.Select(x => new ClientComboModel()
            {
                Id = x.MusteriID,
                ClientName = x.Unvan
            }).ToList();
            return Ok(data);
        }



        public IActionResult DeleteWork(int id)
        {
            
            var work = c.WorkLists.FirstOrDefault(x => x.WorkID == id);
            c.WorkLists.Remove(work);
            c.SaveChanges();
            return RedirectToAction("WorkList");

        }



        public IActionResult GetWork(int id)
        {

            var getWork = c.WorkLists.FirstOrDefault(x => x.WorkID == id);
            return View("GetWork", getWork);

        }


        public IActionResult UpdateWork(WorkList p)
        {

            var x = c.WorkLists.FirstOrDefault(x => x.WorkID == p.WorkID);
            if (x!= null)
            {
                x.MusteriID = p.MusteriID;
                x.Tarih = p.Tarih;
                x.YapilacakIs = p.YapilacakIs;
                x.KurumAdi = p.KurumAdi;
                x.IsiTakipEdenPersonel = p.IsiTakipEdenPersonel;
                x.IsinTeslimEdilecegiYetkili = p.IsinTeslimEdilecegiYetkili;
                x.HizmetBedeli = p.HizmetBedeli;
                x.HarcBedeli = p.HarcBedeli;
                x.ToplamFaturaBedeli = p.ToplamFaturaBedeli;

                c.SaveChanges();
            }
            return RedirectToAction("WorkList", "Islemler");

        }
        

    }
}
