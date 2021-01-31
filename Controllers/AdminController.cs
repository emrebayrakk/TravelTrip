using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.sınıflar;
namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        context c = new context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult yeniBlog()
        {
            return View();

        }
        [HttpPost]
        public ActionResult yeniBlog(blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult blogSil(int id)
        {
            var b = c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult blogGetir(int id)
        {
            var bl = c.blogs.Find(id);
            return View("blogGetir", bl);
        }
        public ActionResult blogGüncelle(blog b)
        {
            var blg = c.blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult yorumListesi()
        {
            var yorumlar = c.yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult yorumSil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("yorumListesi");
        }
        public ActionResult yorumGetir(int id)
        {
            var yr = c.yorumlars.Find(id);
            return View("yorumGetir", yr);
        }
        public ActionResult yorumGüncelle(yorumlar y)
        {
            var yrm = c.yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("yorumListesi");
        }
        public ActionResult kitapIndex()
        {
            var degerler = c.kitaplars.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult yeniKitap()
        {
            return View();

        }
        [HttpPost]
        public ActionResult yeniKitap(kitaplar p)
        {
            c.kitaplars.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult kitapSil(int id)
        {
            var b = c.kitaplars.Find(id);
            c.kitaplars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult kitapGetir(int id)
        {
            var kp = c.kitaplars.Find(id);
            return View("kitapGetir", kp);
        }
        public ActionResult kitapGüncelle(kitaplar k)
        {
            var kitap = c.kitaplars.Find(k.ID);
            kitap.kitapAciklama = k.kitapAciklama;
            kitap.kitapBaslik = k.kitapBaslik;
            kitap.kitapImage = k.kitapImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}