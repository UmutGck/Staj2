using OpenLayer_Map.Context;
using OpenLayer_Map.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace OpenLayer_Map.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseContext db = new DataBaseContext();
        private object kapi;

        public object var_coords { get; private set; }
        public object _coords { get; private set; }

        public ActionResult Index()
        {
            return View("~/Views/Home/Map.cshtml");
        }
        public ActionResult Map()
        {
            return View("~/Views/Home/Map.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Panel()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult SavePoint()
        {
            return Json("");
        }

        [HttpGet]
          public JsonResult List()
        {
            var_coords = db.Kapis.ToList();
          return Json(_coords, JsonRequestBehavior.AllowGet);

         }

          private JsonResult Json(object _coords, JsonRequestBehavior allowGet)
           {
              throw new NotImplementedException();
          }

        [HttpPost]
        public JsonResult SavePoint(Kapi kapi, double x, double y, string no)
        {

            if (ModelState.IsValid)
            {
                kapi.KapiNo = no;
                kapi.x = x;
                kapi.y = y;
                db.Kapis.Add(kapi);
                db.SaveChanges();
            }
            return Json("");
        }

        [HttpPost]
        public ActionResult SavePoint2(Kapi kapi, double x, double y, string no)
        {

            if (ModelState.IsValid)
            {
                kapi.KapiNo = no;
                kapi.x = x;
                kapi.y = y;
                db.Kapis.Add(kapi);
                db.SaveChanges();
            }
            return Json("");
        }

        public JsonResult BilgiVer(int? id, string tip)
        {

            if (id == null)
            {
                return Json(new { hata = "ID Bilgisi Gönderilmedi" });
            }

            if (tip == "Kapı")
            {
               // Kapi kapi = db.Kapi.Find(id);

                if (kapi == null)
                {
                    return Json(new { hata = "Bilgi Bulunamadı" });
                }
                else
                {
                    return Json(new { bilgi = kapi });
                }

            }


            return Json(new { bilgi = "" });
        }

        public JsonResult MahalleListele()
        {
            var cord_deger = db.MahalleList.ToList();
            return Json(cord_deger, JsonRequestBehavior.AllowGet);
        }
    }

   

}
     
  