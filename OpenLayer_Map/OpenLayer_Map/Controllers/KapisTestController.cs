using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenLayer_Map.Context;
using OpenLayer_Map.Entity;

namespace OpenLayer_Map.Controllers
{
    public class KapisTestController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Kapis
        public ActionResult Index()
        {
            return View(db.Kapis.ToList());
        }

        // GET: Kapis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kapi kapi = db.Kapis.Find(id);
            if (kapi == null)
            {
                return HttpNotFound();
            }
            return View(kapi);
        }

        // GET: Kapis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kapis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,x,y,KapiNo")] Kapi kapi)
        {
            if (ModelState.IsValid)
            {
                db.Kapis.Add(kapi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kapi);
        }

        // GET: Kapis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kapi kapi = db.Kapis.Find(id);
            if (kapi == null)
            {
                return HttpNotFound();
            }
            return View(kapi);
        }

        // POST: Kapis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,x,y,KapiNo")] Kapi kapi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kapi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kapi);
        }

        // GET: Kapis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kapi kapi = db.Kapis.Find(id);
            if (kapi == null)
            {
                return HttpNotFound();
            }
            return View(kapi);
        }

        // POST: Kapis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kapi kapi = db.Kapis.Find(id);
            db.Kapis.Remove(kapi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
