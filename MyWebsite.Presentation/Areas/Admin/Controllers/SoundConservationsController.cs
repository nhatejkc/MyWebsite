using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Core;
using MyWebsite.Core.Models;

namespace MyWebsite.Presentation.Areas.Admin.Controllers
{
    public class SoundConservationsController : Controller
    {
        private MyWebsiteDbContext db = new MyWebsiteDbContext();

        // GET: Admin/SoundConservations
        public ActionResult Index()
        {
            var soundConservations = db.SoundConservations.Include(s => s.Actor).Include(s => s.Lession);
            return View(soundConservations.ToList());
        }

        // GET: Admin/SoundConservations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoundConservation soundConservation = db.SoundConservations.Find(id);
            if (soundConservation == null)
            {
                return HttpNotFound();
            }
            return View(soundConservation);
        }

        // GET: Admin/SoundConservations/Create
        public ActionResult Create()
        {
            ViewBag.ActorId = new SelectList(db.Actors, "Id", "ENName");
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "Id");
            return View();
        }

        // POST: Admin/SoundConservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ActorId,LessionId,VietNamese,Japanese,Romaji,PostOn,Modifie")] SoundConservation soundConservation)
        {
            if (ModelState.IsValid)
            {
                soundConservation.PostOn = DateTime.Now;
                db.SoundConservations.Add(soundConservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorId = new SelectList(db.Actors, "Id", "JPName", soundConservation.ActorId);
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "MainConent", soundConservation.LessionId);
            return View(soundConservation);
        }

        // GET: Admin/SoundConservations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoundConservation soundConservation = db.SoundConservations.Find(id);
            if (soundConservation == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorId = new SelectList(db.Actors, "Id", "JPName", soundConservation.ActorId);
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "MainConent", soundConservation.LessionId);
            return View(soundConservation);
        }

        // POST: Admin/SoundConservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ActorId,LessionId,VietNamese,Japanese,Romaji,PostOn,Modifie")] SoundConservation soundConservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soundConservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorId = new SelectList(db.Actors, "Id", "JPName", soundConservation.ActorId);
            ViewBag.LessionId = new SelectList(db.Lessions, "Id", "MainConent", soundConservation.LessionId);
            return View(soundConservation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SaveItem(SoundConservation sound)
        {
            if (ModelState.IsValid)
            {
                sound.Modifie = DateTime.Now;
                db.SoundConservations.AddOrUpdate(sound);
                //db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sound);
        }
        public ActionResult DeleteItem(int id)
        {
            var item = db.SoundConservations.Find(id);
            db.SoundConservations.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Admin/SoundConservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoundConservation soundConservation = db.SoundConservations.Find(id);
            if (soundConservation == null)
            {
                return HttpNotFound();
            }
            return View(soundConservation);
        }

        // POST: Admin/SoundConservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SoundConservation soundConservation = db.SoundConservations.Find(id);
            db.SoundConservations.Remove(soundConservation);
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
