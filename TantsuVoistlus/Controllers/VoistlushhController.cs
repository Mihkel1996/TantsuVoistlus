using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TantsuVoistlus.Models;

namespace TantsuVoistlus.Controllers
{
    public class VoistlushhController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        [HttpGet]
        public ActionResult SisestaHinne()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult SisestaHinne([Bind(Include = "Id, Voistluspaar, Hinded1, Hinded2, Hinded3, KeskmineHinne")] Voistlus voistlus)
        {
            if(ModelState.IsValid)
            {
                db.Voistlus.Add(voistlus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(voistlus);
        }
        public ActionResult Hinded()
        {
            return View();
        }
        public ActionResult HindedTulemus(int? id)
        {
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voistlus voistlus = db.Voistlus.Find(id);
            if (voistlus == null)
            {
                return RedirectToAction("Index");
            }
            return View(id);
        }


        // GET: Voistlus
        public ActionResult Index()
        {
            return View(db.Voistlus.ToList());
        }

        // GET: Voistlus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voistlus voistlus = db.Voistlus.Find(id);
            if (voistlus == null)
            {
                return HttpNotFound();
            }
            return View(voistlus);
        }

        // GET: Voistlus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voistlus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Voistluspaar,Hinded1,Hinded2,Hinded3,KeskmineHinne")] Voistlus voistlus)
        {
            if (ModelState.IsValid)
            {
                db.Voistlus.Add(voistlus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(voistlus);
        }

        // GET: Voistlus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voistlus voistlus = db.Voistlus.Find(id);
            if (voistlus == null)
            {
                return HttpNotFound();
            }
            return View(voistlus);
        }

        // POST: Voistlus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Voistluspaar,Hinded1,Hinded2,Hinded3,KeskmineHinne")] Voistlus voistlus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(voistlus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(voistlus);
        }

        // GET: Voistlus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voistlus voistlus = db.Voistlus.Find(id);
            if (voistlus == null)
            {
                return HttpNotFound();
            }
            return View(voistlus);
        }

        // POST: Voistlus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Voistlus voistlus = db.Voistlus.Find(id);
            db.Voistlus.Remove(voistlus);
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
