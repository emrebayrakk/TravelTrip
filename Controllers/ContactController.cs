using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.sınıflar;

namespace TravelTrip.Controllers
{
    public class ContactController : Controller
    {
        context c = new context();
        // GET: Contact
        public ActionResult Index()
        {
          
            return View();
        }
        [HttpGet]
        public ActionResult yeniMail()
        {
            return View();

        }
        [HttpPost]
        public ActionResult yeniMail(iletisim p)
        {
            c.iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}