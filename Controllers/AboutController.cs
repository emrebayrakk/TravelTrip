using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.sınıflar;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        context c = new context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = c.hakkımızdas.ToList();
            return View(degerler);
        }
    }
}