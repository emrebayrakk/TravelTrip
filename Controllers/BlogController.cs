using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.sınıflar;
namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        context c = new context();
        blogyorum by = new blogyorum();
        public ActionResult Index()
        {
            //var bloglar = c.blogs.ToList();
            by.deger1 = c.blogs.ToList();
            by.deger2 = c.yorumlars.OrderByDescending(x => x.ID).Take(5).ToList();
            by.deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
        
        public ActionResult blogDetay(int id)
        {
            //var blogbul = c.blogs.Where(x =>x.ID==id).ToList();
            by.deger1 = c.blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        
        public ActionResult yorumYap(blog b)
        {
            c.blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public PartialViewResult yorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        
        [HttpPost]
        public PartialViewResult yorumYap(yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}