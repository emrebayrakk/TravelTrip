using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.sınıflar;

namespace TravelTrip.Controllers
{
    public class KitaplarController : Controller
    {
        // GET: Kitaplar
        context c = new context();
        kitapyorum kp = new kitapyorum();
        filmDiziyorum fm = new filmDiziyorum();
        müzikyorum mz = new müzikyorum();
        public ActionResult Index()
        {
            kp.deger1 = c.kitaplars.ToList();
            kp.deger3 = c.kitaplars.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(kp);
           
        }
        public ActionResult kitapDetay(int id)
        {
          
            kp.deger1 = c.kitaplars.Where(x => x.ID == id).ToList();
            return View(kp);
        }
        public ActionResult filmDiziler()
        {
            fm.deger1 = c.filmDizis.ToList();
            fm.deger3 = c.filmDizis.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(fm);
        }
        public ActionResult filmdiziDetay(int id)
        {
            
            fm.deger1 = c.filmDizis.Where(x => x.ID == id).ToList();
            return View(fm);
        }
        public ActionResult müzikler()
        {
            mz.deger1 = c.müziklers.ToList();
            mz.deger3 = c.müziklers.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(mz);
        }

    }
}